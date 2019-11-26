using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using CertificateManager.Infrastructure;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace CertificateManager.Services
{
    // tipo route contraints
    //{"int", typeof (IntToken)},
    //{"bool", typeof (BoolToken)},
    //{"datetime", typeof (DateTimeToken)},
    //{"decimal", typeof (DecimalToken)},
    //{"double", typeof (DoubleToken)},
    //{"float", typeof (FloatToken)},
    //{"guid", typeof (GuidToken)},
    //{"long", typeof (LongToken)}
    //{"hexbigint", typeof (HexBigIntegerToken)}

    // este serviço serve para geral dinamicamente uri para os pontos de distribuição da CA, Crl list e OCSP
    // exemplo, usando o model bindar abaixo:
    // http://url.com/{issuerid:hexbigint}/ca 

    public class CertificateUrlTemplateBindModel
    {
        public CertificateUrlTemplateBindModel(
            string name,
            string subject,
            string issuer,
            string keyId,
            string issuerId,
            string serialNumber,
            DateTime notBefore,
            DateTime notAfter)
        {
            Name = name;
            Subject = subject;
            Issuer = issuer;
            KeyId = keyId;
            IssuerId = issuerId;
            SerialNumber = serialNumber;
            NotBefore = notBefore;
            NotAfter = notAfter;
        }

        public CertificateUrlTemplateBindModel()
        {
        }

        public string Name { get; set; }
        public string Subject { get; set; }
        public string Issuer { get; set; }

        public string KeyId { get; set; } // HexBigInteger
        public string IssuerId { get; set; } // HexBigInteger
        public string SerialNumber { get; set; } // HexBigInteger
        public DateTime NotBefore { get; set; }
        public DateTime NotAfter { get; set; }
    }

    public interface IUrlEvaluator
    {
        string Evaluate(string url, object context);
    }

    public class DefaultUrlEvaluator : IUrlEvaluator
    {
        public string Evaluate(string url, object context)
        {
            IList<IToken> tokens = new URLTokenizer().Parse(url);

            List<string> results = tokens.Select(token => token.Evaluate(context)).ToList();

            return String.Join("", results);
        }
    }

    public class ParsedSegment
    {
        private string _value = String.Empty;

        public string Value
        {
            get { return _value; }
        }

        public void Push(Char character)
        {
            _value = String.Concat(_value, character);
        }

        public bool IsEmpty()
        {
            return String.IsNullOrWhiteSpace(_value);
        }
    }

    public class URLTokenizer
    {
        public IList<IToken> Parse(string url)
        {
            if (!String.IsNullOrWhiteSpace(url))
            {
                return Tokenize(url);
            }

            return null;
        }

        private void RegisterToken(IList<IToken> tokens, ParsedSegment segment)
        {
            if (!segment.IsEmpty())
            {
                tokens.Add(TokenFactory.Create(segment.Value));
            }
        }

        private void RegisterStaticToken(IList<IToken> tokens, ParsedSegment segment)
        {
            if (!segment.IsEmpty())
            {
                tokens.Add(new StaticToken(segment.Value));
            }
        }

        private IList<IToken> Tokenize(string input)
        {
            // neste nivel e como não temos segmentos recursivos, teremos sempre um  StaticToken
            var tokens = new List<IToken>();
            CharEnumerator @enum = input.GetEnumerator();
            var segment = new ParsedSegment();
            while (@enum.MoveNext())
            {
                if (@enum.Current == '{')
                {
                    RegisterStaticToken(tokens, segment); // push do que temos até ao momento
                    ParseConstraint(@enum, tokens);
                    segment = new ParsedSegment(); // começamos um novo
                }
                else
                {
                    segment.Push(@enum.Current);
                }
            }
            RegisterStaticToken(tokens, segment);

            return tokens.ToArray();
        }

        private void ParseConstraint(CharEnumerator @enum, List<IToken> tokens)
        {
            bool done = false;
            @enum.MoveNext(); // eliminar '{'
            var property = new ParsedSegment();
            do
            {
                if (@enum.Current == '}')
                {
                    done = true;
                    break;
                }

                property.Push(@enum.Current);
            } while (@enum.MoveNext());

            RegisterToken(tokens, property);

            if (!done)
            {
                throw new InvalidOperationException("Expect '}'");
            }
        }
    }

    public class InvalidTokenType : Exception
    {
        public InvalidTokenType(string property)
            : base(property)
        {
        }

        public InvalidTokenType(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected InvalidTokenType(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }

    public interface IToken
    {
        string Evaluate(object context);
    }

    public class StaticToken : IToken
    {
        private readonly string _text = String.Empty;

        public StaticToken(string text)
        {
            _text = text;
        }

        public string Evaluate(object context)
        {
            return _text;
        }
    }

    public abstract class PropertyToken : IToken
    {
        protected string Property = String.Empty;

        protected PropertyToken(string property)
        {
            Property = property;
        }

        public abstract string Evaluate(object context);

        protected object GetPropertyValue(object context)
        {
            const BindingFlags bindingFlags = BindingFlags.IgnoreCase
                                              | BindingFlags.Instance
                                              | BindingFlags.Static
                                              | BindingFlags.Public;

            if (context != null)
            {
                string[] propertyName = Property.Split('.');

                MemberInfo memberInfo = context.GetType().GetProperty(propertyName[0], bindingFlags) ??
                                        (MemberInfo) context.GetType().GetField(propertyName[0], bindingFlags);

                if (memberInfo != null)
                {
                    var memberPropertyInfo = memberInfo as PropertyInfo;
                    object objValue = memberPropertyInfo != null
                        ? memberPropertyInfo.GetValue(context, null)
                        : (memberInfo as FieldInfo).GetValue(context);

                    for (int i = 1; i < propertyName.Length; i++)
                    {
                        if (objValue == null)
                        {
                            throw (new Exception("GetFieldValue: Null Parent Property"));
                        }

                        memberInfo = objValue.GetType().GetProperty(propertyName[i], bindingFlags) ??
                                     (MemberInfo) objValue.GetType().GetField(propertyName[i], bindingFlags);

                        if (memberInfo == null)
                        {
                            throw (new Exception("GetFieldValue: Invalid Property"));
                        }

                        var mi = memberInfo as PropertyInfo;
                        objValue = mi != null
                            ? ((PropertyInfo) memberInfo).GetValue(objValue, null)
                            : ((FieldInfo) memberInfo).GetValue(objValue);
                    }

                    return objValue;
                }
            }

            return null;
        }

        protected string GetPropertyValueAsString(object context)
        {
            return Convert.ToString(GetPropertyValue(context), CultureInfo.InvariantCulture);
        }
    }

    public class StringToken : PropertyToken
    {
        public StringToken(string value)
            : base(value)
        {
        }

        public override string Evaluate(object context)
        {
            return GetPropertyValueAsString(context);
        }
    }

    public class IntToken : PropertyToken
    {
        public IntToken(string property)
            : base(property)
        {
        }

        public override string Evaluate(object context)
        {
            int result;
            if (
                !int.TryParse(GetPropertyValueAsString(context), NumberStyles.Integer, CultureInfo.InvariantCulture,
                    out result))
            {
                throw new InvalidTokenType(Property);
            }
            return result.ToString(CultureInfo.InvariantCulture);
        }
    }

    public class BoolToken : PropertyToken
    {
        public BoolToken(string property)
            : base(property)
        {
        }

        public override string Evaluate(object context)
        {
            bool result;
            if (!bool.TryParse(GetPropertyValueAsString(context), out result))
            {
                throw new InvalidTokenType(Property);
            }

            return result.ToString(CultureInfo.InvariantCulture);
        }
    }

    public class DateTimeToken : PropertyToken
    {
        public DateTimeToken(string property)
            : base(property)
        {
        }

        public override string Evaluate(object context)
        {
            DateTime result;
            if (
                !DateTime.TryParse(GetPropertyValueAsString(context),
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                throw new InvalidTokenType(Property);
            }
            return result.ToString(CultureInfo.InvariantCulture);
        }
    }

    public class DecimalToken : PropertyToken
    {
        public DecimalToken(string property)
            : base(property)
        {
        }

        public override string Evaluate(object context)
        {
            Decimal result;
            if (
                !Decimal.TryParse(GetPropertyValueAsString(context),
                    NumberStyles.Number, CultureInfo.InvariantCulture, out result))
            {
                throw new InvalidTokenType(Property);
            }
            return result.ToString(CultureInfo.InvariantCulture);
        }
    }

    public class DoubleToken : PropertyToken
    {
        public DoubleToken(string property)
            : base(property)
        {
        }

        public override string Evaluate(object context)
        {
            double result;
            if (
                !double.TryParse(GetPropertyValueAsString(context),
                    NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture,
                    out result))
            {
                throw new InvalidTokenType(Property);
            }
            return result.ToString(CultureInfo.InvariantCulture);
        }
    }

    public class FloatToken : PropertyToken
    {
        public FloatToken(string property)
            : base(property)
        {
        }

        public override string Evaluate(object context)
        {
            float result;
            if (
                !float.TryParse(GetPropertyValueAsString(context),
                    NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.InvariantCulture,
                    out result))
            {
                throw new InvalidTokenType(Property);
            }
            return result.ToString(CultureInfo.InvariantCulture);
        }
    }

    public class GuidToken : PropertyToken
    {
        public GuidToken(string property)
            : base(property)
        {
        }

        public override string Evaluate(object context)
        {
            Guid result;
            if (!Guid.TryParse(GetPropertyValueAsString(context), out result))
            {
                throw new InvalidTokenType(Property);
            }
            return result.ToString();
        }
    }

    public class LongToken : PropertyToken
    {
        public LongToken(string property)
            : base(property)
        {
        }

        public override string Evaluate(object context)
        {
            long result;
            if (
                !long.TryParse(GetPropertyValueAsString(context),
                    NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
            {
                throw new InvalidTokenType(Property);
            }
            return result.ToString(CultureInfo.InvariantCulture);
        }
    }

    public class BigIntegerToken : PropertyToken
    {
        public BigIntegerToken(string property)
            : base(property)
        {
        }

        public override string Evaluate(object context)
        {
            var result = new BigInteger(GetPropertyValueAsString(context));

            //return Hex.ToHexString(result.ToByteArray());
            return result.ToString();
        }
    }

    public class HexBigIntegerToken : PropertyToken
    {
        public HexBigIntegerToken(string property)
            : base(property)
        {
        }

        public override string Evaluate(object context)
        {
            var result = new BigInteger(Hex.Decode(Strings.ToAsciiByteArray(GetPropertyValueAsString(context))));

            return Hex.ToHexString(result.ToByteArray());
        }
    }

    public class TokenFactory
    {
        private static readonly IDictionary<string, Type> DefaultConstraintMap =
            new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase)
            {
                {"int", typeof (IntToken)},
                {"bool", typeof (BoolToken)},
                {"datetime", typeof (DateTimeToken)},
                {"decimal", typeof (DecimalToken)},
                {"double", typeof (DoubleToken)},
                {"float", typeof (FloatToken)},
                {"guid", typeof (GuidToken)},
                {"long", typeof (LongToken)},
                {"bigint", typeof (BigIntegerToken)},
                {"hexbigint", typeof (HexBigIntegerToken)}
            };


        public static IToken Create(string value)
        {
            return String.IsNullOrWhiteSpace(value) ? null : ParsePropertyConstraints(value);
        }

        private static IToken ParsePropertyConstraints(string value)
        {
            int constraintIndex = value.IndexOf(':');
            if (constraintIndex < 0)
            {
                return new StringToken(value);
            }
            if (constraintIndex == value.Length)
            {
                throw new InvalidOperationException("Constraint not found!");
            }

            string property = value.Substring(0, constraintIndex);
            if (String.IsNullOrEmpty(property))
            {
                throw new InvalidOperationException("Invalid empty property");
            }

            string constraint = value.Substring(constraintIndex + 1);

            if (DefaultConstraintMap.ContainsKey(constraint))
            {
                return ObjectFactory.Create<IToken>(DefaultConstraintMap[constraint], property);
            }

            throw new InvalidOperationException(String.Format("Unknown contraint '{0}'", constraint));
        }
    }
}
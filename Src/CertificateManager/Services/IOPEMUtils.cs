using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.X509;

namespace CertificateManager.Services
{
    public static class IOPEMUtils
    {
        public static ResultFileNames SaveCertificateAndPrivateKey(
            X509Certificate certificate,
            AsymmetricCipherKeyPair key,
            string fileName)
        {
            string folder = Path.GetDirectoryName(fileName);
            string fileWithouExtension = Path.GetFileNameWithoutExtension(fileName);
            string extension = Path.GetExtension(fileName);

            string privateKeyFile = String.Format("{0}_priv.pem", fileWithouExtension);
            string fileCertificate = String.Format("{0}{1}", fileWithouExtension, extension);

            var files = new ResultFileNames(Path.Combine(folder, fileCertificate), Path.Combine(folder, privateKeyFile));

            SavePemCertificate(certificate, files.Certificate);
            SavePemPrivateKeyToFile(key, files.PrivateKey);

            return files;
        }

        public static void SavePemPrivateKeyToFile(AsymmetricCipherKeyPair key, string fileName)
        {
            SavePemKeyToFile(key.Private, fileName);
        }

        public static AsymmetricCipherKeyPair PemKeyPairFrom(X509Certificate certificate, string privateKeyFile)
        {
            return new AsymmetricCipherKeyPair(
                certificate.GetPublicKey(),
                LoadPemPrivateKey(privateKeyFile).Private
                );
        }

        // Nota: a chave publica gerada pela privada.
        public static AsymmetricCipherKeyPair LoadPemPrivateKey(string inputFileName)
        {
            using (var reader = new StreamReader(inputFileName))
            {
                object key = new PemReader(reader).ReadObject();
                if ((key as AsymmetricCipherKeyPair) == null)
                {
                    throw new InvalidOperationException("Inavalid key file!");
                }

                return key as AsymmetricCipherKeyPair;
            }
        }

        public static AsymmetricCipherKeyPair PrivateKeyFromPem(string pem)
        {
            using (var reader = new StringReader(pem))
            {
                object key = new PemReader(reader).ReadObject();
                if ((key as AsymmetricCipherKeyPair) == null)
                {
                    throw new InvalidOperationException("Inavalid key file!");
                }

                return key as AsymmetricCipherKeyPair;
            }
        }

        public static void SavePemPublicKeyToFile(AsymmetricCipherKeyPair key, string fileName)
        {
            SavePemKeyToFile(key.Public, fileName);
        }

        private static void SavePemKeyToFile(AsymmetricKeyParameter keyParameter, string fileName)
        {
            // gravar chave (privada ou publica) em formato PEM
            // é da responsabilidade da classe 'MiscPemGenerator' saber como gerar PEM. Ver no código como.
            // a geração PEM para chave privada é diferente de uma chave pública
            using (var writer = new StreamWriter(fileName))
            {
                new PemWriter(writer).WriteObject(keyParameter);
            }
        }

        public static string PrivateKeyAsPem(AsymmetricCipherKeyPair key)
        {
            return SaveKeyAsPem(key.Private);
        }

        public static string PublicKeyAsPem(AsymmetricCipherKeyPair key)
        {
            return SaveKeyAsPem(key.Public);
        }

        private static string SaveKeyAsPem(AsymmetricKeyParameter keyParameter)
        {
            var pem = new StringBuilder();
            using (var writer = new StringWriter(pem))
            {
                new PemWriter(writer).WriteObject(keyParameter);
            }

            return pem.ToString();
        }

        public static void SavePemCertificate(X509Certificate certificate, string outputFileName)
        {
            using (var writer = new StreamWriter(outputFileName))
            {
                new PemWriter(writer).WriteObject(certificate);
            }
        }

        public static string CertificateAsPem(X509Certificate certificate)
        {
            var pem = new StringBuilder();
            using (var writer = new StringWriter(pem))
            {
                new PemWriter(writer).WriteObject(certificate);
            }

            return pem.ToString();
        }


        public static X509Certificate LoadPemCertificate(string inputFileName)
        {
            using (var reader = new StreamReader(inputFileName))
            {
                object certificate = new PemReader(reader).ReadObject();
                if ((certificate as X509Certificate) == null)
                {
                    throw new InvalidOperationException("Inavalid certificate!");
                }

                return certificate as X509Certificate;
            }
        }

        public static X509Certificate FromPemCertificate(string pemCertificate)
        {
            using (var reader = new StringReader(pemCertificate))
            {
                object certificate = new PemReader(reader).ReadObject();
                if ((certificate as X509Certificate) == null)
                {
                    throw new InvalidOperationException("Inavalid certificate!");
                }

                return certificate as X509Certificate;
            }
        }

        public static void SavePemCrl(X509Crl crl, string outputFileName)
        {
            using (var writer = new StreamWriter(outputFileName))
            {
                new PemWriter(writer).WriteObject(crl);
            }
        }

        public static X509Crl LoadPemCrl(string inputFileName)
        {
            using (var reader = new StreamReader(inputFileName))
            {
                object crl = new PemReader(reader).ReadObject();
                if ((crl as X509Crl) == null)
                {
                    throw new InvalidOperationException("Invalid crl!");
                }

                return crl as X509Crl;
            }
        }
    }

    public class ResultFileNames
    {
        public ResultFileNames(string certificate, string privateKey)
        {
            Certificate = certificate;
            PrivateKey = privateKey;
        }

        public string Certificate { get; private set; }
        public string PrivateKey { get; private set; }
    }
}
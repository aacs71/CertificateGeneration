using System;
using System.Collections;
using System.Collections.Generic;
using CertificateManager.Infrastructure;
using CertificateManager.Services;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Operators;

namespace CertificateManager.Views
{
    public interface ICertificateCreateView : IView
    {
        string[] Algoritms { set; }
        string DefaultAlgoritm { set; }
        string Algoritm { get; }

        int DefaultKeyLength { set; }
        int KeyLength { get; }

        int AvailableKeyUsage { set; }
        int DefaultKeyUsage { set; }
        KeyUsage KeyUsage { get; }

        KeyPurposeID[] AvailablePurpose { set; }
        KeyPurposeID[] DefaultPurpose { set; }
        KeyPurposeID[] Purpose { get; }

        string Subject { get; }
        DateTime From { get; set; }
        int Duration { get; }
    }

    public interface ICrlCreateView : IView
    {
        string[] Algoritms { set; }
        string DefaultAlgoritm { set; }
        string Algoritm { get; }

        DateTime From { get; set; }
        int DefaultNextUpdate { set; }
        int NextUpdate { get; }

        string CAFile { get; }
        string CAPrivateKeyFile { get; }
    }

    public abstract class CertificateCreatePresenter<TView> : Presenter<TView> where TView : ICertificateCreateView
    {
        private string[] GetAlgoritms()
        {
            var algorithms = new List<string>();

            IEnumerable signatures = Asn1SignatureFactory.SignatureAlgNames;
            foreach (object signature in signatures)
            {
                algorithms.Add(signature as string);
            }

            return algorithms.ToArray();
        }

        public override void OnViewReady()
        {
            View.Algoritms = GetAlgoritms();
            View.DefaultAlgoritm = Constants.DEFAULT_SIGNATURE_ALGORITHM;
            View.DefaultKeyLength = Constants.DEFAULT_KEY_LENGTH;
            View.From = DateTime.UtcNow;
        }
    }

    public abstract class CrlCreateCrlPresenter<TView> : Presenter<TView> where TView : ICrlCreateView
    {
        private string[] GetAlgoritms()
        {
            var algorithms = new List<string>();

            IEnumerable signatures = Asn1SignatureFactory.SignatureAlgNames;
            foreach (object signature in signatures)
            {
                algorithms.Add(signature as string);
            }

            return algorithms.ToArray();
        }

        public override void OnViewReady()
        {
            View.Algoritms = GetAlgoritms();
            View.DefaultAlgoritm = Constants.DEFAULT_SIGNATURE_ALGORITHM;
            View.DefaultNextUpdate = Constants.DEFAULT_CRL_NEXT_UPDATE_DAYS;
            View.From = DateTime.UtcNow;
        }
    }
}
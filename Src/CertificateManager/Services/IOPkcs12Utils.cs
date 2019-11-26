using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CertificateManager.Services
{
    public class IOPkcs12Utils
    {
        public static void SavePkcs12Certificate(X509Certificate2 certificate, string pkcs12Password,
            string outputFileName)
        {
            File.WriteAllBytes(outputFileName, ToPkcs12Certificate(certificate, pkcs12Password));
        }

        public static byte[] ToPkcs12Certificate(X509Certificate2 certificate, string pkcs12Password)
        {
            //  Uso de 'null' implica sem password.
            return certificate.Export(X509ContentType.Pkcs12, pkcs12Password);
        }

        public static X509Certificate2 LoadPkcs12Certificate(string issuerFileName, string pkcs12Password)
        {
            // Certificado .NET e neste caso será um PFX (Pcks12)
            // Nota: necessário passar 'Exportable'. Caso contrárionão se obtem a chave privada.
            return new X509Certificate2(issuerFileName, pkcs12Password, X509KeyStorageFlags.Exportable);
        }

        public static X509Certificate2 FromPkcs12Certificate(byte[] certificate, string pkcs12Password)
        {
            // Certificado .NET e neste caso será um PFX (Pcks12)
            // Nota: necessário passar 'Exportable'. Caso contrárionão se obtem a chave privada.
            return new X509Certificate2(certificate, pkcs12Password, X509KeyStorageFlags.Exportable);
        }
    }
}
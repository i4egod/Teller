using System.Security.Cryptography.X509Certificates;

namespace BlazorApp.Services
{
    public class SecureHttpClientHandler : HttpClientHandler
    {
        public SecureHttpClientHandler()
        {
            ClientCertificates.Add(new X509Certificate2(Path.GetDirectoryName(Environment.ProcessPath) + "\\certificate.pfx"));
        }
    }
}

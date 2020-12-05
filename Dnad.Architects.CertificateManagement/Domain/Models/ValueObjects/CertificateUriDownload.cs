namespace Dnad.Architects.CertificateManagement.Domain.Models.ValueObjects
{
    public class CertificateUriDownload
    {
        public string Uri { get; private set; }
        public long ExpiresOn { get; private set; }

        public CertificateUriDownload(string uri, long expiresOn)
        {
            Uri = uri;
            ExpiresOn = expiresOn;
        }
    }
}
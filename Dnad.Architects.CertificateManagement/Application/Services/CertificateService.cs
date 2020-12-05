using Dnad.Architects.Application.Ports.Mailers;
using Dnad.Architects.CertificateManagement.Application.Services.Interfaces;

namespace Dnad.Architects.CertificateManagement.Application.Services
{
    internal class CertificateService: ICertificateService
    {
        private IMailer Mailer { get; }        
        
        public CertificateService(IMailer mailer)
        {
            Mailer = mailer;
        }
    }
}

using Dnad.Architects.Application.Ports;
using Dnad.Architects.CertificateManagement.Application.Services.Interfaces;
using Dnad.Architects.MeetingManagement.Ports;

namespace Dnad.Architects.MeetingManagement.Acl
{
    public class ServicesFromCertificateManagement: IServicesFromCertificateManagement
    {
        public ServicesFromCertificateManagement(ICertificateService certificateService)
        {
            CertificateService = certificateService;
        }

        public ICertificateService CertificateService { get; private set; }
        
    }
}
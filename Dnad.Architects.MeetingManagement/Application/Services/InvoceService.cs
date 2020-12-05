using Dnad.Architects.Application.Ports.Database;
using Dnad.Architects.MeetingManagement.Application.Services.Interfaces;
using Dnad.Architects.MeetingManagement.Ports;

namespace Dnad.Architects.MeetingManagement.Application.Services
{
    public class InvoceService: IInvoiceService
    {
        private IDatabaseHolder Database { get; }
        private IServicesFromCertificateManagement CertificateService { get; }

        public InvoceService(IDatabaseHolder sqlServerHolder, IServicesFromCertificateManagement certificateService)
        {
            Database = sqlServerHolder;
            CertificateService = certificateService;
        }
    }
}

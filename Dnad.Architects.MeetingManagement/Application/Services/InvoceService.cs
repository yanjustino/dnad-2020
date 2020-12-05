using Dnad.Architects.Application.Ports.Database;
using Dnad.Architects.CertificateManagement.Application.Services.Interfaces;
using Dnad.Architects.MeetingManagement.Application.Services.Interfaces;

namespace Dnad.Architects.MeetingManagement.Application.Services
{
    public class InvoceService: IInvoiceService
    {
        private IDatabaseHolder Database { get; }
        private ICertificateService CertificateService { get; }

        public InvoceService(IDatabaseHolder sqlServerHolder, ICertificateService certificateService)
        {
            Database = sqlServerHolder;
            CertificateService = certificateService;
        }
    }
}

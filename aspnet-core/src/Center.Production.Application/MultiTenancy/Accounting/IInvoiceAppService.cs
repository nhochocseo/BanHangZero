using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Center.Production.MultiTenancy.Accounting.Dto;

namespace Center.Production.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}

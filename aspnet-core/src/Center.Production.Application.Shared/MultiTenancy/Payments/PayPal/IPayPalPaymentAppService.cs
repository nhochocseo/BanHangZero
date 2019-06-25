using System.Threading.Tasks;
using Abp.Application.Services;
using Center.Production.MultiTenancy.Payments.Dto;
using Center.Production.MultiTenancy.Payments.PayPal.Dto;

namespace Center.Production.MultiTenancy.Payments.PayPal
{
    public interface IPayPalPaymentAppService : IApplicationService
    {
        Task ConfirmPayment(long paymentId, string paypalPaymentId, string paypalPayerId);

        PayPalConfigurationDto GetConfiguration();

        Task CancelPayment(CancelPaymentDto input);
    }
}

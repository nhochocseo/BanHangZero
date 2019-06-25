using Abp.AutoMapper;
using Center.Production.Editions;
using Center.Production.MultiTenancy.Payments.Dto;

namespace Center.Production.Web.Areas.AppAreaName.Models.SubscriptionManagement
{
    [AutoMapTo(typeof(ExecutePaymentDto))]
    public class PaymentResultViewModel : SubscriptionPaymentDto
    {
        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
using System.Collections.Generic;
using Center.Production.Editions;
using Center.Production.Editions.Dto;
using Center.Production.MultiTenancy.Payments;
using Center.Production.MultiTenancy.Payments.Dto;

namespace Center.Production.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}

using System.Collections.Generic;
using Center.Production.Editions.Dto;
using Center.Production.MultiTenancy.Payments;

namespace Center.Production.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
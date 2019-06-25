using Center.Production.Editions;
using Center.Production.Editions.Dto;
using Center.Production.MultiTenancy.Payments;
using Center.Production.Security;
using Center.Production.MultiTenancy.Payments.Dto;

namespace Center.Production.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}

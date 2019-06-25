using Abp.Domain.Services;

namespace Center.Production
{
    public abstract class ProductionDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected ProductionDomainServiceBase()
        {
            LocalizationSourceName = ProductionConsts.LocalizationSourceName;
        }
    }
}

using System.Threading.Tasks;
using Abp.Dependency;

namespace Center.Production.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}
using Microsoft.Extensions.Configuration;

namespace Center.Production.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}

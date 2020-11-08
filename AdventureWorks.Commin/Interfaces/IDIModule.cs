using Microsoft.Extensions.DependencyInjection;

namespace AdventureWorks.Common.Interfaces
{
    public interface IDIModule
    {
        void RegisterServices(IServiceCollection services);
    }
}
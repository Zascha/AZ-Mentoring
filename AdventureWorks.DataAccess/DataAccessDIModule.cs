using AdventureWorks.Common.Interfaces;
using AdventureWorks.Data.Models;
using AdventureWorks.DataAccess.Interfaces;
using AdventureWorks.DataAccess.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace AdventureWorks.DataAccess
{
    public class DataAccessDIModule : IDIModule
    {
        public void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IQuery<Product>, ProductsQuery>();
        }
    }
}
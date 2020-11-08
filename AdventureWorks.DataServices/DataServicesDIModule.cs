using AdventureWorks.Common.Interfaces;
using AdventureWorks.Data.Models;
using AdventureWorks.DataServices.Interfaces;
using AdventureWorks.DataServices.Mappers;
using AdventureWorks.DataServices.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AdventureWorks.DataServices
{
    public class DataServicesDIModule : IDIModule
    {
        public void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IApiService<Product>, ProductsService>();
            services.AddTransient<ToResponseModelsMapper>();
        }
    }
}
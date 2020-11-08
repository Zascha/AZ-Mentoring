using System;
using System.IO;
using AdventureWorks.Common;
using AdventureWorks.Data;
using AdventureWorks.DataAccess;
using AdventureWorks.DataServices;
using EFCore.DbContextFactory.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Serilog;
using Swashbuckle.AspNetCore.Filters;

namespace AdventureWorks.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            loggerFactory.AddSerilog();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Adventure Works API");
            });
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContextFactory<DataContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString(DataConsts.SqlDbConnectionString), builder => builder.CommandTimeout(60).EnableRetryOnFailure()));

            var logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .CreateLogger();

            services.AddSingleton<Serilog.ILogger>(logger);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Adventure Works. Products API",
                    Version = "v1"
                });

                var xmlFile = Path.ChangeExtension(typeof(Startup).Assembly.Location, ".xml");
                var xmlFileCommon = Path.Combine(AppContext.BaseDirectory, "AdventureWorks.CommonData.xml");

                c.IncludeXmlComments(xmlFile);
                c.IncludeXmlComments(xmlFileCommon);

                c.DescribeAllParametersInCamelCase();
            });

            new DataAccessDIModule().RegisterServices(services);
            new DataServicesDIModule().RegisterServices(services);
        }
    }
}

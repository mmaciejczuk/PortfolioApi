using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication.Infrastructure.Mappers;
using WebApplication.Infrastructure.Services;
using WebApplication.Infrastructure.Context;
using Newtonsoft.Json;
using WebApplication.Infrastructure.Repositories;
using WebApplication.Core.Repositories;

namespace WebApplication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                .AddJsonOptions(options => {
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                });
            services.AddMemoryCache();
            var dbConnectionString = @"Data Source=DESKTOP-RNNQ0D4;Initial Catalog=WebApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(dbConnectionString));
            services.AddScoped<IPortfolioService, PortfolioService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IPortfolioRepository, PortfolioRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddSingleton<IMapper>(AutoMapperConfig.Initialize());
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

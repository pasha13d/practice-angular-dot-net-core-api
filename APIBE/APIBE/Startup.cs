using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBE.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace APIBE
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.PropertyNamingPolicy = null;
                options.JsonSerializerOptions.DictionaryKeyPolicy = null;
            });
            services.AddCors();
            services.AddDbContext<PaymentDetailContext>(optionns =>
                                                        optionns.UseSqlServer(Configuration.GetConnectionString("PayDbConnection")));

            services.AddDbContext<LoginContext>(optionns =>
                                                optionns.UseSqlServer(Configuration.GetConnectionString("PayDbConnection")));

            services.AddDbContext<DatabaseContext>(optionns =>
                                                   optionns.UseSqlServer(Configuration.GetConnectionString("PayDbConnection")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(options =>
                        options.WithOrigins("http://localhost:4200")
                        .AllowAnyMethod()
                       .AllowAnyHeader());

                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapControllers();
                        });
        }
    }
}

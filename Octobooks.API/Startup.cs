using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Octobooks.Domain.Models;
using Octobooks.Repository;
using Octobooks.Business;
using Octobooks.Repository.Base;
using Octobooks.Repository.Interfaces;
using Octobooks.Services;
using Octobooks.Services.Interfaces;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;
using Octobooks.Business.Interfaces;

namespace Octobooks.API
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
            DependencyInjection(services);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Openbook",
                        Version = "v1",
                        Description = "Openbook",
                        Contact = new Contact
                        {
                            Name = "Only R - Only Research",
                            Url = "https://github.com/onlyresearch"
                        }
                    });

                var caminhoAplicacao =
                    PlatformServices.Default.Application.ApplicationBasePath;
                var nomeAplicacao =
                    PlatformServices.Default.Application.ApplicationName;
                var caminhoXmlDoc =
                    Path.Combine(caminhoAplicacao, $"{nomeAplicacao}.xml");

                c.IncludeXmlComments(caminhoXmlDoc);
            });


        }
        public void DependencyInjection(IServiceCollection services)
        {
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IClientServices, ClientServices>();
            services.AddTransient<IClientBusiness, ClientBusiness>();

            services.AddSingleton<IBookRepository, BookRepository>();
            services.AddTransient<IBookServices, BookServices>();
            services.AddTransient<IBookBusiness, BookBusiness>();

            services.AddSingleton<ILoanRepository, LoanRepository>();
            services.AddTransient<ILoanServices, LoanServices>();
            services.AddTransient<ILoanBusiness, LoanBusiness>();
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
            app.UseCors(c =>
            {
                c.AllowAnyHeader();
                c.AllowAnyMethod();
                c.AllowAnyOrigin();
            });
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json","Octobook");
            });


           

        }
    }
}

using Livraria.Domain.Interfaces.UoW;
using Livraria.Infra.DI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Livraria.Api
{
    public class Startup
    {
        private const string STRINGCONNECTION = "DefaultConnection";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            Bootstrap.Configuracao(services, Configuration.GetConnectionString(STRINGCONNECTION));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddCors();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(builder =>
            builder.WithOrigins("*")
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());

            app.Use(async (context, next) =>
            {
                await next.Invoke();
                var unitOfWork = (IUnitOfWork)context.RequestServices.GetService(typeof(IUnitOfWork));
                await unitOfWork.Commit();

            });

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

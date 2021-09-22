using Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PROJUR.Aplicacao.AutoMapeamento;
using PROJUR.Infra.CrossCutting.IoC;
using PROJUR.Infra.Data;

namespace PROJUR.API
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
            var connectionSql = Configuration["SqlConnection:SqlConnectionString"];
            services.AddDbContext<Contexto>(op => op.UseSqlServer(connectionSql));
            services.AddCors(o => o.AddPolicy("DefaultPolicy",
                    builder => builder
                    .AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .SetIsOriginAllowed((host) => true)
                ));
            services.AddControllers();
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("VersaoTeste", new OpenApiInfo
                {
                    Title = "TesteTecnico",
                    Version = "VersaoTeste"
                });
            });
            services.AddAutoMapper(typeof(AutoMapeamentoConfig));
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new InjecaoDeDependenciaModulo());
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(x => {
                x.SwaggerEndpoint("/swagger/VersaoTeste/swagger.json", "TesteTecnico");
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("DefaultPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Serilog;
using Sirius.MS.DAL.Repositories;
using Sirius.MS.Service.Mappings;

namespace Sirius.MS.Service
{
    public class Startup
    {
        private readonly Microsoft.Extensions.Logging.ILogger _logger;

        public Startup(IConfiguration configuration, ILoggerFactory logFactory)
        {
            _logger = logFactory.CreateLogger<Startup>();
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Auto Mapper Configurations
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mappingConfig.CreateMapper();

            _logger.LogInformation("Auto Mapper Configurations Added to Services!");

            services.AddSingleton(mapper);

            services.AddRazorPages();
            services.AddMvcCore().AddApiExplorer();
            services.AddControllers();

            //Configure Swagger
            services.AddSwaggerGen(c => { //<-- NOTE 'Add' instead of 'Configure'
                c.SwaggerDoc("V2", new OpenApiInfo
                {
                    Title = "Sirius.MS.Service",
                    Description = "VBooks Core API3 - with swagger",
                    Version = "1.0.5"
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            //Assign DB Connection string from Environment Variable.
            VbooksDBConfig.VBooksDBConnectionString = Environment.GetEnvironmentVariable("DBConnectionString");

            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json")
                .Build();


            Log.Logger = new LoggerConfiguration()
                       .ReadFrom.Configuration(configuration)
                       .CreateLogger();
            // logging
            loggerFactory.AddSerilog();

            if (env.IsDevelopment())
            {
                _logger.LogInformation("In Development environment");
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseSerilogRequestLogging();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            }
            );

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/V2/swagger.json", "Sirius.MS.Service");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}

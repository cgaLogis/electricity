using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Electricity.CORE.Services;
using Electricity.DAL.Core;
using Electricity.DAL.Core.Repositories;
using Electricity.DAL.Entity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace Electricity.WebService
{
    public class Startup
    {
        public Startup( IConfiguration configuration )
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices( IServiceCollection services )
        {
            //services.AddMvc().SetCompatibilityVersion( CompatibilityVersion.Version_2_1 );
            services.AddMvc().SetCompatibilityVersion( CompatibilityVersion.Version_2_1 );

            services.AddDbContext<DataContext>( options => {
                options.UseSqlServer( Configuration.GetConnectionString( "MyConnection" ) );
            } );


            services.AddSwaggerGen( c =>
            {
                c.SwaggerDoc( "v1", new OpenApiInfo { Title = "Electricity API", Version = "v1" } );


                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

                var xmlPath = Path.Combine( AppContext.BaseDirectory, xmlFile );
                c.IncludeXmlComments( xmlPath, includeControllerXmlComments: true );
            } );


            services.AddScoped<IDataService, DataService>();
            //repos

            //services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped( typeof( IRepository<> ), typeof( Repository<> ) );
            //services.AddTransient<IRepository<Organization>, Repository<Organization>>();
            //services.AddTransient<IRepository<ChildOrganization>, Repository<ChildOrganization>>();
            //services.AddTransient<IRepository<ConsumptionObject>, Repository<ConsumptionObject>>();
            //services.AddTransient<IRepository<DeliveryPoint>, Repository<DeliveryPoint>>();
            //services.AddTransient<IRepository<DeliveryPointMeter>, Repository<DeliveryPointMeter>>();
            //services.AddTransient<IRepository<ElectricityPoint>, Repository<ElectricityPoint>>();
            //services.AddTransient<IRepository<ElectricityMeter>, Repository<ElectricityMeter>>();
            //services.AddTransient<IRepository<ElectricityTransformator>, Repository<ElectricityTransformator>>();
            //services.AddTransient<IRepository<VoltageTransformator>, Repository<VoltageTransformator>>();
            services.AddAutoMapper( typeof( Startup ) );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure( IApplicationBuilder app, IHostingEnvironment env )
        {
            if ( env.IsDevelopment() )
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            app.UseSwagger( opts => {
            } );

            app.UseSwaggerUI( opts =>
            {
                opts.SwaggerEndpoint( "/swagger/v1/swagger.json", "Electricity" );
            } );


        }
    }
}

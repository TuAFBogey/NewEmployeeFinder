using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using NewEmployeeFinder.API.AuthService;
using NewEmployeeFinder.API.Filters;
using NewEmployeeFinder.API.IAuthService;
using NewEmployeeFinder.Core.Services;
using NewEmployeeFinder.Core.UnitOfWorks;
using NewEmployeeFinder.Data;
using NewEmployeeFinder.Data.Repositories;
using NewEmployeeFinder.Data.UnitOfWorks;
using NewEmployeeFinder.Entities.Repositories;
using NewEmployeeFinder.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewEmployeeFinder.API
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
            services.AddAutoMapper(typeof(Startup));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IService<>), typeof(Service.Services.Service<>));
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddScoped<IAuthSrvc, AuthSrvc>();
            services.AddVersionedApiExplorer(c =>
            {
                c.GroupNameFormat = "'v'VVV";
                c.SubstituteApiVersionInUrl = true;
                c.AssumeDefaultVersionWhenUnspecified = true;
                c.DefaultApiVersion = new ApiVersion(1, 0);
            });

            services.AddApiVersioning(c =>
            {
                c.ReportApiVersions = true;
                c.AssumeDefaultVersionWhenUnspecified = true;
                c.DefaultApiVersion = new ApiVersion(1, 0);
            });

            services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "NewEmployeeFinder",
                    Version = "v1",
                    Description = "TuAF-Bogey"
                });

                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
                    Scheme = "basic",
                    In=Microsoft.OpenApi.Models.ParameterLocation.Header,
                    Description="Basic Auth Header"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                    new OpenApiSecurityScheme
                    {
                        Reference=new OpenApiReference
                        {
                            Type=ReferenceType.SecurityScheme,
                            Id="basic"
                        }
                    },
                    new string[]{}
                    }
                });
            });

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
            services.AddRouting();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:SqlConStr"].ToString(), o =>
                {
                    o.MigrationsAssembly("NewEmployeeFinder.Data");
                });
            });

            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = (doc =>
                {
                    doc.Info.Title = "New Employee Finder API";
                    doc.Info.Version = "1.0";
                    doc.Info.Contact = new NSwag.OpenApiContact()
                    {
                        Name = "Hayrullah Uğur Güvenen",
                        Url = "https://www.linkedin.com/in/guvenenugur/",
                        Email = "uguvenen@gmail.com"
                    };
                });
            });


            services.AddControllers();
            services.AddRazorPages();
            

            services.AddScoped<NotFoundFilter>();

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });
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

            app.UseAuthentication();
            app.UseAuthorization();
            

            app.UseOpenApi();

            app.UseSwaggerUi3();
            ///app.UseSwaggerUI(c=>
            ///{
            ///    c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestService");
            ///});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

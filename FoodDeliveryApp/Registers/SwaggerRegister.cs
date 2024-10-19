using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Models;

namespace FoodDeliveryApp.Registers
{
    public static class SwaggerRegister
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddApiVersioning(p =>
            {
                p.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
                p.AssumeDefaultVersionWhenUnspecified = true;
                p.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(p =>
            {
                p.GroupNameFormat = "'v'VVV";
                p.SubstituteApiVersionInUrl = true;
            });

            using var sp = services.BuildServiceProvider();
            var apiVersionProvider = sp.GetService<IApiVersionDescriptionProvider>();

            services.AddSwaggerGen(options =>
            {
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                foreach (var description in apiVersionProvider.ApiVersionDescriptions)
                {
                    options.SwaggerDoc(
                        description.GroupName,
                        new OpenApiInfo
                        {
                            Title = "FoodDeliveryAPp",
                            Version = description.GroupName,
                            Description = "",
                            Contact = new OpenApiContact
                            {
                                Name = "Maciej Jaskolski",
                                Url = new Uri("https://github.com/maciejjaskolskiportfolio/musicapp")
                            }
                        });
                }

                options.IncludeXmlComments(xmlPath);
            });
        }

        public static void ConfigureSwagger(this IApplicationBuilder app, IApiVersionDescriptionProvider apiVersionProvider)
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                foreach (var description in apiVersionProvider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        description.GroupName);
                }
            });
        }
    }
}

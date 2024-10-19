using FoodDeliveryApp.Registers;
using Infra;

namespace FoodDeliveryApp
{
    public class Startup
    {
        private IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            // services.AddMvcCore().AddApiExplorer();
            services.AddControllers();
            services.AddSwaggerGen();
            services.AddDomain();
            services.AddInfra(Configuration);
            //services.AddAutoMapper(typeof(BandMapper));
            //services.AddAutoMapper(typeof(AlbumMapper));
            //services.AddAutoMapper(typeof(TourMapper));
            //services.AddAutoMapper(typeof(ConcertMapper));
            //services.AddAutoMapper(typeof(SongMapper));
            //services.AddAutoMapper(typeof(SongMetadataMapper));
            //services.AddAutoMapper(typeof(AlbumMetadataMapper));
            //services.AddAutoMapper(typeof(NotificationMapper));
            services.AddCors(opt =>
            {
                opt.AddPolicy("FoodApiCORS", builder =>
                {
                    builder
                    .WithOrigins("https://localhost:58014", "https://localhost:3000")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();
                });
            });

            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //})
            //    .AddJwtBearer(options =>
            //    {
            //        options.SaveToken = true;
            //        options.RequireHttpsMetadata = false;
            //        options.TokenValidationParameters = new TokenValidationParameters()
            //        {
            //            ValidateIssuer = false,
            //            ValidateAudience = false,
            //            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
            //        };
            //    });
            services.AddMvc();
        }
        //, IApiVersionDescriptionProvider provider
        public void Configure(IApplicationBuilder app)
        {
            app.ConfigureInfra();
            //app.RunSchedulerFactory();
            app.UseSwagger();
            app.UseSwaggerUI();
            //app.ConfigureSwagger(provider);
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHttpsRedirection();
            app.UseDeveloperExceptionPage();
            app.UseCors("FoodApiCORS");
        }
    }
}

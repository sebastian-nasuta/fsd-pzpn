using Fsd.Pzpn.Crew.Api.Services;
using Fsd.Pzpn.Crew.Services.Clubs;
using Fsd.Pzpn.Crew.Services.Players;
using Fsd.Pzpn.Crew.Services.Temp;
using Fsd.Pzpn.Ef;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Fsd.Pzpn.WebApi
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
            services.AddDbContext<PzpnDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PzpnDatabase")));

            services.AddMvc();

            services.AddTransient<IValuesService, ValuesService>();
            services.AddTransient<IPlayersService, PlayersService>();
            services.AddTransient<IClubsService, ClubsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}

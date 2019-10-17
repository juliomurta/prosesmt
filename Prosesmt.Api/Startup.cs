using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Prosesmt.Api.Models;
using Prosesmt.Api.Repository;
using ZNetCS.AspNetCore.Authentication.Basic;
using ZNetCS.AspNetCore.Authentication.Basic.Events;
using System.Security.Claims;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using System.Threading.Tasks;

namespace Prosesmt.Api
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
            var connection = Configuration["ConexaoSqlite:SqliteConnectionString"];
            services.AddDbContext<ProsesmtContext>(options =>
                options.UseSqlite(connection)
            );

            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IChamadoRepository, ChamadoRepository>();

            services.AddAuthentication(BasicAuthenticationDefaults.AuthenticationScheme)
                    .AddBasicAuthentication(options => {
                        options.Realm = "Prosesmt";
                        options.Events = new BasicAuthenticationEvents
                        {
                            OnValidatePrincipal = context =>
                            {
                                if ((context.UserName.ToLower() == "julio") && (context.Password.ToLower() == "123456"))
                                {
                                    var claims = new List<Claim>
                                    {
                                        new Claim(ClaimTypes.Name, context.UserName, context.Options.ClaimsIssuer)
                                    };

                                    var ticket = new AuthenticationTicket(new ClaimsPrincipal(new ClaimsIdentity(claims, BasicAuthenticationDefaults.AuthenticationScheme)),
                                                                          new AuthenticationProperties(), 
                                                                          BasicAuthenticationDefaults.AuthenticationScheme);

                                    return Task.FromResult(AuthenticateResult.Success(ticket));
                                }

                                return Task.FromResult(AuthenticateResult.Fail("Authentication Fail"));
                            }
                        };
                    });


            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new Microsoft.AspNetCore.Mvc.Cors.Internal.CorsAuthorizationFilterFactory("AllowMyOrigin"));
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
          
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseMvc();

            SeedData.Seed(app);
        }
    }
}

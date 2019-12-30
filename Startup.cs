using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQL;

[assembly: OwinStartup(typeof(FrameworkConsoleApp.Startup))]

namespace FrameworkConsoleApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2)
                .AddWebApiConventions();
            services.AddScoped<PlayerRepository>();
            services.AddScoped<PlayerSchema>();

            services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddGraphQL().AddGraphTypes(ServiceLifetime.Scoped);
            services.AddCors();
        }
        public void Configure(IApplicationBuilder app)
        {
            app.UseCors(builder =>
              builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            app.UseGraphQL<PlayerSchema>();
            //app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
            /*
            app.UseMvc(routes => routes.MapWebApiRoute("DefaultApi", "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }));
                */
        }
    }
}

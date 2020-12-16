using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace saastemplate.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<saastemplateWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}

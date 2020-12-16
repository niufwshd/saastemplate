using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace saastemplate
{
    public class saastemplateWebTestStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<saastemplateWebTestModule>();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.InitializeApplication();
        }
    }
}
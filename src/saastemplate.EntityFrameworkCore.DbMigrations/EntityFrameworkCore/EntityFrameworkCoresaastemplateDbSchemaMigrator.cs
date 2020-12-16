using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using saastemplate.Data;
using Volo.Abp.DependencyInjection;

namespace saastemplate.EntityFrameworkCore
{
    public class EntityFrameworkCoresaastemplateDbSchemaMigrator
        : IsaastemplateDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoresaastemplateDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the saastemplateMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<saastemplateMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
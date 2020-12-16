using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace saastemplate.Data
{
    /* This is used if database provider does't define
     * IsaastemplateDbSchemaMigrator implementation.
     */
    public class NullsaastemplateDbSchemaMigrator : IsaastemplateDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
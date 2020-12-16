using System.Threading.Tasks;

namespace saastemplate.Data
{
    public interface IsaastemplateDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}

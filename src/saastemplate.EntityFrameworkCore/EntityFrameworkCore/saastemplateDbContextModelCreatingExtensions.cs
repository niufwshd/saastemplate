using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace saastemplate.EntityFrameworkCore
{
    public static class saastemplateDbContextModelCreatingExtensions
    {
        public static void Configuresaastemplate(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(saastemplateConsts.DbTablePrefix + "YourEntities", saastemplateConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}
using Acme.Cvtheque.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.Cvtheque.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(CvthequeEntityFrameworkCoreModule),
    typeof(CvthequeApplicationContractsModule)
    )]
public class CvthequeDbMigratorModule : AbpModule
{

}

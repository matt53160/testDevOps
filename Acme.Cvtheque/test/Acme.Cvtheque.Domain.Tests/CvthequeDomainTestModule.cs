using Acme.Cvtheque.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Cvtheque;

[DependsOn(
    typeof(CvthequeEntityFrameworkCoreTestModule)
    )]
public class CvthequeDomainTestModule : AbpModule
{

}

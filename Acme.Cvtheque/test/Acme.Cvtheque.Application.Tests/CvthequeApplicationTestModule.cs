using Volo.Abp.Modularity;

namespace Acme.Cvtheque;

[DependsOn(
    typeof(CvthequeApplicationModule),
    typeof(CvthequeDomainTestModule)
    )]
public class CvthequeApplicationTestModule : AbpModule
{

}

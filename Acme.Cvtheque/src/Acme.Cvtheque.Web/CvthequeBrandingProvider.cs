using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.Cvtheque.Web;

[Dependency(ReplaceServices = true)]
public class CvthequeBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Cvtheque";
}

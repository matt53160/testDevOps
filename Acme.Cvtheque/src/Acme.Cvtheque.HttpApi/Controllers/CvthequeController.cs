using Acme.Cvtheque.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.Cvtheque.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class CvthequeController : AbpControllerBase
{
    protected CvthequeController()
    {
        LocalizationResource = typeof(CvthequeResource);
    }
}

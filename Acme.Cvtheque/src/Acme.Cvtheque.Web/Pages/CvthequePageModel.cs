using Acme.Cvtheque.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.Cvtheque.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class CvthequePageModel : AbpPageModel
{
    protected CvthequePageModel()
    {
        LocalizationResourceType = typeof(CvthequeResource);
    }
}

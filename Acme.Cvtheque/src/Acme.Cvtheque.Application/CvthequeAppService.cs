using System;
using System.Collections.Generic;
using System.Text;
using Acme.Cvtheque.Localization;
using Volo.Abp.Application.Services;

namespace Acme.Cvtheque;

/* Inherit your application services from this class.
 */
public abstract class CvthequeAppService : ApplicationService
{
    protected CvthequeAppService()
    {
        LocalizationResource = typeof(CvthequeResource);
    }
}

using Abp.Web.Mvc.Controllers;

namespace Quorse.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class QuorseControllerBase : AbpController
    {
        protected QuorseControllerBase()
        {
            LocalizationSourceName = QuorseConsts.LocalizationSourceName;
        }
    }
}
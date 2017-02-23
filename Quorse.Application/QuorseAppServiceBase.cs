using Abp.Application.Services;

namespace Quorse
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class QuorseAppServiceBase : ApplicationService
    {
        protected QuorseAppServiceBase()
        {
            LocalizationSourceName = QuorseConsts.LocalizationSourceName;
        }
    }
}
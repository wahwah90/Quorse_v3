using Abp.Web.Mvc.Views;

namespace Quorse.Web.Views
{
    public abstract class QuorseWebViewPageBase : QuorseWebViewPageBase<dynamic>
    {

    }

    public abstract class QuorseWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected QuorseWebViewPageBase()
        {
            LocalizationSourceName = QuorseConsts.LocalizationSourceName;
        }
    }
}
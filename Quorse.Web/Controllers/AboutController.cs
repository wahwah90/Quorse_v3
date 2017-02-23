using System.Web.Mvc;

namespace Quorse.Web.Controllers
{
    public class AboutController : QuorseControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
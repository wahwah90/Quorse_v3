using System.Web.Mvc;

namespace Quorse.Web.Controllers
{
    public class HomeController : QuorseControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
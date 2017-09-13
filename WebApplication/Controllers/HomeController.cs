using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult DashboardV1()
        {
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }
    }
}
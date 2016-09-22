using System.Web.Mvc;

namespace PersonalBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "PostPreviews", new { pageIndex = 1 });
        }

    }
}

using System.Web.Mvc;
using PersonalBlog.DAL.DALs;

namespace PersonalBlog.Controllers
{
    public class PostPreviewsController : Controller
    {
        public ActionResult Index()
        {
			return View(PostDal.GetList(1, 10));
        }

    }
}

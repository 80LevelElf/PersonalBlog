using System.Web.Mvc;
using PersonalBlog.DAL.DALs;

namespace PersonalBlog.Controllers
{
    public class PostPreviewsController : Controller
    {
        public ActionResult Index()
        {
			return View(PostPreviewDal.GetList(1, 10));
        }

    }
}

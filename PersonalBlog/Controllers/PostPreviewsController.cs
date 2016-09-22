using System.Web.Mvc;
using PersonalBlog.DAL.DALs;

namespace PersonalBlog.Controllers
{
    public class PostPreviewsController : Controller
    {
        public ActionResult Index(int pageIndex)
        {
			return View(PostDal.GetList(pageIndex));
        }

    }
}

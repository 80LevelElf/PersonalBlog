using System.Web.Mvc;
using PersonalBlog.DAL.DALs;
using PersonalBlog.DAL.MockDAL;

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

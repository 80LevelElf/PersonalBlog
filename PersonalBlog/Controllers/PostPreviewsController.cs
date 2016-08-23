using System.Web.Mvc;
using PersonalBlog.DAL.MockDAL;

namespace PersonalBlog.Controllers
{
    public class PostPreviewsController : Controller
    {
        public ActionResult Index()
        {
			return View(PostPreviewMockDal.GetList(1, 10));
        }

    }
}

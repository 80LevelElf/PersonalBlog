using System.Web.Mvc;
using PersonalBlog.DAL.DALs;

namespace PersonalBlog.Controllers
{
    public class AdminController : Controller
    {
		[Authorize(Roles = "admin")]
		public ActionResult Index()
        {
            return View(PostBaseDal.GetList(1, 10));
        }

        [Authorize(Roles = "admin")]
        public ActionResult AddNewPost()
        {
            return View();
        }
    }
}

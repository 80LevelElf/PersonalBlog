using System.Web.Mvc;
using PersonalBlog.DAL.DALs;
using PersonalBlog.Models;

namespace PersonalBlog.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
		public ActionResult Index()
        {
            return View(PostBaseDal.GetList(1, 10));
        }

        public ActionResult Add()
        {
            return View("AddOrUpdatePost", new AddOrUpdatePostModel
            {
                PostId = null,
                Source = string.Empty
            });
        }

        [HttpPost]
        public JsonResult AddOrUpdate(AddOrUpdatePostModel model)
        {
            return new JsonResult();
        }
    }
}

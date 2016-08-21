using System.Collections.Generic;
using System.Web.Mvc;
using PersonalBlog.DAL.DALs;
using PersonalBlog.Entities;

namespace PersonalBlog.Controllers
{
    public class PostPreviewsController : Controller
    {
        public ActionResult Index()
        {
			return View(new List<PostPreviewDto>());
        }

    }
}

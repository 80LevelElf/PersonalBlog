using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalBlog.Controllers
{
    public class MyProjectsController : Controller
    {
        //
        // GET: /MyProject/

        public ActionResult Index()
        {
            return View();
        }

    }
}

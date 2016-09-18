using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalBlog.Controllers
{
    public class ElementController : Controller
    {
        public PartialViewResult Pager(string action, string controller, int currentPageIndex)
        {
            ViewBag.CurrentPageIndex = currentPageIndex;

            return PartialView();
        }

    }
}

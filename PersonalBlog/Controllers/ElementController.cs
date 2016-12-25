using System.Web.Mvc;
using PersonalBlog.Models;

namespace PersonalBlog.Controllers
{
    public class ElementController : Controller
    {
        public PartialViewResult Pager(string action, string controller, int currentPageIndex, int pageCount)
        {
            ViewBag.CurrentPageIndex = currentPageIndex;

            return PartialView(new PagerModel()
            {
	            Action = action,
				Controller = controller,
				CurrentPageIndex = currentPageIndex,
				PageCount = pageCount
            });
        }
    }
}

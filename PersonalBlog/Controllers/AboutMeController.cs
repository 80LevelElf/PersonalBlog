using System;
using System.Web.Mvc;
using NodaTime;

namespace PersonalBlog.Controllers
{
    public class AboutMeController : Controller
    {
        //
        // GET: /AboutMe/

        public ActionResult Index()
        {
            ViewBag.AgeInYears = (int)Period.Between(
                new LocalDateTime(1995, 4, 29, 0, 0),
                LocalDateTime.FromDateTime(DateTime.Now)).Years;

            return View();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using PersonalBlog.Models;
using WebMatrix.WebData;

namespace PersonalBlog.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var isSuccess = WebSecurity.Login(model.UserName, model.Password, model.RememberMe);

            if (isSuccess)
                return Redirect(returnUrl);
            else
            {
                ModelState.AddModelError("", "Wrong login/password");
                return View(model);
            }
        }

    }
}

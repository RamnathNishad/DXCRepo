using MVCCodeFirstEFCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVCCodeFirstEFCrud.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        [HttpGet]
        public ActionResult Login(string ReturnUrl)
        {
            Session.Add("returnUrl", ReturnUrl);
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserDetails user)
        {
            if(user.Username=="admin" && user.Password=="abc")
            {
                var url = Session["returnUrl"].ToString();
                FormsAuthentication.SetAuthCookie(user.Username, false);
                return Redirect(url);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Customer");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;
using System.Web.Security;
namespace Proje.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: Login
        THEATEREntities db = new THEATEREntities();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(BAdmin p)
        {
            var info = db.BAdmin.FirstOrDefault(x => x.Auser == p.Auser && x.Password == p.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.Auser, false);
                Session["Auser"] = info.Auser.ToString();
             
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

    }
}
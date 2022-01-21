using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;
using System.Web.Security;
namespace Proje.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        THEATEREntities db = new THEATEREntities();
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(TBMembers p)
        {
            var info = db.TBMembers.FirstOrDefault(x => x.Mail == p.Mail && x.Password == p.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.Mail, false);
                Session["Mail"] = info.Mail.ToString();
              
                return RedirectToAction("Index", "Panels");
            }
            else
            {
                return View();
            }
        }

    }
}
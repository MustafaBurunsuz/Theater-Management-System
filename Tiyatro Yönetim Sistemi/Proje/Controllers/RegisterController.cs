using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;
namespace Proje.Controllers
{
    public class RegisterController : Controller
    {
        // GET: KayitOl
        THEATEREntities db = new THEATEREntities();
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(TBMembers p)
        {
            if (!ModelState.IsValid)
            {
                return View("Register");
            }
            db.TBMembers.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}
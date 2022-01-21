using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Proje.Models.Entity;
namespace Proje.Controllers
{
    public class PanelsController : Controller
    {
        // GET: Panelim

        THEATEREntities db = new THEATEREntities();
        [Authorize]

        [HttpGet]
        public ActionResult Index()
        {
            var uyemail = (string)Session["Mail"];
            var degerler = db.TBMembers.FirstOrDefault(z => z.Mail == uyemail);
            return View(degerler);
        }
        [HttpPost]
        public ActionResult Index2(TBMembers p)
        {
            var kullanici = (string)Session["Mail"];
            var uye = db.TBMembers.FirstOrDefault(x => x.Mail == kullanici);
            uye.Password = p.Password;
            uye.Name = p.Name;
            uye.Surname = p.Surname;
            uye.Photo = p.Photo;
            uye.PhoneNumber = p.PhoneNumber;
            
            uye.Username = p.Username;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult MyShows()
        {
            var kullanici = (string)Session["Mail"];
            var id = db.TBMembers.Where(x => x.Mail == kullanici.ToString()).Select(z => z.ID).FirstOrDefault();
            var degerler = db.TBActivity.Where(x => x.Member == id).ToList();
            return View(degerler);
        }

        public ActionResult Announcement()
        {
            var Announc = db.TBAnnouncement.ToList();
            return View(Announc);
        }



        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Login");
        }



    }
}
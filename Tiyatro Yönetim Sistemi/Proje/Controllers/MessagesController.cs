using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;
namespace Proje.Controllers
{
    public class MessagesController : Controller
    {
        // GET: Mesajlar

        THEATEREntities db = new THEATEREntities();
        public ActionResult Index()
        {
            var uyemail = (string)Session["Mail"].ToString();
            var mesajlar = db.TBMessage.Where(x => x.Receiver == uyemail.ToString()).ToList(); ;
            return View(mesajlar);
        }

        public ActionResult To()
        {
            var uyemail = (string)Session["Mail"].ToString();
            var mesajlar = db.TBMessage.Where(x => x.Sender == uyemail.ToString()).ToList(); ;
            return View(mesajlar);
        }

        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(TBMessage t)
        {
            var uyemail = (string)Session["Mail"].ToString();
            t.Sender = uyemail.ToString();
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.TBMessage.Add(t);
            db.SaveChanges();
            return RedirectToAction("To", "Messages");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;
namespace Proje.Controllers
{
    public class AnnouncementController : Controller
    {
        // GET: Duyuru
        THEATEREntities db = new THEATEREntities();
        public ActionResult Index()
        {
            var degerler = db.TBAnnouncement.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewAnnouncement(TBAnnouncement t)
        {
            db.TBAnnouncement.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteAnnouncement(int id)
        {
            var duyuru = db.TBAnnouncement.Find(id);
            db.TBAnnouncement.Remove(duyuru);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult AnnouncementDetail(TBAnnouncement p)
        {
            var duyuru = db.TBAnnouncement.Find(p.ID);
            return View("AnnouncementDetail", duyuru);
        }
        public ActionResult UpdateAnnouncement(TBAnnouncement t)
        {
            var duyuru = db.TBAnnouncement.Find(t.ID);
            
            duyuru.Contant = t.Contant;
            duyuru.DateOfAnnouncement = t.DateOfAnnouncement;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
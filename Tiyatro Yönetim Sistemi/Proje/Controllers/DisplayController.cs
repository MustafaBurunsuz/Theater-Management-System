using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;
using Proje.Models.Classes;

namespace Proje.Controllers
{
    public class DisplayController : Controller
    {
        // GET: Vitrin
        THEATEREntities db = new THEATEREntities();
        [HttpGet]
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.TBShow.ToList();
            cs.Deger2 = db.TBAbout_us.ToList();
        
            return View(cs);
        }
        [HttpPost]
        public ActionResult Index(TBContact t)
        {

            db.TBContact.Add(t);
            db.SaveChanges();
            return RedirectToAction("Index");




        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;

namespace Proje.Controllers
{
    public class WriterController : Controller
    {
        // GET: Kategori
        THEATEREntities db = new THEATEREntities();
        public ActionResult Index()
        {
            var degerler = db.TBWriter.ToList();
            return View(degerler);
            return View();
        }

        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }

        public ActionResult AddWriter(TBWriter p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddWriter");
            }
            db.TBWriter.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult DeleteWriter(int id)
        {
            var Writer = db.TBWriter.Find(id);
            db.TBWriter.Remove(Writer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetWriter(int id)
        {
            var wrt = db.TBWriter.Find(id);
            return View("GetWriter", wrt);

        }
     
        public ActionResult UpdateWriter(TBWriter p)
        {
            var yzr = db.TBWriter.Find(p.ID);
            yzr.Name = p.Name;
            yzr.Surname = p.Surname;
            yzr.Detail = p.Detail;
            db.SaveChanges();

            return RedirectToAction("Index");

        }
        public ActionResult WriterShows(int id)
        {
            var wrt = db.TBShow.Where(x => x.Writer== id).ToList();



            return View(wrt);
        }

    }
}
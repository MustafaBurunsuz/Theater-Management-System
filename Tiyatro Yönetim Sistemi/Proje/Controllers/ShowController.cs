using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;
namespace Proje.Controllers
{
    public class ShowController : Controller
    {
        THEATEREntities db = new THEATEREntities();
        public ActionResult Index(string p)
        {
            var shows = from show in db.TBShow select show;
            if (!string.IsNullOrEmpty(p))
            {
                shows = shows.Where(m => m.Name.Contains(p));
            }
            

            return View(shows.ToList());
        }
        //[HttpGet]
        //    public ActionResult AddShow()
        //    {


        //        List<SelectListItem> deger2 = (from i in db.TBWriter.ToList()
        //                                       select new SelectListItem
        //                                       {
        //                                           Text = i.Name + ' ' + i.Surname,
        //                                           Value = i.ID.ToString()
        //                                       }).ToList();

        //        ViewBag.dgr2 = deger2;
        //        return View();

        //    }
        //    [HttpPost]

        //    public ActionResult AddShow(TBShow p)
        //    {

        //        var yzr = db.TBWriter.Where(y => y.ID == p.TBWriter.ID).FirstOrDefault();

        //        p.TBWriter = yzr;
        //        db.TBShow.Add(p);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");


        //    }
        //    public ActionResult DeleteShow(int id)
        //    {
        //        var kitap = db.TBShow.Find(id);
        //        db.TBShow.Remove(kitap);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    public ActionResult GetShow(int id)
        //    {
        //        var ktp = db.TBShow.Find(id);



        //        List<SelectListItem> deger2 = (from i in db.TBWriter.ToList()
        //                                       select new SelectListItem
        //                                       {
        //                                           Text = i.Name + ' ' + i.Surname,
        //                                           Value = i.ID.ToString()
        //                                       }).ToList();

        //        ViewBag.dgr2 = deger2;

        //        return View("GetShow", ktp);

        //    }
        //    public ActionResult ShowUpdate(TBShow p)
        //    {
        //        var kitap = db.TBShow.Find(p.ID);
        //        kitap.Name = p.Name;
        //        kitap.PublishingYear = p.PublishingYear;
        //        kitap.Time = p.Time;

        //        kitap.State = true;

        //        var yzr = db.TBWriter.Where(y => y.ID == p.TBWriter.ID).FirstOrDefault();

        //        kitap.Writer = yzr.ID;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");


        //    }
    }

}

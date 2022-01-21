using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;
namespace Proje.Controllers
{
    public class StaffController : Controller
    {
        // GET: Personel
        THEATEREntities db = new THEATEREntities();
        public ActionResult Index()
        {
            var degerler = db.TBstaff_member.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddStaff()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStaff(TBstaff_member p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddStaff");


            }
            db.TBstaff_member.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult DeleteStaff(int id)
        {
            var person = db.TBstaff_member.Find(id);
            db.TBstaff_member.Remove(person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetStaff(int id)
        {
            var ktg = db.TBstaff_member.Find(id);
            return View("GetStaff", ktg);

        }
        public ActionResult UpdateStaff(TBstaff_member p)
        {
            var ktg = db.TBstaff_member.Find(p.ID);
            ktg.Name = p.Name;
            ktg.Phone = p.Phone;
            ktg.Age = p.Age;
            db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
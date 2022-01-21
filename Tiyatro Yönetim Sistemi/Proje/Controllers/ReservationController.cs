using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;
namespace Proje.Controllers
{

    public class ReservationController : Controller
    {
        // GET: Odunc
        THEATEREntities db = new THEATEREntities();
        public ActionResult Index()
        {
            var degerler = db.TBActivity.Where(X => X.operation_state == false).ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult GetReservation()
        {

            return View();

        }

        [HttpPost]
        public ActionResult GetReservation(TBActivity p)
        {
            db.TBActivity.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult GetReturn(int id)
        {
            var odn = db.TBActivity.Find(id);
            return View("GetReturn", odn);

        }
        public ActionResult UpdateReservation(TBActivity p)
        {
            var hrk = db.TBActivity.Find(p.ID);
            hrk.returning_date = p.returning_date;
            hrk.operation_state = true;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;

namespace MvcKutuphane.Controllers
{
    public class ActivityController : Controller
    {
      
        THEATEREntities db = new THEATEREntities();
        public ActionResult Index()
        {
            var degerler = db.TBActivity.Where(X => X.operation_state== true).ToList();
            return View(degerler);
        }
    }
}
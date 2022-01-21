using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace Proje.Controllers
{
    public class MembersController : Controller
    {
        // GET: Uye
        THEATEREntities db = new THEATEREntities();
        public ActionResult Index(int sayfa = 1)
        {
        
            var degerler = db.TBMembers.ToList().ToPagedList(sayfa, 5);
            return View(degerler);
        }
        [HttpGet]
        public ActionResult AddMember()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMember(TBMembers p)
        {
            if (!ModelState.IsValid)
            {
                return View("AddMember");


            }
            db.TBMembers.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult DeleteMember(int id)
        {
            var uye = db.TBMembers.Find(id);
            db.TBMembers.Remove(uye);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetMember(int id)
        {
            var uye = db.TBMembers.Find(id);
            return View("GetMember", uye);

        }
        public ActionResult UpdateMember(TBMembers p)
        {
            var uye = db.TBMembers.Find(p.ID);
            uye.Name = p.Name;
            uye.Surname = p.Surname;
            uye.Mail = p.Mail;
            uye.Username = p.Username;
            uye.Password = p.Password;
           
            uye.PhoneNumber = p.PhoneNumber;
            uye.Photo = p.Photo;
            db.SaveChanges();

            return RedirectToAction("Index");

        }
        public ActionResult MemberHistory(int id)
        {
            var ktp = db.TBActivity.Where(x => x.Member == id).ToList();
            return View(ktp);



        }
    }
}


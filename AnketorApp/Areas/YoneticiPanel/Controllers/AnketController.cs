using AnketorApp.Areas.YoneticiPanel.Filters;
using AnketorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnketorApp.Areas.YoneticiPanel.Controllers
{
    [GirisKontrol]
    public class AnketController : Controller
    {
        AnketSistemiEntities db = new AnketSistemiEntities();
        public ActionResult Liste()
        {
            return View(db.Anketler.ToList());
        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Anketler model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    model.OlusturmaTarihi = DateTime.Now;
                    model.YoneticiID = (Session["yonetici"] as Yoneticiler).YoneticiID;
                    db.Anketler.Add(model);
                    db.SaveChanges();
                    ViewBag.Basarili = "Anket Başarıyla Eklenmiştir";
                }
                catch
                {
                    ViewBag.HataMesaj = "Anket eklenirken hata oluştu"; 
                }
                
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Duzenle(int? id)
        {
            if (id != null)
            {
                Anketler model = db.Anketler.Find(id);
                if (model != null)
                {
                    return View(model);
                }
            }
            
            return RedirectToAction("Liste","Anket");
        }
        [HttpPost]
        public ActionResult Duzenle(Anketler model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    //Bu sınıfın içindeki verilere göre veritabanında güncelleme işlemi yapılması için geçerli komut
                    db.SaveChanges();
                    ViewBag.Basarili = "Anket Düzenlendi";
                }
                catch
                {
                    ViewBag.HataMesaj = "Düzenlenirken Bir Hata Oluştu";
                }
            }
            return View(model);
        }
    }
}
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
        // GET: YoneticiPanel/Anket
        public ActionResult Index()
        {
            return View();
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
    }
}
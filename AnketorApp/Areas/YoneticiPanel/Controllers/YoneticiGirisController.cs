using AnketorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnketorApp.Areas.YoneticiPanel.Controllers
{
    public class YoneticiGirisController : Controller
    {
        AnketSistemiEntities db = new AnketSistemiEntities();
        // GET: YoneticiPanel/YoneticiGiris
        public ActionResult Index()//Sayfa Açılırken
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string Email, string Sifre)//Sayfada bir buton benzeri event çalıştırıldığında
        {
            if (!string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Sifre))
            {
                Yoneticiler yon = db.Yoneticiler.FirstOrDefault(y => y.Email == Email && y.Sifre == Sifre);
                if (yon == null)
                {
                    ViewBag.mesaj = "Kullanıcı Bulunamadı";
                }
                else
                {
                    Session["yonetici"] = yon;
                    return RedirectToAction("Index", "YoneticiAnasayfa");
                }
            }
            else
            {
                ViewBag.mesaj = "Mail Ve şifre boş bırakılamaz";
            }
            return View();
        }
    }
}
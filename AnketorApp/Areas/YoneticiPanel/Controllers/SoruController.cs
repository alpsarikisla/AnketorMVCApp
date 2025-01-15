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
    public class SoruController : Controller
    {
        AnketSistemiEntities db = new AnketSistemiEntities();
        public ActionResult Index()
        {
            return View(db.Sorular.ToList());
        }
        public ActionResult AnketIleIndex(int? id)
        {
            if (id != null)
            {
                ViewBag.anket = db.Anketler.Find(id);
                return View(db.Sorular.Where(x => x.AnketID == id));
            }
            else
            {
                return RedirectToAction("Liste", "Anket");
            }
        }
    }
}
using AnketorApp.Areas.YoneticiPanel.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnketorApp.Areas.YoneticiPanel.Controllers
{
    [GirisKontrol]
    public class YoneticiAnasayfaController : Controller
    {
        // GET: YoneticiPanel/YoneticiAnasayfa
        public ActionResult Index()
        {
            return View();
        }
    }
}
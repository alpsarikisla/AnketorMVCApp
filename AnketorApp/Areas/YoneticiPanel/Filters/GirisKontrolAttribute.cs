using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace AnketorApp.Areas.YoneticiPanel.Filters
{
    public class GirisKontrolAttribute : ActionFilterAttribute, IAuthenticationFilter
    {//ActionFilterAttribute Sınıfın Actionlara uygulanabilecek bir attribute olması sağlanır.
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (filterContext.HttpContext.Session["yonetici"] == null)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            if (filterContext.Result == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new RedirectResult("~/YoneticiPanel/YoneticiGiris/Index");
            }
        }
    }
}
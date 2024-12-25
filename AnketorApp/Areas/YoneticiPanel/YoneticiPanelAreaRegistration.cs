using System.Web.Mvc;

namespace AnketorApp.Areas.YoneticiPanel
{
    public class YoneticiPanelAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "YoneticiPanel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "YoneticiPanel_default",
                "YoneticiPanel/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
using System.Web.Mvc;

namespace Areamvc.Areas.billing
{
    public class billingAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "billing";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "billing_default",
                "billing/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
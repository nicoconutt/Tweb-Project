using eUseControl.BussinesLogic.Interfaces;
using eUseControl.Domain.Enums;
using eUseControl.Web.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace eUseControl.Attribute
{
    public class AdminMode : ActionFilterAttribute
    {
        private readonly ISession _sessionBusinessLogic;

        public AdminMode()
        {
            var businessLogic = new BussinesLogic.BussinesLogic();
            _sessionBusinessLogic = businessLogic.GetSessionBL();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var apiCookie = HttpContext.Current.Request.Cookies["X-KEY"];
            if (apiCookie != null)
            {
                var profile = _sessionBusinessLogic.GetUserByCookie(apiCookie.Value);
                if (profile != null && profile.Level == URole.Admin)
                {
                    HttpContext.Current.SetMySessionObject(profile);
                }
                else
                {
                    filterContext.Result = new System.Web.Mvc.RedirectToRouteResult(new
                        RouteValueDictionary(new { controller = "Home", action = "Error" }));
                }
            }
            else
            {
                filterContext.Result = new System.Web.Mvc.RedirectToRouteResult(new
                        RouteValueDictionary(new { controller = "Home", action = "Error" }));
            }
        }
    }
}
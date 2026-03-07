
using System;
using MVVU_RESULT_MODEL;
using MVVU_RESULT_UI.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MVVU_RESULT_UI.Helpers
{
    public class CanonicalActionFilter : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string url = filterContext.HttpContext.Request != null ? filterContext.HttpContext.Request.Url() : WebConfigSetting.BaseURL;

            if (filterContext.Controller is Controller controller)
                controller.ViewBag.Canonical = url;
        }
    }
}
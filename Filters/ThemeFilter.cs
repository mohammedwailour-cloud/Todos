using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TODO_Correction.Filters
{
    public class ThemeFilter: IActionFilter
    {

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller as Controller;
            if (controller != null)
            {
                string theme = context.HttpContext.Request.Cookies["theme"] ?? "light";
                controller.ViewData["Theme"] = theme;
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TODO_Correction.Filters
{
    public class AuthFilter : ActionFilterAttribute
    {
       
            public override void OnActionExecuting(ActionExecutingContext context)
            {
                base.OnActionExecuting(context);
                if (context.HttpContext.Session.GetString("login") == null)
                {
                    context.Result = new RedirectResult("/Auth/Index");
                }
            }
        }
    
}

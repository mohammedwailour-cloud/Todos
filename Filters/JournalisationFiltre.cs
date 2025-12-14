using Microsoft.AspNetCore.Mvc.Filters;

namespace TODO_Correction.Filters
{
    public class JournalisationFiltre : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string logDir = Path.Combine(Directory.GetCurrentDirectory(), "Logs");
            if (!Directory.Exists(logDir))
                Directory.CreateDirectory(logDir);
            string filePath = Path.Combine(logDir, "actions.log");

            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string user = context.HttpContext.Session.GetString("login") ?? "Anonyme";
            string controller = context.RouteData.Values["controller"].ToString();
            string action = context.RouteData.Values["action"].ToString();


            string line = $"{date} - {user} - {controller} - {action}{Environment.NewLine}";

            File.AppendAllText(filePath, line);
        }
    }
}

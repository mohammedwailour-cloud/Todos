using Microsoft.AspNetCore.Mvc;

namespace TODO_Correction.Controllers
{
    public class ThemeController : Controller
    {
        public IActionResult Toggle()
        {
            string current = Request.Cookies["theme"];
            string newTheme = (current == "dark") ? "light" : "dark";

            Response.Cookies.Append("theme", newTheme, new CookieOptions
            {
                Expires = DateTime.Now.AddYears(1)
            });

            string referer = Request.Headers["Referer"].ToString();
            return Redirect(referer);
        }
    }
}

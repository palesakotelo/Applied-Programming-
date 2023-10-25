using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DisasterAlleviationFoundation.Pages
{
    public class UserLoginModel : PageModel
    {
        public IActionResult OnPost()
        {
            var username = Request.Form["user"];
            var password = Request.Form["psw"];
            var isAdmin = Request.Form["myCheck"] == "on"; 


            if (isAdmin)
            {
               
                return Redirect("/Category Management");
            }
            else
            {
                
                return Redirect("/Donations");
            }
        }
    }
}

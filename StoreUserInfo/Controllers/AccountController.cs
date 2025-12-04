using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace StoreUserInfo.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            // Simulate user login
            string username = "exampleUser";
            string password = "examplePassword";

            // Create a cookie to store user login information
            CookieOptions options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(5) // Cookie will expire in 5 days
            };
            Response.Cookies.Append("Username", username, options);
            Response.Cookies.Append("Password", password, options);

            ViewBag.Message = "User login information stored in cookie.";
            return View();
        }
    }
}

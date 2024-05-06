using Microsoft.AspNetCore.Mvc;
using ToValidatePlayerInfo.Models;

namespace ToValidatePlayerInfo.Controllers
{
    public class PlayersController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Player player)
        {
            if(ModelState.IsValid)
            {


                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}

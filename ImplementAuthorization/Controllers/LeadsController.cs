using ImplementAuthorization.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ImplementAuthorization.Controllers
{
    [Authorize]
    public class LeadsController : Controller
    {
        private readonly AuthorizationDbContext _authorizationDbContext;
        public LeadsController(AuthorizationDbContext authorizationDbContext)
        {
            _authorizationDbContext = authorizationDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

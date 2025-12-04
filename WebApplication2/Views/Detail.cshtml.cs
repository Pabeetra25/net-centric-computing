using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Views
{
    public class DetailModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; } = "";
        [BindProperty]
        public string LastName { get; set; } = "";
        [BindProperty]
        public int Age { get; set; }
        [BindProperty]
        public string Phone { get; set; } = "";
        public void OnGet()
        {
        }
        public void OnPost()
        { 
        }
    }
}

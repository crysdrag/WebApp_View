using Microsoft.AspNetCore.Mvc;

namespace WebApp_View.Models
{
    public class Product : Controller
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Image { get; set; } = "";
        public IActionResult Index()
        {
            return View();
        }
    }
}

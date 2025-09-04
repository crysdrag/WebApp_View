using Microsoft.AspNetCore.Mvc; 
using WebApp_View.Models;

namespace WebApp_View.ViewComponents
{
    public class HotProducts : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var products = new List<Product>
            {
                new Product{Id=4, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg"},
                new Product{Id=5, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg"},
                new Product{Id=6, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg"},
                new Product{Id=7, Name="Nồi cơm điện cao tần Nagakawa NAG0102", Image="/images/noicom.jpg"},
            };
            return View(products);
        }
    }
}

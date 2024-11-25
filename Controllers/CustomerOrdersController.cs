

using Microsoft.AspNetCore.Mvc;
using AspProjectOne.ViewModels;
using AspProjectOne.Models;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;

namespace AspProjectOne.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public ActionResult Index() //yollama işlemi
        {
        var customer = new Customer
               
        // Örnek müşteri ve sipariş verileri oluşturma
        {
            Id = 1,
            FirstName = "Ahmet Emre",
            LastName = "Ari",
            Email = "info@aemreari.com.tr"
        };

        var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Ürün 1", Price = 100.0m, Quantity = 2 },
            new Order { Id = 2, ProductName = "Ürün 2", Price = 50.0m, Quantity = 1 }
        };

        var viewModel = new CustomerOrderViewModel
        {
            Customer = customer,
            Orders = orders
        };

        return View(viewModel);
    
        }
    }
}
 
 

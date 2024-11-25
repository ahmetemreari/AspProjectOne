using System.Collections.Generic;
using AspProjectOne.Models; // Customer ve Order sınıflarının bulunduğu namespace
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;

namespace AspProjectOne.ViewModels
{
    public class CustomerOrderViewModel
    {
        public Customer Customer { get; set; } = new Customer();
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
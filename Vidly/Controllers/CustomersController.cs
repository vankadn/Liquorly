using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Liquorly.Models;
using Liquorly.ViewModels;

namespace Liquorly.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customer
        public ActionResult Index()
        {
            IEnumerable<Customer> customerList = GetCustomers();
            
            return View(customerList);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id==id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        private static IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() {Id=1, Name = "MetalHead" },
                new Customer() {Id =2, Name = "Hiipy"}
            };
        }

       


    }
}
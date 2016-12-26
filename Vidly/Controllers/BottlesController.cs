using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Liqourly.Models;
using Liquorly.Models;
using Liquorly.ViewModels;

namespace Liquorly.Controllers
{
    public class BottlesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var bottle = new Bottle() {Name = "Chivas Regal"};

            var customerList = new List<Customer>()
            {
                new Customer() {Name = "Customer 1" },
                new Customer() {Name = "Customer 2"}
            };
            var viewModel = new RandomBottleViewModel
            {
               Bottle = bottle,
               Customers = customerList
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id :" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content($"pageIndex={pageIndex}& sortBy={sortBy}");
        }

        [Route("bottles/manufactured/{year}")]
        [Route("bottles/manufactured/{year}/{month?}")]
        public ActionResult ByManufacturedDate(int year , int? month)
        {
            return Content($"{year}/{month}");
        }
    }
}   
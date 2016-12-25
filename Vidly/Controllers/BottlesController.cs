using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using static System.String;

namespace Vidly.Controllers
{
    public class BottlesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Bottle() {Name = "Chivas Regal"};

            //            return View(movie);
            //            return Content("Doood");
            //            return HttpNotFound();
            //            return new EmptyResult();
            return RedirectToAction("Index", "Home", new {page=1, sortBy = "name"});
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
            if (IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content($"pageIndex={pageIndex}& sortBy={sortBy}");
        }
    }
}   
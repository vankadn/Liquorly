using System.Collections.Generic;
using System.Web.Mvc;
using Liqourly.Models;

namespace Liquorly.Controllers
{
    public class BottlesController : Controller
    {
        public ActionResult Index()
        {
            var bottlesList = GetMovies();

            return View(bottlesList);
        }

        private static IEnumerable<Bottle> GetMovies()
        {
            return new List<Bottle>()
            {
                new Bottle() {Name = "Chivas Regal", Id=1},
                new Bottle() {Name = "Black Label", Id=2  }
            };
        }
    }
}   
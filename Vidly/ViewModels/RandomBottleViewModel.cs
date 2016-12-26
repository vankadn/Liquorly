using System.Collections.Generic;
using Liqourly.Models;
using Liquorly.Models;

namespace Liquorly.ViewModels
{
    public class RandomBottleViewModel
    {
        public Bottle Bottle { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FDSYBrewery.Models.ViewModels
{
    public class BeerViewModel
    {
        public int BeerId { get; set; }
        public string Name { get; set; }

        public string Type { get; set; }
        public decimal ABV { get; set; }
        public int BreweryId { get; set; }

        public double UnitPrice { get; set; }
        public List<int> BarId { get; set; }
    }
}
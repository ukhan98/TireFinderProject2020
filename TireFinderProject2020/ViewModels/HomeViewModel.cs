using TireFinderProject2020.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireFinderProject2020.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Tire> TireOnSale { get; set; }
    }
}

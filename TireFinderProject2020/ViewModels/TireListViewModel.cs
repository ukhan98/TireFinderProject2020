using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TireFinderProject2020.Models;

namespace TireFinderProject2020.ViewModels
{
    public class TireListViewModel
    {
        public IEnumerable<Tire> Tires { get; set; }

        public string  CurrentCategory { get; set; }



    }
}

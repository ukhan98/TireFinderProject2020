using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireFinderProject2020.Models
{
    public interface ITireRepository
    {

        IEnumerable<Tire> GetAllTire { get; }

        IEnumerable<Tire> GetTireOnSale { get; }

        Tire GetTireById(int tireId); 






    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireFinderProject2020.Models
{
    public class TireRepository : ITireRepository
    {
        public IEnumerable<Tire> GetAllTire => throw new NotImplementedException();

        public IEnumerable<Tire> GetTireOnSale => throw new NotImplementedException();

        public Tire GetTireById(int tireId)
        {
            return GetAllTire.FirstOrDefault(c => c.TireId == tireId);
        }
    }
}

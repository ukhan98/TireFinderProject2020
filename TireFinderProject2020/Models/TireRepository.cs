using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireFinderProject2020.Models
{
    public class TireRepository : ITireRepository
    {
        private readonly AppDbContext _appDbContext;

        public TireRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Tire> GetAllTire
        {
            get
            {
                return _appDbContext.Tires.Include(c => c.Category);
            }
        }

        public IEnumerable<Tire> GetTireOnSale
        {
            get
            {
                return _appDbContext.Tires.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public Tire GetTireById(int tireId)
        {
            return _appDbContext.Tires.FirstOrDefault(c => c.TireId == tireId);
        }
    }
}

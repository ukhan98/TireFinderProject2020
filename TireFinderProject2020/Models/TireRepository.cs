using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireFinderProject2020.Models
{
    public class TireRepository : ITireRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository(); 

        public IEnumerable<Tire> GetAllTire => new List<Tire>
        {
            new Tire {TireId = 1, Name = "Winter Tires", Price = 4.95M, Description = "Random Test Text", Category = _categoryRepository.GetAllCategories.ToList()[0], 
                ImageUrl = "https://www.michelin.ca/on/demandware.static/-/Sites-michelin-ca-Library/default/dw7f4d61c8/images/homepage/hero/Michelin-Homepage-X-Ice-Snow-Tire.png", IsInStock=true, IsOnSale=false,
                ImageThumbnailUrl = "https://p7.hiclipart.com/preview/236/109/190/car-snow-tire-wheel-tire-thumbnail.jpg" },
             new Tire {TireId = 2, Name = "Summer Tires", Price = 5.95M, Description = "Random Test Text Again", Category = _categoryRepository.GetAllCategories.ToList()[1],
                ImageUrl = "https://www.michelin.ca/on/demandware.static/-/Sites-michelin-ca-Library/default/dw7f4d61c8/images/homepage/hero/Michelin-Homepage-X-Ice-Snow-Tire.png", IsInStock=true, IsOnSale=false,
                ImageThumbnailUrl = "https://p7.hiclipart.com/preview/236/109/190/car-snow-tire-wheel-tire-thumbnail.jpg" }
        };
        public IEnumerable<Tire> GetTireOnSale => throw new NotImplementedException();

        public Tire GetTireById(int tireId)
        {
            return GetAllTire.FirstOrDefault(c => c.TireId == tireId);
        }
    }
}

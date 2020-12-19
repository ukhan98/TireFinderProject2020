using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireFinderProject2020.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {

            new Category{CategoryId=1, CategoryName="By Vehicle", CategoryDescription="Tires are Assorted by Vehicles" },

            new Category{CategoryId=1, CategoryName="By Size", CategoryDescription="Tires are Assorted by Size" },

            new Category{CategoryId=1, CategoryName="By Brand", CategoryDescription="Tires are Assorted by Brand" }
             
        };
    }
}

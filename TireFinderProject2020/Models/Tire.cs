using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireFinderProject2020.Models
{
    public class Tire
    {
        public int TireId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public decimal  Price { get; set; }
        public String  ImageUrl { get; set; }
        public String ImageThumbnailUrl { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
}


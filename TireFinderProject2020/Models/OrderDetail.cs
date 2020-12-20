using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireFinderProject2020.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int TireId { get; set; }
        public Tire Tire { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public Order Order { get; set; }
    }
}

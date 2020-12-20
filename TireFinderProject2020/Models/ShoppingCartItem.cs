using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireFinderProject2020.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; }
        public Tire Tire { get; set; }
        public int Amount { get; set; }
    }
}

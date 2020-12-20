using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TireFinderProject2020.ViewModels;

namespace TireFinderProject2020.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Tire tire, int amount)
        {
            var shoppingCartItem = _appDbContext.ShopppingCartItems.SingleOrDefault(
                s => s.Tire.TireId == tire.TireId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Tire = tire,
                    Amount = amount
                };

                _appDbContext.ShopppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            _appDbContext.SaveChanges();
        }

        public int RemoveFromCart(Tire tire)
        {
            var shoppingCartItem = _appDbContext.ShopppingCartItems.SingleOrDefault(
                s => s.Tire.TireId == tire.TireId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShopppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShopppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Tire)
                .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext.ShopppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShopppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = _appDbContext.ShopppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Tire.Price * c.Amount).Sum();

            return total;
        }
    }
}

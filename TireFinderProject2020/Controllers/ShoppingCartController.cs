using TireFinderProject2020.Models;
using TireFinderProject2020.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TireFinderProject2020.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ITireRepository _tireRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(ITireRepository tireRepository, ShoppingCart shoppingCart)
        {
            _tireRepository = tireRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int tireId)
        {
            var selectedCandy = _tireRepository.GetAllTire.FirstOrDefault(c => c.TireId == tireId);

            if (selectedCandy != null)
            {
                _shoppingCart.AddToCart(selectedCandy, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int tireId)
        {
            var selectedTire = _tireRepository.GetAllTire.FirstOrDefault(c => c.TireId == tireId);

            if (selectedTire != null)
            {
                _shoppingCart.RemoveFromCart(selectedTire);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}

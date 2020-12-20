using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TireFinderProject2020.Models;
using TireFinderProject2020.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace CandyShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITireRepository _tireRepository;

        public HomeController(ITireRepository tireRepository)
        {
            _tireRepository = tireRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                TireOnSale = _tireRepository.GetTireOnSale
            };

            return View(homeViewModel);
        }
    }
}
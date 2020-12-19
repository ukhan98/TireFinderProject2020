using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TireFinderProject2020.Models;
using TireFinderProject2020.ViewModels;

namespace TireFinderProject2020.Controllers
{
    public class TireController : Controller
    {

        private readonly ITireRepository _tireRepository;
        private readonly ICategoryRepository _categoryRepository;

        public TireController(ITireRepository tireRepository, ICategoryRepository categoryRepository)
        {
            _tireRepository = tireRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "BestSellers";
            //return View(_tireRepository.GetAllTire);

            var tireListViewModel = new TireListViewModel();
            tireListViewModel.Tires = _tireRepository.GetAllTire;
            tireListViewModel.CurrentCategory = "BestSellers";
            return View(tireListViewModel); 

        
        }


    }
}

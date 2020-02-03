using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShopNew.Main.Interfaces;
using IntroShopNew.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IntroShopNew.Controllers
{
    public class MotherboardController : Controller
    {
        private readonly IAllMotherboards _allMotherboards;
        private readonly IMotherboardCategory _allMotherboardsCategories;
        public MotherboardController(IAllMotherboards IAllMotherboards, IMotherboardCategory IMotherboardCategory)
        {
            _allMotherboards = IAllMotherboards;
            _allMotherboardsCategories = IMotherboardCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Motherboards";
            MotherboardListViewModel obj = new MotherboardListViewModel();
            obj.allMotherboards = _allMotherboards.Motherboards;
            obj.currentCategory = "Best category";

            return View(obj);



        }
    }
}

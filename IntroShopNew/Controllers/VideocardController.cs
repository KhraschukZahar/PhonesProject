using IntroShopNew.Main.Interfaces;
using IntroShopNew.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IntroShopNew.Controllers
{
    public class VideocardController : Controller
    {
        private readonly IAllVideocards _allVideocards;
        private readonly IVideocardCategory _allVideocardsCategories;
        public VideocardController(IAllVideocards IAllVideocards, IVideocardCategory IVideocardCategory)
        {
            _allVideocards = IAllVideocards;
            _allVideocardsCategories = IVideocardCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Videocards";
            VideocardListViewModel obj = new VideocardListViewModel();
            obj.allVideocards = _allVideocards.Videocards;
            obj.currentCategory = "Best category";

            return View(obj);



        }
    }
}
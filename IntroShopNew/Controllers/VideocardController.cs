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
        private readonly IVideoCardCategory _allVideocardsCategories;
        public VideocardController(IAllVideocards IAllVideocards, IVideoCardCategory IVideoCardCategory)
        {
            _allVideocards = IAllVideocards;
            _allVideocardsCategories = IVideoCardCategory;
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
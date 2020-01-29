using IntroShopNew.Main.Interfaces;
using IntroShopNew.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IntroShopNew.Controllers
{
    public class PhoneController : Controller
    {
        private readonly IAllPhones _allPhones;
        private readonly IPhoneCategory _allCategories;
        public PhoneController(IAllPhones iAllPhones,IPhoneCategory IPhoneCategory)
        {
            _allPhones = iAllPhones;
            _allCategories = IPhoneCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Phones";
            PhoneListViewModel obj = new PhoneListViewModel();
            obj.allPhones = _allPhones.Phones;
            obj.currentCategory = "Best category";

            return View(obj);
            

         
        }
    }
}

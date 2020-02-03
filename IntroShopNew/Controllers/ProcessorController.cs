using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IntroShopNew.Main.Interfaces;
using IntroShopNew.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace IntroShopNew.Controllers
{
    public class ProcessorController : Controller
    {
        private readonly IAllProcessors _allProcessors;
        private readonly IProcessorCategory _allProcessorCategories;
        public ProcessorController(IAllProcessors IAllProcessors, IProcessorCategory IProcessorCategory)
        {
            _allProcessors = IAllProcessors;
            _allProcessorCategories = IProcessorCategory;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Processors";
            ProcessorListViewModel obj = new ProcessorListViewModel();
            obj.allProcessors = _allProcessors.Processors;
            obj.currentCategory = "Best category";

            return View(obj);
        }
    }
}

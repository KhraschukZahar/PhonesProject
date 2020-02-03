using IntroShopNew.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.ViewModel
{
    public class MotherboardListViewModel
    {
        public IEnumerable<Motherboard> allMotherboards { get; set; }
        public string currentCategory { get; set; }
    }
}

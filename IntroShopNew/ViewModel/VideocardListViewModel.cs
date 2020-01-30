using IntroShopNew.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.ViewModel
{
    public class VideocardListViewModel
    {
        public IEnumerable<Videocard> allVideocards { get; set; }
        public string currentCategory { get; set; }
    }
}

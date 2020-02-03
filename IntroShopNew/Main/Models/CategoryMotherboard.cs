using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main.Models
{
    public class CategoryMotherboard
    {
        public int id { get; set; }

        public string categoryName { get; set; }

        public string categoryDescription { get; set; }

        public List<Motherboard> motherboards { get; set; }
    }
}

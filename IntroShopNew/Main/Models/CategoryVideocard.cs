using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main.Models
{
    public class CategoryVideocard
    {
        public int id { get; set; }

        public string categoryName { get; set; }

        public string categoryDescription { get; set; }

        public List<Videocard> videocards { get; set; }
    }
}

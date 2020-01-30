using IntroShopNew.Main.Interfaces;
using IntroShopNew.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main.MockData
{
    public class MockVideocardCategory : IVideoCardCategory
    {
        public IEnumerable<CategoryVideocard> AllVideocardCategories
        {
            get
            {
                return new List<CategoryVideocard>
                {
                    new CategoryVideocard{categoryName = "Game",categoryDescription="Videocard for power games"},
                    new CategoryVideocard{categoryName = "Simple",categoryDescription="Videocard for low functions"}
                };
            }
        }  
    }
}

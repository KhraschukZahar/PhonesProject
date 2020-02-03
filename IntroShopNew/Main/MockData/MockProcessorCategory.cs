using IntroShopNew.Main.Interfaces;
using IntroShopNew.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main.MockData
{
    public class MockProcessorCategory : IProcessorCategory
    {
        public IEnumerable<CategoryProcessor> AllProcessorCategories
        {
            get
            {
                return new List<CategoryProcessor>
                {
                    new CategoryProcessor{categoryName = "Low or midle price",categoryDescription="Processor intended for simple command interpretation"},
                    new CategoryProcessor{categoryName = "Expensive",categoryDescription="Processor intended for hard command interpretation"}
                };
            }
        }
    }
}

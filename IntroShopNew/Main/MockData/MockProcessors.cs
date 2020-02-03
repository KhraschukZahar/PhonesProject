using IntroShopNew.Main.Interfaces;
using IntroShopNew.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main.MockData
{
    public class MockProcessors : IAllProcessors
    {
        private readonly IProcessorCategory _categoryProcessor = new MockProcessorCategory();
        public IEnumerable<Processor> Processors
        {
            get
            {
                return new List<Processor>
                {
                    new Processor
                    {
                        name = "AMD A6 7480 3.5GHz",
                        description = "(1MB, Carizzo, 65W, FM2+) Box (AD7480ACABBOX)",
                        img = "/img/AMD A6 7480.jpg",
                        price = 998,
                        CategoryProcessor = _categoryProcessor.AllProcessorCategories.First()
                    },
                    new Processor
                    {
                        name = "AMD Ryzen Threadripper 3960X 3.8GHz",
                        description = "128MB (100-100000010WOF) sTRX4 BOX",
                        img = "/img/AMD Ryzen Threadripper 3960X 3.8GHz.jpg",
                        price = 47084,
                        CategoryProcessor = _categoryProcessor.AllProcessorCategories.Last()
                    },
                    new Processor
                    {
                        name = "Intel Core i3-9100F 3.6GHz",
                        description = "8GT/s/6MB (BX80684I39100F) s1151 BOX",
                        img = "/img/Intel Core i3-9100F 3.6GHz.jpg",
                        price = 2205,
                        CategoryProcessor = _categoryProcessor.AllProcessorCategories.First()
                    },
                    new Processor
                    {
                        name = "Intel Core i7-9700 3.0GHz",
                        description = "8GT / s / 12MB (BX80684I79700) s1151 BOX",
                        img = "/img/Intel Core i7-9700 3.0GHz.jpg",
                        price = 10250,
                        CategoryProcessor = _categoryProcessor.AllProcessorCategories.Last()
                    },
                    new Processor
                    {
                        name = "Intel Celeron G4900 3.1GHz",
                        description = "8GT/s/2MB (BX80684G4900) s1151 BOX",
                        img = "/img/Intel Celeron G4900 3.1GHz.jpg",
                        price = 1580,
                        CategoryProcessor = _categoryProcessor.AllProcessorCategories.First()
                    },
            };
            }
        }
    }
}

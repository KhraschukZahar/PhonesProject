using IntroShopNew.Main.Interfaces;
using IntroShopNew.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main.MockData
{
    public class MockVideocards : IAllVideocards
    {
        private readonly IVideoCardCategory _categoryVideocard = new MockVideocardCategory();
        public IEnumerable<Videocard> Videocards
        {
            get
            {
                return new List<Videocard>
                {
                    new Videocard
                    {
                        name = "MSI PCI-Ex GeForce GTX 1660 Super Gaming X",
                        description = "6GB GDDR6 (192bit) (1830/14000) (HDMI, 3 x DisplayPort) (GTX 1660 SUPER GAMING X)",
                        img = "/img/MSI PCI-Ex GeForce GTX 1660 Super Gaming X.jpg",
                        price = 7550,
                        CategoryVideocard = _categoryVideocard.AllVideocardCategories.First()
                    },
                    new Videocard
                    {
                        name = "AFOX PCI-Ex GeForce G210",
                        description = "1GB DDR3 (64bit) (589/1402) (DVI, VGA, HDMI) (AF210-1024D3L5)",
                        img = "/img/AFOX PCI-Ex GeForce G210.jpg",
                        price = 819,
                        CategoryVideocard = _categoryVideocard.AllVideocardCategories.Last()
                    },
                    new Videocard
                    {
                        name = "Asus PCI-Ex GeForce RTX 2080 Ti ROG Strix",
                        description = "11GB GDDR6 (352bit) (1350/14000) (2 x HDMI, 2 x DisplayPort, 1 x USB Type-C) + EKWB EK-Vector Strix RTX 2080 Ti RGB (STRIX-RTX2080TI-O11G+EKWB)",
                        img = "/img/Asus PCI-Ex GeForce RTX 2080 Ti ROG Strix.jpg",
                        price = 40978,
                        CategoryVideocard = _categoryVideocard.AllVideocardCategories.First()
                    },
                    new Videocard
                    {
                        name = "Asus PCI-Ex GeForce GT 710",
                        description = "1GB GDDR5 (32bit) (954/5012) (VGA, DVI, HDMI) (GT710-SL-1GD5-BRK)",
                        img = "/img/Asus PCI-Ex GeForce GT 710.jpg",
                        price = 1006,
                        CategoryVideocard = _categoryVideocard.AllVideocardCategories.Last()
                    },
                    new Videocard
                    {
                        name = "Gigabyte PCI-Ex GeForce RTX 2080 Super Aorus",
                        description = "8GB GDDR6 (256bit) (15500) (Type-C, 3 x HDMI, 3 x Display Port) (GV-N208SAORUS-8GC)",
                        img = "/img/Gigabyte PCI-Ex GeForce RTX 2080 Super Aorus.jpg",
                        price = 22688,
                        CategoryVideocard = _categoryVideocard.AllVideocardCategories.First()
                    },
            };
            }
        }
    }
}

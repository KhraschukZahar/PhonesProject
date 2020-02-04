using IntroShopNew.Main.Models;
using IntroShopNew.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main.Repository
{
    public class CategoryMotherboardRepository : IMotherboardCategory
    {
        private readonly DBContent dbContent;
        public CategoryMotherboardRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<CategoryMotherboard> AllMotherboardCategories => dbContent.CategoryMotherboarddd;
    }
}
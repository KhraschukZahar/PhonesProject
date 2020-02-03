using IntroShopNew.Main.Models;
using IntroShopNew.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main.Repository
{
    public class CategoryRepository : IVideocardCategory
    {
        private readonly DBContent dbContent;   
        public CategoryRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }
        public IEnumerable<Category> AllCategories => dbContent.Category;
    }
}
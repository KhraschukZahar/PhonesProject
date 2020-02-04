using IntroShopNew.Main.Interfaces;
using IntroShopNew.Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main.Repository
{
    public class MotherboardRepository : IAllMotherboards
    {
        private readonly DBContent dbContent;
        public MotherboardRepository(DBContent dbContent)
        {
            this.dbContent = dbContent;
        }

        public IEnumerable<Motherboard> Motherboards => dbContent.Motherboard.Include(c => c.CategoryMotherboard);
    }
}
using IntroShopNew.Main.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main
{
    public class DBContent : DbContext
    {
        public DBContent(DbContextOptions<DBContent> options) : base(options)
        {

        }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Category> Category { get; set; }

        public DbSet<Motherboard> Motherboard { get; set; }
        public DbSet<CategoryMotherboard> CategoryMotherboarddd { get; set; }


    }
}
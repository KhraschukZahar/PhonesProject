using IntroShopNew.Main.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main
{
    public class DBObjects
    {
        public static void Initial(DBContent content)
        {

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Phone.Any())
            {
                content.AddRange(
                   new Phone
                   {
                       name = "Samsung S10",
                       description = "Best phone by Samsung",
                       img = "/img/samsung_galaxy_s10_6_128_gb_white.jpg",
                       price = 23000,                 
                       Category = Categories["Flagman"]
                   },
                    new Phone
                    {
                        name = "Nokia 3310",
                        description = "Old but gold",
                        img = "/img/nokia3310.jpg",
                        price = 700,
                        Category = Categories["Flagman"]
                    }
                );
            }

            if (!content.CategoryMotherboarddd.Any())
            {
                content.CategoryMotherboarddd.AddRange(CategoriesMotherboard.Select(c => c.Value));
            }
            if (!content.Motherboard.Any())
            {
                content.AddRange(
                   new Motherboard
                   {
                       name = "MSI MEG X570 Ace",
                       description = "(sAM4, AMD X570, PCI-Ex16)",
                       img = "/img/MSI MEG X570 Ace.jpg",
                       price = 11250,
                       CategoryMotherboard = CategoriesMotherboard["Hard and strong"]
                   },
                    new Motherboard
                    {
                        name = "Asus Prime H310M-E R2.0",
                        description = "(s1151, Intel H310, PCI-Ex16)",
                        img = "/img/Asus Prime H310M-E R2.0.jpg",
                        price = 1589,
                        CategoryMotherboard = CategoriesMotherboard["Budget"]
                    },
                     new Motherboard
                     {
                         name = "Asus Prime X570-Pro",
                         description = "(sAM4, AMD X570, PCI-Ex16)",
                         img = "/img/Asus Prime X570-Pro.jpg",
                         price = 6909,
                         CategoryMotherboard = CategoriesMotherboard["Hard and strong"]
                     },
                    new Motherboard
                    {
                        name = "Asus Prime A320M-K",
                        description = "(sAM4, AMD A320, PCI-Ex16)",
                        img = "/img/Asus Prime A320M-K.jpg",
                        price = 1310,
                        CategoryMotherboard = CategoriesMotherboard["Budget"]
                    },
                     new Motherboard
                     {
                         name = "MSI MPG X570 Gaming Pro Carbon Wi-Fi",
                         description = "(sAM4, AMD X570, PCI-Ex16)",
                         img = "/img/MSI MPG X570 Gaming Pro Carbon Wi-Fi.jpg",
                         price = 6996,
                         CategoryMotherboard = CategoriesMotherboard["Hard and strong"]
                     }
                );
            }
            content.SaveChanges();
        }


        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = "Flagman", categoryDescription = "Phone with hight price and extra functions" },
                        new Category { categoryName = "Budget", categoryDescription = "Phone with low price without extra functions" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category item in list)
                    {
                        category.Add(item.categoryName, item);
                    }
                }
                return category;
            }

        }
        private static Dictionary<string, CategoryMotherboard> categoryMotherboard;
        public static Dictionary<string, CategoryMotherboard> CategoriesMotherboard
        {
            get
            {
                if (categoryMotherboard == null)
                {
                    var list = new CategoryMotherboard[]
                    {
                        new CategoryMotherboard { categoryName = "Hard and strong", categoryDescription = "Better for games and some strong computers(hight price)" },
                        new CategoryMotherboard { categoryName = "Budget", categoryDescription = "Better for simple computers(low price)" }
                    };
                    categoryMotherboard = new Dictionary<string, CategoryMotherboard>();
                    foreach (CategoryMotherboard item in list)
                    {
                        categoryMotherboard.Add(item.categoryName, item);
                    }
                }
                return categoryMotherboard;
            }

        }
    }
}
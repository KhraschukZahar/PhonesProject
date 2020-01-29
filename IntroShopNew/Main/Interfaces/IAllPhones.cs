using IntroShopNew.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main.Interfaces
{
    public interface IAllPhones
    {
        IEnumerable<Phone> Phones { get; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroShopNew.Main.Models
{
    public class Processor
    {
        public int id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string img { get; set; }
        public uint price { get; set; }

        public virtual CategoryProcessor CategoryProcessor { get; set; }
    }
}
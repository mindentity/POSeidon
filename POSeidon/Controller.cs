﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSeidon
{
    public static class Controller
    {
        public static IList<Product> Products { get; set; }
        public static IList<Supplier> Suppliers { get; set; }
        public static Settings Settings { get; set; }

        static Controller()
        {
            Products = DBUtils.GetAllProducts().ToList();
            Suppliers = DBUtils.GetAllSuppliers().ToList();
            Settings = DBUtils.GetSettings();
        }
    }
}

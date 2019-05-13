﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace POSeidon
{
    public static class Controller
    {
        public static BindingList<CustomerLog> CustomerLogs { get; set; }
        public static BindingList<SupplierLog> SupplierLogs { get; set; }
        public static BindingList<Product> Products { get; set; }
        public static BindingList<Supplier> Suppliers { get; set; }
        public static Settings Settings { get; set; }
        public static ShoppingCart ShoppingCart { get; set; }

        static Controller()
        {
            CustomerLogs = new BindingList<CustomerLog>(DBUtils.GetAllCustomerLogs().ToList());
            SupplierLogs = new BindingList<SupplierLog>(DBUtils.GetAllSupplierLogs().ToList());
            Products = new BindingList<Product>(DBUtils.GetAllProducts().ToList());
            Suppliers = new BindingList<Supplier>(DBUtils.GetAllSuppliers().ToList());
            Settings = DBUtils.GetSettings();
            ShoppingCart = new ShoppingCart
            {
                Items = new List<ShoppingCartItem>(),
                TotalPrice = 0.0M
            };
        }

        public static bool AddProduct(Product product, Supplier supplier, double amount)
        {
            product.StockAmount += amount;
            if (DBUtils.UpdateOrCreateProduct(product))
            {
                var log = new SupplierLog
                {
                    Date = DateTime.UtcNow,
                    ProductAmount = amount,
                    ProductName = product.Name,
                    SupplierName = supplier.Name,
                    SupplierPhone = supplier.Phone,
                    SupplierAddress = supplier.Address,
                    SupplierEmail = supplier.Email
                };
                DBUtils.CreateLog(log);
                return true;
            }
            return false;
        }

        public static bool DeleteProduct(Product product)
        {
            ShoppingCartItem item = ShoppingCart.Items.FirstOrDefault(x => x.Product.Id == product.Id);
            if (item != null)
            {
                ShoppingCart.Items.Remove(item);
            }
            return DBUtils.DeleteProduct(product);
        }
    }
}

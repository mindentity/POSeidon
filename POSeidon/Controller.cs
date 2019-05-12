using System;
using System.Collections.Generic;
using System.Linq;

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
    }
}

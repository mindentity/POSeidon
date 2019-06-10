using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace POSeidon
{
    public static class Controller
    {
        public static BindingList<CustomerLog> CustomerLogs { get; set; }
        public static BindingList<SupplierLog> SupplierLogs { get; set; }
        public static BindingList<Product> Products { get; set; }
        public static BindingList<Supplier> Suppliers { get; set; }
        public static BindingList<Customer> Customers { get; set; }
        public static BindingList<User> Users { get; set; }
        public static Settings Settings { get; set; }
        public static ShoppingCart ShoppingCart { get; set; }
        public static User User { get; set; }

        static Controller()
        {
            CustomerLogs = new BindingList<CustomerLog>(DBUtils.GetAllCustomerLogs().ToList());
            SupplierLogs = new BindingList<SupplierLog>(DBUtils.GetAllSupplierLogs().ToList());
            Products = new BindingList<Product>(DBUtils.GetAllProducts().ToList());
            Suppliers = new BindingList<Supplier>(DBUtils.GetAllSuppliers().ToList());
            Customers = new BindingList<Customer>(DBUtils.GetAllCustomers().ToList());
            Users = new BindingList<User>(DBUtils.GetAllUsers().ToList());
            Settings = DBUtils.GetSettings();
            ShoppingCart = new ShoppingCart
            {
                Items = new BindingList<ShoppingCartItem>()
            };
        }

        public static void SetLanguage()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Settings.Language);
        }

        public static void Login(string username, string password)
        {
            try
            {
                DBUtils.Auth(username, password);
                User = DBUtils.GetUserByUsername(username);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool DeleteUser(User user)
        {
            if (DBUtils.DeleteUser(user))
            {
                Users.ResetBindings();
                return true;
            }
            return false;
        }

        public static bool AddUser(string firstName, string lastName, string username, string password, bool isAdmin=false)
        {
            if (DBUtils.CreateUser(firstName, lastName, username, password, isAdmin))
            {
                Users.ResetBindings();
                return true;
            }
            return false;
        }

        public static bool UpdateUser(User user)
        {
            if (DBUtils.UpdateUser(user))
            {
                Users.ResetBindings();
                return true;
            }
            return false;
        }

        public static bool AddProduct(Product product, double amount, Supplier supplier, decimal totalCost)
        {
            product.StockAmount += amount;
            if (!DBUtils.UpdateOrCreateProduct(product))
            {
                return false;
            }
            var log = new SupplierLog
            {
                Date = DateTime.UtcNow,
                ProductAmount = amount,
                ProductName = product.Name,
                SupplierName = supplier.Name,
                SupplierPhone = supplier.Phone,
                SupplierAddress = supplier.Address,
                SupplierEmail = supplier.Email,
                TotalCost = totalCost
            };
            if (!DBUtils.CreateLog(log))
            {
                return false;
            }
            Controller.SupplierLogs.Add(log);
            return true;
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

        public static bool AddCustomer(Customer customer)
        {
            if (!DBUtils.CreateCustomer(customer))
            {
                return false;
            }
            Controller.Customers.Add(customer);
            return true;
        }

        public static bool AddSupplier(Supplier supplier)
        {
            if (!DBUtils.CreateSupplier(supplier))
            {
                return false;
            }
            Controller.Suppliers.Add(supplier);
            return true;
        }
    }
}

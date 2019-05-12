using IniParser;
using IniParser.Model;
using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace POSeidon
{
    public static class DBUtils
    {
        public static string ConfigFilePath { get; } = @"config.ini";
        public static IniData Config { get; }

        static DBUtils()
        {
            try
            {
                var parser = new FileIniDataParser();
                Config = parser.ReadFile(ConfigFilePath);
            }
            catch
            {
                MessageBox.Show(String.Format("Failed to read {0}!", ConfigFilePath), "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (!File.Exists(Config["Database"]["FilePath"]))
            {
                InitDB();
            }
        }

        private static void CreateSettings()
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Settings>("settings");
                var settings = new Settings
                {
                    NumberFormat = Thread.CurrentThread.CurrentCulture.NumberFormat
                };
                col.Insert(settings);
            }
        }

        private static void InitDB()
        {
            var adminUser = new User
            {
                FirstName = Config["Default"]["FirstName"],
                LastName = Config["Default"]["LastName"],
                Username = Config["Default"]["Username"],
                Password = Config["Default"]["Password"],
                IsAdmin = true
            };
            CreateUser(adminUser);
            CreateSettings();
        }

        public static Settings GetSettings()
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Settings>("settings");
                var settings = col.FindById(1);
                return settings;
            }
        }

        public static void Auth(string username, string password)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username", true);
                var user = col.FindOne(Query.EQ("Username", username));
                if (user == null)
                {
                    throw new Exception("User does not exist!");
                }
                if (user.Password != password)
                {
                    throw new Exception("Wrong password!");
                }
            }
        }

        public static bool CreateUser(string firstName, string lastName, string username, string password, bool isAdmin = false)
        {
            User user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                Password = password,
                IsAdmin = isAdmin
            };
            return CreateUser(user);
        }

        public static bool CreateUser(User user)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username", true);
                try
                {
                    col.Insert(user);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool DeleteUser(User user)
        {
            return DeleteUserById(user.Id);
        }

        public static bool DeleteUserById(int id)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                return col.Delete(id);
            }
        }

        public static bool DeleteUserByUsername(string username)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username", true);
                int deletedRows = col.Delete(Query.EQ("Username", username));
                return deletedRows > 0;
            }
        }

        public static bool ChangePassword(string username, string newPassword)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username", true);
                var user = col.FindOne(Query.EQ("Username", username));
                if (user == null)
                {
                    return false;
                }
                user.Password = newPassword;
                return col.Update(user);
            }
        }

        public static bool UpdateUser(User user)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                return col.Update(user);
            }
        }

        public static User GetUserById(int id)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                var user = col.FindById(id);
                return user;
            }
        }

        public static User GetUserByUsername(string username)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username", true);
                var user = col.FindOne(Query.EQ("Username", username));
                return user;
            }
        }

        public static IEnumerable<User> GetAllUsers()
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                var users = col.FindAll();
                return users;
            }
        }

        public static bool CreateProduct(Product product)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                col.EnsureIndex("Name", true);
                try
                {
                    col.Insert(product);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool CreateProduct(string name, double price, bool isCountable, int stockAmount = 0)
        {
            Product product = new Product
            {
                Name = name,
                Price = price,
                IsCountable = isCountable,
                StockAmount = stockAmount
            };
            return CreateProduct(product);
        }

        public static Product GetProductById(int id)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                var product = col.FindById(id);
                return product;
            }
        }

        public static Product GetProductByName(string name)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                col.EnsureIndex("Name", true);
                var product = col.FindOne(Query.EQ("Name", name));
                return product;
            }
        }

        public static bool UpdateProduct(Product product)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                return col.Update(product);
            }
        }

        public static bool DeleteProduct(Product product)
        {
            return DeleteProductById(product.Id);
        }

        public static bool DeleteProductById(int id)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                return col.Delete(id);
            }
        }

        public static bool DeleteProductByName(string name)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                col.EnsureIndex("Name", true);
                int deletedRows = col.Delete(Query.EQ("Name", name));
                return deletedRows > 0;
            }
        }

        public static IEnumerable<Product> GetAllProducts()
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                var products = col.FindAll();
                return products;
            }
        }

        public static bool CreateSupplier(string name, string phone, string email, string address)
        {
            Supplier supplier = new Supplier
            {
                Name = name,
                Phone = phone,
                Email = email,
                Address = address
            };
            return CreateSupplier(supplier);
        }

        public static bool CreateSupplier(Supplier supplier)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Supplier>("supplier");
                col.EnsureIndex("Name", true);
                try
                {
                    col.Insert(supplier);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static Supplier GetSupplierById(int id)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Supplier>("supplier");
                var supplier = col.FindById(id);
                return supplier;
            }
        }

        public static Supplier GetSupplierByName(string name)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Supplier>("supplier");
                col.EnsureIndex("Name", true);
                var supplier = col.FindOne(Query.EQ("Name", name));
                return supplier;
            }
        }

        public static bool UpdateSupplier(Supplier supplier)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Supplier>("supplier");
                return col.Update(supplier);
            }
        }

        public static bool DeleteSupplier(Supplier supplier)
        {
            return DeleteSupplierById(supplier.Id);
        }

        public static bool DeleteSupplierById(int id)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Supplier>("supplier");
                return col.Delete(id);
            }
        }

        public static bool DeleteSupplierByName(string name)
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Supplier>("supplier");
                col.EnsureIndex("Name", true);
                int deletedRows = col.Delete(Query.EQ("Name", name));
                return deletedRows > 0;
            }
        }

        public static IEnumerable<Supplier> GetAllSuppliers()
        {
            using (var db = new LiteDatabase(Config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Supplier>("supplier");
                var supplier = col.FindAll();
                return supplier;
            }
        }
    }
}

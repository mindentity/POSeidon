using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LiteDB;
using IniParser;
using IniParser.Model;
using System.Windows.Forms;

namespace POSeidon
{
    public static class DBUtils
    {
        public const string configFile = @"config.ini";
        public static IniData config;

        static DBUtils()
        {
            try
            {
                var parser = new FileIniDataParser();
                config = parser.ReadFile(configFile);
            }
            catch
            {
                MessageBox.Show(String.Format("Failed to read {0}!", configFile), "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            if (!File.Exists(config["Database"]["FilePath"]))
            {
                InitDB();
            }
        }

        private static void InitDB()
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                var adminUser = new User
                {
                    FirstName = config["Default"]["FirstName"],
                    LastName = config["Default"]["LastName"],
                    Username = config["Default"]["Username"],
                    Password = config["Default"]["Password"],
                };
                col.Insert(adminUser);
            }
                
        }

        public static void Auth(string username, string password)
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username");
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
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username");
                var result = col.FindOne(Query.EQ("Username", user.Username));
                if (result != null)
                {
                    return false;
                }
                col.Insert(user);
                return true;
            }
        }

        public static bool DeleteUser(User user)
        {
            return DeleteUserById(user.Id);
        }

        public static bool DeleteUserById(int id)
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                int deletedRows = col.Delete(Query.EQ("_id", id));
                return deletedRows > 0;
            }
        }

        public static bool DeleteUserByUsername(string username)
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username");
                int deletedRows = col.Delete(Query.EQ("Username", username));
                return deletedRows > 0;
            }
        }

        public static bool ChangePassword(string username, string newPassword)
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username");
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
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                return col.Update(user);
            }
        }

        public static User GetUserById(int id)
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                var user = col.FindOne(Query.EQ("_id", id));
                return user;
            }
        }

        public static User GetUserByUsername(string username)
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username");
                var user = col.FindOne(Query.EQ("Username", username));
                return user;
            }
        }

        public static IEnumerable<User> GetAllUsers()
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<User>("user");
                var users = col.FindAll();
                return users;
            }
        }

        public static bool CreateProduct(Product product)
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                col.EnsureIndex("Name");
                var result = col.FindOne(Query.EQ("Name", product.Name));
                if (result != null)
                {
                    return false;
                }
                product.Id = 0;
                col.Insert(product);
                return true;
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
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                var product = col.FindOne(Query.EQ("_id", id));
                return product;
            }
        }

        public static Product GetProductByName(string name)
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                col.EnsureIndex("Name");
                var product = col.FindOne(Query.EQ("Name", name));
                return product;
            }
        }

        public static bool UpdateProduct(Product product)
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
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
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                int deletedRows = col.Delete(Query.EQ("_id", id));
                return deletedRows > 0;
            }
        }

        public static bool DeleteProductByName(string name)
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                col.EnsureIndex("Name");
                int deletedRows = col.Delete(Query.EQ("Name", name));
                return deletedRows > 0;
            }
        }

        public static IEnumerable<Product> GetAllProducts()
        {
            using (var db = new LiteDatabase(config["Database"]["FilePath"]))
            {
                var col = db.GetCollection<Product>("product");
                var products = col.FindAll();
                return products;
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LiteDB;

namespace POSeidon
{
    public static class DBUtils
    {
        private static string dbFileName = @"pos.db";

        static DBUtils()
        {
            if (!File.Exists(dbFileName))
            {
                InitDB();
            }
        }

        private static void InitDB()
        {
            using (var db = new LiteDatabase(dbFileName))
            {
                var col = db.GetCollection<User>("user");
                var adminUser = new User
                {
                    Username = "admin",
                    Password = "12345"
                };
                col.Insert(adminUser);
            }
                
        }

        public static bool Auth(string username, string password)
        {
            using (var db = new LiteDatabase(dbFileName))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username");
                var user = col.FindOne(Query.EQ("Username", username));
                if (user == null)
                {
                    return false;
                }
                return user.Password == password;
            }
        }

        public static bool CreateUser(string username, string password)
        {
            using (var db = new LiteDatabase(dbFileName))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username");
                var user = col.FindOne(Query.EQ("Username", username));
                if (user != null)
                {
                    return false;
                }
                user = new User
                {
                    Username = username,
                    Password = password
                };
                col.Insert(user);
                return true;
            }
        }

        public static bool CreateUser(User user)
        {
            using (var db = new LiteDatabase(dbFileName))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username");
                var result = col.FindOne(Query.EQ("Username", username));
                if (result != null)
                {
                    return false;
                }
                user.Id = 0;
                col.Insert(user);
                return true;
            }
        }

        public static bool DeleteUser(User user)
        {
            using (var db = new LiteDatabase(dbFileName))
            {
                var col = db.GetCollection<User>("user");
                int deletedRows = col.Delete(Query.EQ("Id", user.Id));
                return deletedRows > 0;
            }
        }

        public static bool DeleteUserById(int id)
        {
            using (var db = new LiteDatabase(dbFileName))
            {
                var col = db.GetCollection<User>("user");
                int deletedRows = col.Delete(Query.EQ("Id", id));
                return deletedRows > 0;
            }
        }

        public static bool DeleteUserByUsername(string username)
        {
            using (var db = new LiteDatabase(dbFileName))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username");
                int deletedRows = col.Delete(Query.EQ("Username", username));
                return deletedRows > 0;
            }
        }

        public static bool ChangePassword(string username, string newPassword)
        {
            using (var db = new LiteDatabase(dbFileName))
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
            using (var db = new LiteDatabase(dbFileName))
            {
                var col = db.GetCollection<User>("user");
                return col.Update(user);
            }
        }

        public static User GetUserById(int id)
        {
            using (var db = new LiteDatabase(dbFileName))
            {
                var col = db.GetCollection<User>("user");
                return col.FindOne(Query.EQ("Id", id));
            }
        }

        public static User GetUserByUsername(string username)
        {
            using (var db = new LiteDatabase(dbFileName))
            {
                var col = db.GetCollection<User>("user");
                col.EnsureIndex("Username");
                return col.FindOne(Query.EQ("Username", username));
            }
        }
    }
}

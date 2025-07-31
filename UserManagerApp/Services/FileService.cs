using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagerApp.Models;

namespace UserManagerApp.Services
{
    internal class FileService
    {
        private static readonly string path = "E:/User.txt"; 

        public static List<User> LoadUsers()
        {
            var users = new List<User>();

            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (var l in lines)
                {
                    users.Add(User.FromCsv(l));

                }
            }
            return users;

        }
        public static void SaveUser(List<User> users)
        {
            var lines = new List<string>();
            foreach ( var user in users)
            {
                lines.Add(user.ToString());
            }
            File.WriteAllLines(path, lines);
        }
        public static void AddUser(User newuser)
        {
            var users = LoadUsers();
            users.Add(newuser);
            SaveUser(users);
        }
        public static bool CheckEmai(string email)
        {
            var users = LoadUsers();
            return users.Any( u => u.Email == email);
        }

        public static int NextId()
        {
            var users = LoadUsers();
            return users.Any() ? users.Max(u => u.Id) +1 : 1;
        }
    }
}

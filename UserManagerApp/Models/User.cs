using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagerApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Id},{Name},{Email},{Password}";
        }

        public static User FromCsv(string csv)
        {
            var parts = csv.Split(',');
            return new User
            {
                Id = int.Parse(parts[0]),
                Name = parts[1],
                Email = parts[2],
                Password = parts[3]
            };
        }    
    }
}

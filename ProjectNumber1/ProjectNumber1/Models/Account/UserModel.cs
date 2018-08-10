using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectNumber1.Models.Account
{
    class UserModel
    {
        private static List<User> _user;
        static UserModel()
        {
            // stops for our Food and Fun park tour
            _user = new List<User>();
            _user.Add(new User
            {
                IdUser = 1,
                Name = "Rodrigo Geronimo",
                Email = "rodrigogeronimo@outlook.com",
                PhoneNumber = "(416) 887-4954",
                DateBirth = "07/06/1984",
                NumDevices = 3

            });

            _user.Add(new User
            {
                IdUser = 2,
                Name = "Ramin Lakin",
                Email = "rlakin@my.centennialcollege.ca",
                PhoneNumber = "(416) 278-6993",
                DateBirth = "01/01/1970",
                NumDevices = 5

            });

            _user.Add(new User
            {
                IdUser = 3,
                Name = "Fabio Ciconi",
                Email = "fabiociconi@gmail.com",
                PhoneNumber = "(416) 123-4567",
                DateBirth = "31/12/1980",
                NumDevices = 1

            });
        }

        public static User First()
        {
            var result = _user.ToList<User>();
            return result.First();
        }
        public static List<User> GetAllDevices()
        {
            var result = _user.ToList<User>();
            return result;
        }
        public static List<User> GetDevices(int count)
        {
            var result = _user.Take(count).ToList<User>();
            return result;
        }
        public static List<User> Devices
        {
            get
            {
                return _user;
            }
        }

    }

    public class User
    {
        public int IdUser { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DateBirth { get; set; }
        public double NumDevices { get; set; }
    }
}

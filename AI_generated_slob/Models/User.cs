using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_generated_slob.Models
{
    public enum UserTypes { Costumer, Moderator, Admin }
    public class User
    {
        private int UserID { get; set; }
        public UserTypes UserType { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address UAddress { get; set; }
        public string Password { get; set; }

        public User(int userID, UserTypes userType, string name, string email, string phone, Address uAddress, string password)
        {
            UserID = userID;
            UserType = userType;
            Name = name;
            Email = email;
            Phone = phone;
            UAddress = uAddress;
            Password = password;
        }
    }
}

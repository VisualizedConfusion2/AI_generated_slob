using AI_generated_slob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_generated_slob.Interface
{
    internal interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User? GetUser(int userID);
        void CreateUser(string name, string email, string phone, Address uAddress, string password);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}

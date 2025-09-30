using AI_generated_slob.Interface;
using AI_generated_slob.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AI_generated_slob.Service
{
    public class UserService : IUserService
    {
        readonly IUserRepository UserRepository;

        public void CreateUser(string name, string email, string phone, Address uAddress, string password )
        {
            try
            {
                User user = new(name, email, phone, uAddress, password);
                UserRepository.Add(user);
            }
            catch
            {
                Debug.WriteLine("Incorrect");
            }
            
            //throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public User? GetUser(int userID)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}

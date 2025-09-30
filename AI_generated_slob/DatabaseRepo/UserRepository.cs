using AI_generated_slob.Interface;
using AI_generated_slob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_generated_slob.DatabaseRepo
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users;
        public void Add(User user)
        {
            _users.Add(user);
        }
    }
}

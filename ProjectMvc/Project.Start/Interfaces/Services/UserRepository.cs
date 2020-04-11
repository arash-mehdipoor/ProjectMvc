using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Start.Interfaces;
using Project.Start.Models;
namespace Project.Start.Interfaces
{
  public class UserRepository : IUserRepository
    {
        
        public UserRepository()
        {

        }
        public IEnumerable<User> GetAllUser()
        {
            throw new NotImplementedException();
        }
    }
}

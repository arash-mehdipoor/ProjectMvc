using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Start.Models;

namespace Project.Start.Interfaces
{
   public interface IUserRepository
    {
        IEnumerable<User> GetAllUser();
    }
}

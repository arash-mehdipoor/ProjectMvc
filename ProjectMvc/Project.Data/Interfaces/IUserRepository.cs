using Project.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project.Data
{
   public interface IUserRepository:IDisposable
    {
        IEnumerable<User> GetAllUser();
        User FindUserId(int userId);
        bool AddUser(User user);
        bool Update(User user);
        bool Delete(User user);
        void save();
    }
}

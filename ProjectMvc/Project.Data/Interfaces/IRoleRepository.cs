using Project.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
   public interface IRoleRepository:IDisposable
    {
        IEnumerable<Role> GetAllRole();
    }
}

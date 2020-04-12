using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Data.Context;
using Project.Domin;

namespace Project.Data
{
   public class RoleRepository:IRoleRepository
    {
        private Pro_DBEntitis db;
        public RoleRepository(Pro_DBEntitis contex)
        {
            this.db = contex;
        }

        public IEnumerable<Role> GetAllRole()
        {
            return db.Roles;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domin;
namespace Project.Data.Context
{
   public class Pro_DBEntitis:DbContext
    {
        static Pro_DBEntitis()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Pro_DBEntitis, Migrations.Configuration>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}

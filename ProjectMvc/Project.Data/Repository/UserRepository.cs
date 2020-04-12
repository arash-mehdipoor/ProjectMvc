using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Domin;
using Project.Data.Context;
namespace Project.Data
{
    public class UserRepository : IUserRepository
    {
        private Pro_DBEntitis db;
        public UserRepository(Pro_DBEntitis context)
        {
            this.db = context;
        }

        public IEnumerable<User> GetAllUser()
        {
            return db.Users;
        }
        public User FindUserId(int userId)
        {
            return db.Users.Find(userId);
        }
        public bool Update(User user)
        {
            try
            {
                db.Entry(user).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool Delete(User user)
        {
            try
            {
                db.Entry(user).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public void save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}

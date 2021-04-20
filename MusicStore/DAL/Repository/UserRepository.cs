using DAL.Entity;
using IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        public UserRepository() { }


        public User GetById(int id)
        {
            using (var db = new MusicStoreContext())
            {
                return db.Users.Where(x => x.Id == id).FirstOrDefault();
            }
        }
    }
}

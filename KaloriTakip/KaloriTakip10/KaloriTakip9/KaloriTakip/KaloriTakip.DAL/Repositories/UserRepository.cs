using KaloriTakip.DAL.EntityConfigiration;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.DAL.Repositories
{
    public class UserRepository
    {
        CalorieDbContext _context;

        public UserRepository()
        {
            _context = new CalorieDbContext();
        }

        public bool Insert(User userNew)
        {
            _context.User.Add(userNew);
            return _context.SaveChanges() > 0;
        }

        public User CheckLogin(string username, string password)
        {
            User user = _context.User.Where(a => a.UserName == username).SingleOrDefault();
            if (user != null && user.Password==password)
            {
                return user;
            }
            return null;
        }

        public void DBActivate(int userID)
        {
            User activatedUser = _context.User.SingleOrDefault(a => a.UserID == userID);
            activatedUser.isActivate = true;
            _context.SaveChanges();
        }

        public bool UpdateUser(User user)
        {
          User changed= _context.User.Find(user.UserID);
            changed.Height = user.Height;
            changed.Weight = user.Weight;
            changed.BirthDate = user.BirthDate;
            changed.Password = user.Password;
            // changed = user; TODO: Hocaya sorulacak?
            return _context.SaveChanges() > 0;
        }

        public bool IsSameUser(string userName)
        {
            string userName2=_context.User.Where(x=>x.UserName == userName).Select(a=>a.UserName).SingleOrDefault();
            return string.IsNullOrEmpty(userName2);
        }
    }
}

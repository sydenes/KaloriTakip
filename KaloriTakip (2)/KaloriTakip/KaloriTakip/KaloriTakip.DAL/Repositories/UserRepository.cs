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

    }
}

using KaloriTakip.DAL.Repositories;
using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.BLL.Services
{
    public class UserService
    {
        UserRepository userRepository;
        public UserService()
        {
            userRepository = new UserRepository();
        }
        public bool Insert(User user)
        {
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password) || 
                string.IsNullOrEmpty(user.Height.ToString()) || 
                string.IsNullOrEmpty(user.Weight.ToString()) || string.IsNullOrEmpty(user.Activity) || string.IsNullOrEmpty(user.BirthDate.ToString()))
            {
                throw new Exception("Boş alan bırakılamaz");
            }
            user.CreatedTime = DateTime.Now;
            user.isActivate = false;
            return userRepository.Insert(user);
        }
    }
}

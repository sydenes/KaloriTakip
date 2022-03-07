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
                user.Height==0 || 
                user.Weight==0 || string.IsNullOrEmpty(user.Activity) || string.IsNullOrEmpty(user.BirthDate.ToString()))
            {
                throw new Exception("Boş alan bırakılamaz");
            }
            user.CreatedTime = DateTime.Now;
            user.isActivate = false;
            return userRepository.Insert(user);
        }
        public User CheckLogin(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Giriş bilgileri boş geçilemez.");
            }
            return userRepository.CheckLogin(username, password);
        }
        public void Activite(int userID)
        {
            userRepository.DBActivate(userID);
        }

    }
}

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
            if (user.UserName.Contains(" ") || user.Password.Contains(" "))
            {
                throw new Exception("Kullanıcı adı ve şifresi boşluk içeremez.");
            }
            if (user.BirthDate>=DateTime.Now.Date)
            {
                throw new Exception("Doğum tarihi ileri bir tarih olamaz.");
            }
            if (string.IsNullOrEmpty(user.UserName) || string.IsNullOrEmpty(user.Password) ||
                user.Height == 0 ||
                user.Weight == 0 || string.IsNullOrEmpty(user.Activity) || string.IsNullOrEmpty(user.BirthDate.ToString()))
            {
                throw new Exception("Boş alan bırakılamaz");
            }
            int totalCharacter = 0, totalLetterChar = 0, totalDigitChar = 0, totalSpecialChar = 0;
            foreach (var item in user.Password.ToCharArray())
            {
                if (char.IsDigit(item))
                    totalDigitChar++;
                if (char.IsLetter(item))
                    totalLetterChar++;
                if (!char.IsLetterOrDigit(item))
                    totalSpecialChar++;
                totalCharacter++;
            }
            if (totalCharacter < 7 || totalDigitChar == 0 || totalLetterChar == 0 || totalSpecialChar == 0)
            {
                if(totalCharacter<7)
                    throw new Exception("Şifreniz en az 8 karakterli olmalı");
                if(totalDigitChar==0)
                    throw new Exception("Şifreniz en az 1 sayı içermeli");
                if(totalLetterChar==0)
                    throw new Exception("Şifreniz en az 1 harf olmalı");
                if(totalSpecialChar==0)
                    throw new Exception("Şifreniz en az 1 özel karekter olmalı");
            }
            if (!IsSameUser(user.UserName))
            {
                throw new Exception("Aynu isimde kullanıcı vardır");
            }
            if (user.UserName.Substring(user.UserName.Length - 4) != ".com" || !user.UserName.Contains("@") )

            {
                throw new Exception("Lütfen geçerli bir mail adresi giriniz");
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

        public bool UpdateUser(User user)
        {
            return userRepository.UpdateUser(user);
        }
        public bool IsSameUser(string userName) 
        {
            return userRepository.IsSameUser(userName);
        }
    }
}

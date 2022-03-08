using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.Model.Entities
{
    public class User
    {
        public User()
        {
            MealEntries=new HashSet<MealEntry>();
        }
        public int UserID { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedTime { get; set; }
        public decimal Height{ get; set; }
        public decimal Weight { get; set; }
        public string Activity { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool isActivate { get; set; }
        public virtual ICollection<MealEntry> MealEntries { get; set; }
    }
}

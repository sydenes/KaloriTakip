using KaloriTakip.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakip.DAL.EntityConfigiration
{
    public class UserConfigiration: EntityTypeConfiguration<User>
    {
        public UserConfigiration()
        {
            Property(a => a.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Height)
                .IsRequired();
            Property(a => a.Weight)
                .IsRequired();
            Property(a => a.Gender)
                .IsRequired();
            Property(a => a.BirthDate)
                .IsRequired();
            Property(a => a.Activity)
                .IsRequired();
            Property(a => a.UserName)
                .IsRequired();
            Property(a => a.Password)
                .IsRequired();

        }
    }
}

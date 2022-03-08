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
    class FoodConfigiration: EntityTypeConfiguration<Food>
        
    {
        public FoodConfigiration()
        {
            Property(a => a.FoodID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.FoodName)
                .IsRequired();
            Property(a => a.CalorieForService)
                .IsRequired();
            Property(a => a.Protein)
                .IsRequired();
            Property(a => a.Service)
                .IsRequired();
            Property(a => a.Fat)
                .IsRequired();
            Property(a => a.Carbonhydrates)
                .IsRequired();
        }
    }
}

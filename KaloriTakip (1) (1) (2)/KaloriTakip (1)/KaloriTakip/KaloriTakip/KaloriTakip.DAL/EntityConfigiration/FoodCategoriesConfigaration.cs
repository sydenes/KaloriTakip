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
    class FoodCategoriesConfigaration: EntityTypeConfiguration<FoodCategories>
    {
        public FoodCategoriesConfigaration()
        {
            Property(a => a.FoodCategoriesID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.CategoryName)
                .IsRequired();

        }
    }
}

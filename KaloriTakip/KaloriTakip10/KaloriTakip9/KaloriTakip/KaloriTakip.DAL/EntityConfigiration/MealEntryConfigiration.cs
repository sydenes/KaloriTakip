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
    class MealEntryConfigiration: EntityTypeConfiguration<MealEntry>
    {
        public MealEntryConfigiration()
        {
            Property(a => a.MealEntryID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.EntryDate)
                .IsRequired().HasColumnType("date");
            Property(a => a.UpdateDate)
                .IsRequired();
                
        }
    }
}

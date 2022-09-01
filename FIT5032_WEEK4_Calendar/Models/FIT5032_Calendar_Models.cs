using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace FIT5032_WEEK4_Calendar.Models
{
    public partial class FIT5032_Calendar_Models : DbContext
    {
        public FIT5032_Calendar_Models()
            : base("name=FIT5032_Calendar_Models")
        {
        }

        public virtual DbSet<Event> Events { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(e => e.Title)
                .IsUnicode(false);
        }
    }
}

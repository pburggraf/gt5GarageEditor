using System.Data.Entity;

namespace GT5SaveGameLibrary.GT5SqlModel.EarlyVersion
{
    public partial class Gt5Model : DbContext
    {
        public Gt5Model()
            : base("name=Gt5Model")
        {
        }

        public virtual DbSet<t_cars> t_cars { get; set; }
        public virtual DbSet<t_colour> t_colour { get; set; }
        public virtual DbSet<t_garage> t_garage { get; set; }
        public virtual DbSet<t_tuner> t_tuner { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<t_tuner>()
                .Property(e => e.tuner)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<t_tuner>()
                .Property(e => e.tuner_long)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}

namespace EStore
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MainModel : DbContext
    {
        public MainModel()
            : base("name=MainModel")
        {
        }

        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<StockCharge> StockCharge { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Cashbox> Cashbox { get; set; }
        public virtual DbSet<StockQuantities> StockQuantities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.category_name)
                .IsUnicode(false);

            modelBuilder.Entity<History>()
                .Property(e => e.product_name)
                .IsUnicode(false);

            modelBuilder.Entity<History>()
                .Property(e => e.quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Manufacturers>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.product_name)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.measuring_unit)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.price_charge)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Products>()
                .Property(e => e.price_sell)
                .HasPrecision(18, 2);

            modelBuilder.Entity<StockCharge>()
                .Property(e => e.quantity)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Users>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<Cashbox>()
                .Property(e => e.amount_before)
                .HasPrecision(18, 2);

            modelBuilder.Entity<Cashbox>()
                .Property(e => e.amount_after)
                .HasPrecision(18, 2);

            modelBuilder.Entity<StockQuantities>()
                .Property(e => e.quantity)
                .HasPrecision(18, 0);
            
        }
    }
}

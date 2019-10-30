using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApp.Models
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<AvatarUser> AvatarUser { get; set; }
        public DbSet<BannedUser> BannedUsers { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Goods> Goods { get; set; }
        public DbSet<SelectedProd> selectedProds { get; set; }
        public DbSet<AllDescript> allDescripts { get; set; }
        public DbSet<longDesc> LongDescs { get; set; }
        public DbSet<shortDesc> shortDescs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryPhoto> categoryPhotos { get; set; }
        public DbSet<Discounts> Discounts { get; set; }
        public DbSet<GoodsPhotos> GoodsPhotos { get; set; }
        public DbSet<ShopCartItem> shopCartItems { get; set; }
        public DbSet<OrderNoRegister> orderNoRegisters { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()             
                .HasOne(u => u.avatar)
                .WithOne(p => p.User)
                .HasForeignKey<AvatarUser>(p => p.user_id);      

            modelBuilder
                .Entity<User>()
                .HasOne(u => u.bannedUser)
                .WithOne(p => p.User)
                .HasForeignKey<BannedUser>(p => p.user_id);

            modelBuilder
                .Entity<Comments>()
                .HasOne(p => p.User)
                .WithMany(t => t.Comments)
                .HasForeignKey(p => p.id_user);

            modelBuilder
                .Entity<Comments>()
                .HasOne(p => p.Goods)
                .WithMany(t => t.UsersComment)
                .HasForeignKey(p => p.id_goods);

            modelBuilder
                .Entity<SelectedProd>()
                .HasOne(p => p.Goods)
                .WithMany(t => t.selectedProds)
                .HasForeignKey(p => p.id_goods);

            modelBuilder
                .Entity<SelectedProd>()
                .HasOne(p => p.User)
                .WithMany(t => t.selectedProds)
                .HasForeignKey(p => p.id_user);

            modelBuilder
                .Entity<Goods>()
                .HasOne(p => p.AllDescript)
                .WithMany(t => t.Goods)
                .HasForeignKey(p => p.id_allDesc);

            modelBuilder
                .Entity<AllDescript>()
                .HasOne(p => p.longDesc)
                .WithMany(t => t.allDescripts)
                .HasForeignKey(p => p.id_longDesc);

            modelBuilder
                .Entity<AllDescript>()
                .HasOne(p => p.shortDesc)
                .WithMany(t => t.allDescripts)
                .HasForeignKey(p => p.id_shortDesc);

            modelBuilder
                .Entity<Goods>()
                .HasOne(p => p.Category)
                .WithMany(t => t.Goods)
                .HasForeignKey(p => p.id_category);

            modelBuilder
                .Entity<Category>()
                .HasOne(p => p.CategoryPhoto)
                .WithMany(t => t.Categories)
                .HasForeignKey(p => p.id_photo);

            modelBuilder
                .Entity<Goods>()
                .HasOne(p => p.Discounts)
                .WithMany(t => t.Goods)
                .HasForeignKey(p => p.id_discount);

            modelBuilder
                .Entity<Goods>()
                .HasOne(p => p.GoodsPhotos)
                .WithMany(t => t.Goods)
                .HasForeignKey(p => p.id_img);
        }
    }
}

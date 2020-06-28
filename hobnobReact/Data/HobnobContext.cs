using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using hobnobReact.Models;


namespace hobnobReact.Data
{
    public class HobnobContext : DbContext
    {
        public HobnobContext(DbContextOptions<HobnobContext> opt):base(opt)
        {

        }
        public  DbSet<Menu> Menus { get; set; }
        public  DbSet<Menutype> Menutypes { get; set; }
        public  DbSet<Orderdetail> Orderdetails { get; set; }
        public  DbSet<Order> Orders { get; set; }
        public  DbSet<Restaurant> Restaurants { get; set; }
        public  DbSet<User> Users { get; set; }
    }
}
    //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //     {
    //         if (!optionsBuilder.IsConfigured)
    //         {
    //             optionsBuilder.UseMySql("server=localhost;database=samplegoodtogo_db;user=root;password=@Abdu5300;");
    //         }
    //     }

    //     protected override void OnModelCreating(ModelBuilder modelBuilder)
    //     {
    //         modelBuilder.Entity<Menus>(entity =>
    //         {
    //             entity.ToTable("menus");

    //             entity.HasIndex(e => e.MenuTypeId)
    //                 .HasName("MenuTypeId");

    //             entity.HasIndex(e => e.RestaurantId)
    //                 .HasName("RestaurantId");

    //             entity.Property(e => e.Id).HasColumnName("id");

    //             entity.Property(e => e.CreatedAt)
    //                 .HasColumnName("createdAt")
    //                 .HasColumnType("datetime");

    //             entity.Property(e => e.Description)
    //                 .IsRequired()
    //                 .HasColumnName("description")
    //                 .HasColumnType("text");

    //             entity.Property(e => e.Name)
    //                 .IsRequired()
    //                 .HasColumnName("name")
    //                 .HasMaxLength(255);

    //             entity.Property(e => e.Price)
    //                 .HasColumnName("price")
    //                 .HasColumnType("decimal(10,0)");

    //             entity.Property(e => e.UpdatedAt)
    //                 .HasColumnName("updatedAt")
    //                 .HasColumnType("datetime");

    //             entity.HasOne(d => d.MenuType)
    //                 .WithMany(p => p.Menus)
    //                 .HasForeignKey(d => d.MenuTypeId)
    //                 .OnDelete(DeleteBehavior.Cascade)
    //                 .HasConstraintName("menus_ibfk_1");

    //             entity.HasOne(d => d.Restaurant)
    //                 .WithMany(p => p.Menus)
    //                 .HasForeignKey(d => d.RestaurantId)
    //                 .OnDelete(DeleteBehavior.Cascade)
    //                 .HasConstraintName("menus_ibfk_2");
    //         });

    //         modelBuilder.Entity<Menutypes>(entity =>
    //         {
    //             entity.ToTable("menutypes");

    //             entity.Property(e => e.Id).HasColumnName("id");

    //             entity.Property(e => e.CreatedAt)
    //                 .HasColumnName("createdAt")
    //                 .HasColumnType("datetime");

    //             entity.Property(e => e.Typename)
    //                 .IsRequired()
    //                 .HasColumnName("typename")
    //                 .HasMaxLength(255);

    //             entity.Property(e => e.UpdatedAt)
    //                 .HasColumnName("updatedAt")
    //                 .HasColumnType("datetime");
    //         });

    //         modelBuilder.Entity<Orderdetails>(entity =>
    //         {
    //             entity.ToTable("orderdetails");

    //             entity.HasIndex(e => e.MenuId)
    //                 .HasName("MenuId");

    //             entity.HasIndex(e => e.OrderId)
    //                 .HasName("OrderId");

    //             entity.Property(e => e.Id).HasColumnName("id");

    //             entity.Property(e => e.CreatedAt)
    //                 .HasColumnName("createdAt")
    //                 .HasColumnType("datetime");

    //             entity.Property(e => e.Quantity).HasColumnName("quantity");

    //             entity.Property(e => e.UpdatedAt)
    //                 .HasColumnName("updatedAt")
    //                 .HasColumnType("datetime");

    //             entity.HasOne(d => d.Menu)
    //                 .WithMany(p => p.Orderdetails)
    //                 .HasForeignKey(d => d.MenuId)
    //                 .OnDelete(DeleteBehavior.Cascade)
    //                 .HasConstraintName("orderdetails_ibfk_1");

    //             entity.HasOne(d => d.Order)
    //                 .WithMany(p => p.Orderdetails)
    //                 .HasForeignKey(d => d.OrderId)
    //                 .OnDelete(DeleteBehavior.Cascade)
    //                 .HasConstraintName("orderdetails_ibfk_2");
    //         });

    //         modelBuilder.Entity<Orders>(entity =>
    //         {
    //             entity.ToTable("orders");

    //             entity.HasIndex(e => e.UserId)
    //                 .HasName("UserId");

    //             entity.Property(e => e.Id).HasColumnName("id");

    //             entity.Property(e => e.CreatedAt)
    //                 .HasColumnName("createdAt")
    //                 .HasColumnType("datetime");

    //             entity.Property(e => e.UpdatedAt)
    //                 .HasColumnName("updatedAt")
    //                 .HasColumnType("datetime");

    //             entity.HasOne(d => d.User)
    //                 .WithMany(p => p.Orders)
    //                 .HasForeignKey(d => d.UserId)
    //                 .OnDelete(DeleteBehavior.Cascade)
    //                 .HasConstraintName("orders_ibfk_1");
    //         });

    //         modelBuilder.Entity<Restaurants>(entity =>
    //         {
    //             entity.ToTable("restaurants");

    //             entity.Property(e => e.Id).HasColumnName("id");

    //             entity.Property(e => e.City)
    //                 .IsRequired()
    //                 .HasColumnName("city")
    //                 .HasMaxLength(255);

    //             entity.Property(e => e.CreatedAt)
    //                 .HasColumnName("createdAt")
    //                 .HasColumnType("datetime");

    //             entity.Property(e => e.Phone)
    //                 .IsRequired()
    //                 .HasColumnName("phone")
    //                 .HasMaxLength(255);

    //             entity.Property(e => e.RestaurantName)
    //                 .IsRequired()
    //                 .HasColumnName("restaurant_name")
    //                 .HasMaxLength(255);

    //             entity.Property(e => e.Street)
    //                 .IsRequired()
    //                 .HasColumnName("street")
    //                 .HasMaxLength(255);

    //             entity.Property(e => e.UpdatedAt)
    //                 .HasColumnName("updatedAt")
    //                 .HasColumnType("datetime");

    //             entity.Property(e => e.Zipcode).HasColumnName("zipcode");
    //         });

    //         modelBuilder.Entity<Users>(entity =>
    //         {
    //             entity.ToTable("users");

    //             entity.HasIndex(e => e.Email)
    //                 .HasName("email")
    //                 .IsUnique();

    //             entity.Property(e => e.Id).HasColumnName("id");

    //             entity.Property(e => e.CreatedAt)
    //                 .HasColumnName("createdAt")
    //                 .HasColumnType("datetime");

    //             entity.Property(e => e.Email)
    //                 .IsRequired()
    //                 .HasColumnName("email")
    //                 .HasMaxLength(255);

    //             entity.Property(e => e.Password)
    //                 .IsRequired()
    //                 .HasColumnName("password")
    //                 .HasMaxLength(255);

    //             entity.Property(e => e.UpdatedAt)
    //                 .HasColumnName("updatedAt")
    //                 .HasColumnType("datetime");
    //         });
    //     }
    // }


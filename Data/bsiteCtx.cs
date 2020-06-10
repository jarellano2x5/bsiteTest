using System;
using Microsoft.EntityFrameworkCore;
using bsiteTest.Models;

namespace bsiteTest.Data
{
    public class bsiteCtx : DbContext
    {
        public virtual DbSet<Costumer> Costumers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public bsiteCtx(DbContextOptions<bsiteCtx> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Costumer>(entity => {
                entity.HasKey(e => e.CostumerID);
                entity.Property(e => e.NameStyle).IsRequired()
                    .HasMaxLength(20).IsUnicode(false);
                entity.Property(e => e.Title).IsRequired()
                    .HasMaxLength(20).IsUnicode(false);
                entity.Property(e => e.FirstName).IsRequired()
                    .HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.MiddleName).IsRequired()
                    .HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.LastName).IsRequired()
                    .HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Suffix).IsRequired()
                    .HasMaxLength(5).IsUnicode(false);
                entity.Property(e => e.CompanyName).IsRequired()
                    .HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.SalesPerson).IsRequired()
                    .HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.EmailAddress).IsRequired()
                    .HasMaxLength(50).IsUnicode(false);
                entity.Property(e => e.Phone).IsRequired()
                    .HasMaxLength(20).IsUnicode(false);
                entity.Property(e => e.PasswordHash).IsRequired()
                    .HasMaxLength(12).IsUnicode(false);
                entity.Property(e => e.PasswordSalt).IsRequired()
                    .HasMaxLength(12).IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity => {
                entity.HasKey(e => e.ProductID);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(30).IsUnicode(false);
                entity.Property(e => e.ProductNumber).IsRequired().HasMaxLength(20).IsUnicode(false);
                entity.Property(e => e.Color).IsRequired().HasMaxLength(30).IsUnicode(false);
                entity.Property(e => e.ThumbNailPhotoFileName).IsRequired().HasMaxLength(80).IsUnicode(false);
            });
        }
    }
}
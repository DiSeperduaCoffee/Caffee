using System;
using Microsoft.EntityFrameworkCore;
using DiSeperduaCoffe.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DiSeperduaCoffee.Models;
using Microsoft.AspNetCore.Identity;

namespace DiSeperduaCoffee.Data

{
    public class DiSeperduaCoffeeDbContext : IdentityDbContext<Pengguna>
    {
        public DiSeperduaCoffeeDbContext (DbContextOptions<DiSeperduaCoffeeDbContext> options) : base(options)
        { }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Pembayaran> Pembayarans { get; set; }
        public DbSet<Pemesanan> Pemesanans { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(new [] {
                    new IdentityRole("Admin"),
                    new IdentityRole("User")
                });

            var hasher = new PasswordHasher<Pengguna>();
            var admin = new Pengguna
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Indri",
                UserName = "Indri@gmail.com",
                NormalizedUserName = "INDRI@GMAIL.COM",
                Email = "Indri@gmail.com",
                NormalizedEmail = "INDRI@GMAIL.COM",
                EmailConfirmed = true
            };
            admin.PasswordHash = hasher.HashPassword(admin, "Indri123#");
            builder.Entity<Pengguna>()
                .HasData(admin);
        }


    }
}

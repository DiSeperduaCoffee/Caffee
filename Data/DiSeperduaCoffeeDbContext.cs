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
    }
}
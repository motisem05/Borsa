using Borsa.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Borsa
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Data> Data { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Stocks> Stocks{ get; set; }
        public DbSet<StocksHistory> StocksHistory { get; set; }
        public DbSet<UserPasswords> UserPasswords { get; set; }
        public DbSet<Videos> Videos { get; set; }
        public DbSet<Posts> Posts { get; set; }

    }
}

﻿using FrontBackEShopers.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontBackEShopers.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

       public DbSet<Category> Categories { get; set; }
       public DbSet<Product> Products { get; set; }
    }
}

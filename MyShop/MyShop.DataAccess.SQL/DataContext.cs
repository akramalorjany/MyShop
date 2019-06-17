﻿using MyShop.Core.Models;
using System.Data.Entity;

namespace MyShop.DataAccess.SQL
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("MyConString")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
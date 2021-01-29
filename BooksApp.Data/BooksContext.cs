﻿using System;
using System.Collections.Generic;
using System.Text;
using BooksApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace BooksApp.Data
{
    
    public class BooksContext : DbContext 
    {
        private const string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BooksAppData";
        public DbSet<Author> Authors { get; set; } 
        public DbSet<Publisher> Publishers { get; set; } 
        public DbSet<Book> Books { get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}

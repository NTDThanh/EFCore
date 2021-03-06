﻿using System;
using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace EFCore.Data
{
    public class AddressContext : DbContext
    {
        public static readonly LoggerFactory MyConsoleLoggerFactory
          = new LoggerFactory(new[] {
              new ConsoleLoggerProvider((category, level)
                => category == DbLoggerCategory.Database.Command.Name
               && level == LogLevel.Information, true) });

        public DbSet<City> CityInfo { get; set; }
        public DbSet<County> Countys { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyConsoleLoggerFactory)
                .EnableSensitiveDataLogging(true)
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Data Source=192.168.6.235\SQLEXPRESS;Initial Catalog=EFCore; Persist Security Info=True;User ID=efcoreadmin;Password=efcorepass");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountyAddress>()
                .HasKey(s => new { s.CountyId, s.AddressNo });
            base.OnModelCreating(modelBuilder);
        }
    }
}

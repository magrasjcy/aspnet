using System;
using Microsoft.EntityFrameworkCore;
namespace com.pizzaZ.DataStore {
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {

        private readonly string _connectionString;

        public ApplicationDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // const string _backup = (@"Server=(localdb)\mssqllocaldb;Database=Test");
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}

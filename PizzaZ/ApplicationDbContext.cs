using Microsoft.EntityFrameworkCore;
using System;

namespace com.pizzaZ.DataStore {
    public class ApplicationDbContext: DbContext
	{

        private readonly string _connectionString;

        public ApplicationDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string _backup = (@"Server=(localdb)\mssqllocaldb;Database=Test");
            optionsBuilder.UseSqlServer(_connectionString);
        }

    }
}

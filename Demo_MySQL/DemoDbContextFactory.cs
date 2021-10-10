using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Data
{
    public class DemoDbContextFactory : IDesignTimeDbContextFactory<DemoDbContext>
    {
        public DemoDbContext CreateDbContext(string[] args)
        {
            var connectionString = "server=localhost;database=library;user=sa;password=12345678";
            var optionBuilder = new DbContextOptionsBuilder<DemoDbContext>();
            optionBuilder.UseMySQL(connectionString);
            return new DemoDbContext(optionBuilder.Options);

        }
    }
}

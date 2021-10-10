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
            var connectionString = "server=.;database=myDb;trusted_connection=true;";
            var optionBuilder = new DbContextOptionsBuilder<DemoDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new DemoDbContext(optionBuilder.Options);

        }
    }
}

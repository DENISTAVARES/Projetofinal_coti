﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Contexts
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DataContext>();
            builder.UseSqlServer(@"Data Source=SQL5059.site4now.net;Initial Catalog=DB_A627B3_denistavares;User Id=DB_A627B3_denistavares_admin;Password=4m3nd01N;");

            return new DataContext(builder.Options);
        }
    }
}

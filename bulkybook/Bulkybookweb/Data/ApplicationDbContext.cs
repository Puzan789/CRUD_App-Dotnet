using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Bulkybookweb.Models;
using Microsoft.EntityFrameworkCore;
namespace Bulkybookweb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ) :base(options)
        {
         
        }
        public DbSet<Category> Categories { get; set; }  //categories is called table name
    }
}

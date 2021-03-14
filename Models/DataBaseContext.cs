using Microsoft.EntityFrameworkCore;
using System;
namespace API_AJAX_Mvc.Models

{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

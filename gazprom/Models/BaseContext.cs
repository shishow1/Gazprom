using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gazprom.Models;

namespace gazprom.Models
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<FuelTank> FuelTanks { get; set; }
        public DbSet<Price> Prices { get; set; }
        public DbSet<IncomeAndExpense> IncomesAndExpenses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}

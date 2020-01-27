using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gazprom.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new BaseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BaseContext>>()))
            {
                if (!db.Fuels.Any())
                {
                    AddRoles(db);
                    AddUsers(db, 1, 15);
                    AddFuels(db, 100);
                    AddPrices(db, 10);
                    AddFuelTanks(db, 100);
                    AddIncomesAndExpenses(db, 100);
                }
            }
        }

        public static string GetRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void AddFuels(BaseContext db, int count)
        {
            for(int i = 0; i < count; i++)
            {
                db.Fuels.Add(new Fuel
                {
                    Name = GetRandomString(5),
                    Description = GetRandomString(15)
                });
            }

            db.SaveChanges();
        }

        public static void AddFuelTanks(BaseContext db, int count)
        {
            Random random = new Random();
            int fuelsCount = db.Fuels.Count();

            for(int i = 0; i < count; i++)
            {
                int size = random.Next(10, 3000);

                db.FuelTanks.Add(new FuelTank
                {
                    FuelId = random.Next(1, fuelsCount),
                    Size = size,
                    Value = random.Next(0, size)
                });
            }

            db.SaveChanges();
        }

        public static void AddPrices(BaseContext db, int countPerFuel)
        {
            DateTime date = DateTime.Now.Date;
            Random random = new Random();

            IEnumerable<Fuel> fuels = db.Fuels;

            foreach(var f in fuels)
            {
                List<Price> prices = new List<Price>();

                for(int i = 0; i < countPerFuel; i++)
                {
                    prices.Add(new Price
                    {
                        PricePerLiter = Math.Round(random.NextDouble() * (10 - 1) + 1, 2),
                        Date =  date.AddDays(-i).Date
                    });
                }

                f.Prices = prices;
                db.Fuels.Update(f);
            }

            db.SaveChanges();
        }

        public static void AddRoles(BaseContext db)
        {
            db.Roles.AddRange(new Role
            {
                Name = "admin"
            }, new Role
            {
                Name = "user"
            });

            db.SaveChanges();
        }

        public static void AddUsers(BaseContext db, int adminCount, int userCount)
        {
            Role adminRole = db.Roles.FirstOrDefault(r => r.Name == "admin");
            Role userRole = db.Roles.FirstOrDefault(r => r.Name == "user");

            if (adminRole != null && userRole != null)
            {
                for (int i = 0; i < adminCount; i++)
                {
                    db.Users.Add(new User
                    {
                        Login = $"admin_{i}",
                        Name = $"admin_{i}",
                        Email = $"admin_{i}@mail.ru",
                        Password = $"admin_{i}",
                        Post = "Начальник смены",
                        Role = adminRole
                    });
                }

                for (int i = 0; i < userCount; i++)
                {
                    db.Users.Add(new User
                    {
                        Login = $"user_{i}",
                        Name = $"user_{i}",
                        Email = $"user_{i}@mail.ru",
                        Password = $"user_{i}",
                        Post = "Оператор",
                        Role = userRole
                    });
                }

                db.SaveChanges();
            }
        }

        public static void AddIncomesAndExpenses(BaseContext db, int count)
        {
            Random random = new Random();
            List<User> users = db.Users.Include(r => r.Role).Where(u => u.Role.Name != "admin").ToList();
            List<FuelTank> fuelTanks = db.FuelTanks.ToList();

            if (users.Count() > 0 && fuelTanks.Count() > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    db.IncomesAndExpenses.Add(new IncomeAndExpense
                    {
                        Date = DateTime.Now.AddDays(-i).Date,
                        FuelTank = fuelTanks[random.Next(0, fuelTanks.Count() - 1)],
                        Value = random.Next(-100, 100),
                        User = users[random.Next(0, users.Count() - 1)]
                    });
                }

                db.SaveChanges();
            }
        }
    }
}

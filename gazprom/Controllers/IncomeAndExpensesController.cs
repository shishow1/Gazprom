using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using gazprom.Models;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Authorization;

namespace gazprom.Controllers
{
    public class IncomeAndExpensesController : Controller
    {
        private readonly BaseContext db;

        public IncomeAndExpensesController(BaseContext context)
        {
            db = context;
        }

        // GET: IncomeAndExpenses
        [Authorize]
        public IActionResult Index(string sort, Filter filter, int page = 1)
        {
            IQueryable<IncomeAndExpense> incomeAndExpenses = db.IncomesAndExpenses
                .Include(f => f.FuelTank)
                .Include(u => u.User);
            int pageSize = 10;

            ViewBag.Filters = new SelectList(new List<SelectListItem>
            {
                new SelectListItem("Код", "Id"),
                new SelectListItem("Значение", "Value"),
                new SelectListItem("Дата", "Date"),
                new SelectListItem("Емкость", "FuelTankId"),
            }, "Value", "Text", filter.Field);

            if (incomeAndExpenses.Count() > 0)
            {
                if (!string.IsNullOrEmpty(filter.Field)
                    && !string.IsNullOrEmpty(filter.Value)
                    && incomeAndExpenses.First().GetType().GetProperty(filter.Field) != null)
                {
                    //TODO: Child property not work
                    incomeAndExpenses = incomeAndExpenses.Where(filter.Field + ".ToString().Contains(@0)", filter.Value);
                }

                if (!string.IsNullOrEmpty(sort))
                {
                    try
                    {
                        incomeAndExpenses = incomeAndExpenses.OrderBy(sort);
                    }
                    catch
                    {
                        sort = "Id";
                        incomeAndExpenses = incomeAndExpenses.OrderBy(sort);
                    }
                }
            }
            
            int pageCount = incomeAndExpenses.Count();
            incomeAndExpenses = incomeAndExpenses.Skip((page - 1) * pageSize).Take(pageSize);

            Page<IncomeAndExpense> pageModel = new Page<IncomeAndExpense>
            {
                Filter = filter,
                Sort = sort,
                Pagination = new Pagination(pageCount, page, pageSize),
                Items = incomeAndExpenses.ToList()
            };

            return View(pageModel);
        }

        // GET: IncomeAndExpenses/Details/5
        [Authorize]
        public IActionResult Details(int id)
        {
            IncomeAndExpense incomeAndExpense = db.IncomesAndExpenses
                .Include(f => f.FuelTank)
                .Include(u => u.User)
                .FirstOrDefault(m => m.Id == id);

            if (incomeAndExpense != null)
            {
                return View(incomeAndExpense);
            }

            return NotFound();
        }

        // GET: IncomeAndExpenses/Create
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            ViewBag.FuelTanks = new SelectList(db.FuelTanks, "Id", "Id");
            ViewBag.Users = new SelectList(db.Users, "Id", "Login");

            return View();
        }

        // POST: IncomeAndExpenses/Create
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IncomeAndExpense incomeAndExpense)
        {
            if (ModelState.IsValid)
            {
                ViewBag.FuelTanks = new SelectList(db.FuelTanks, "Id", "Id", incomeAndExpense.FuelTankId);
                ViewBag.Users = new SelectList(db.Users, "Id", "Login");

                try
                {
                db.Add(incomeAndExpense);
                db.SaveChanges();
                }
                catch
                {
                    return View(incomeAndExpense);
                }

                return RedirectToAction(nameof(Index));
            }

            return View(incomeAndExpense);
        }

        // GET: IncomeAndExpenses/Edit/5
        [Authorize(Roles = "admin")]
        public IActionResult Edit(int id)
        {
            IncomeAndExpense incomeAndExpense = db.IncomesAndExpenses.FirstOrDefault(f => f.Id == id);

            if (incomeAndExpense == null)
            {
                return NotFound();
            }

            ViewBag.FuelTanks = new SelectList(db.FuelTanks, "Id", "Id", incomeAndExpense.FuelTankId);
            ViewBag.Users = new SelectList(db.Users, "Id", "Login");

            return View(incomeAndExpense);
        }

        // POST: IncomeAndExpenses/Edit/5
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(IncomeAndExpense incomeAndExpense)
        {

            if (ModelState.IsValid)
            {
                ViewBag.FuelTanks = new SelectList(db.FuelTanks, "Id", "Id", incomeAndExpense.FuelTankId);
                ViewBag.Users = new SelectList(db.Users, "Id", "Login");

                try
                {
                    db.IncomesAndExpenses.Update(incomeAndExpense);
                    db.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(incomeAndExpense);
                }
            }

            return View(incomeAndExpense);
        }



        // GET: IncomeAndExpenses/Delete/5
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            IncomeAndExpense incomeAndExpense = db.IncomesAndExpenses
                .Include(f => f.FuelTank)
                .Include(u => u.User)
                .FirstOrDefault(m => m.Id == id);

            if (incomeAndExpense != null)
            {
                return View(incomeAndExpense);
            }

            return NotFound();
        }

        // POST: IncomeAndExpenses/Delete/5
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(IncomeAndExpense incomeAndExpense)
        {
            try
            {
                db.IncomesAndExpenses.Remove(incomeAndExpense);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(incomeAndExpense);
            }
        }

        // GET: IncomeAndExpenses
        [Authorize]
        public IActionResult Period(string sort, Filter filter, string startDate, string endDate, int? userId, int page = 1)
        {
            IQueryable<IncomeAndExpense> incomeAndExpenses = db.IncomesAndExpenses
                .Include(f => f.FuelTank)
                .Include(u => u.User);

            if (userId != null)
            {
                incomeAndExpenses = incomeAndExpenses.Where(i => i.UserId == userId);
            }

            if (!string.IsNullOrEmpty(startDate))
            {
                incomeAndExpenses = incomeAndExpenses.Where(i => i.Date >= DateTime.Parse(startDate));
            }

            if(!string.IsNullOrEmpty(endDate))
            {
                incomeAndExpenses = incomeAndExpenses.Where(i => i.Date <= DateTime.Parse(endDate));
            }

            int pageSize = 10;

            ViewBag.Users = new SelectList(db.Users, "Id", "Login", userId);
            ViewBag.UserId = userId;
            ViewBag.StartDate = startDate;
            ViewBag.EndDate = endDate;
            ViewBag.Filters = new SelectList(new List<SelectListItem>
            {
                new SelectListItem("Код", "Id"),
                new SelectListItem("Значение", "Value"),
                new SelectListItem("Дата", "Date"),
                new SelectListItem("Емкость", "FuelTankId"),
            }, "Value", "Text", filter.Field);

            if (incomeAndExpenses.Count() > 0)
            {
                if (!string.IsNullOrEmpty(filter.Field)
                    && !string.IsNullOrEmpty(filter.Value)
                    && incomeAndExpenses.First().GetType().GetProperty(filter.Field) != null)
                {
                    //TODO: Child property not work
                    incomeAndExpenses = incomeAndExpenses.Where(filter.Field + ".ToString().Contains(@0)", filter.Value);
                }

                if (!string.IsNullOrEmpty(sort))
                {
                    try
                    {
                        incomeAndExpenses = incomeAndExpenses.OrderBy(sort);
                    }
                    catch
                    {
                        sort = "Id";
                        incomeAndExpenses = incomeAndExpenses.OrderBy(sort);
                    }
                }
            }

            int pageCount = incomeAndExpenses.Count();
            incomeAndExpenses = incomeAndExpenses.Skip((page - 1) * pageSize).Take(pageSize);

            Page<IncomeAndExpense> pageModel = new Page<IncomeAndExpense>
            {
                Filter = filter,
                Sort = sort,
                Pagination = new Pagination(pageCount, page, pageSize),
                Items = incomeAndExpenses.ToList()
            };

            return View(pageModel);
        }

        // GET: IncomeAndExpenses/GetByDate
        [Authorize]
        [HttpGet("IncomeAndExpenses/GetByDate")]
        public JsonResult GetFuelTanksByFuelId(string startDate, string endDate)
        {
            List<IncomeAndExpense> incomeAndExpenses = db.IncomesAndExpenses.OrderBy(i => i.Date).ToList();

            if (!string.IsNullOrEmpty(startDate))
            {
                incomeAndExpenses = incomeAndExpenses.Where(i => i.Date >= DateTime.Parse(startDate)).ToList();
            }

            if (!string.IsNullOrEmpty(endDate))
            {
                incomeAndExpenses = incomeAndExpenses.Where(i => i.Date <= DateTime.Parse(endDate)).ToList();
            }

            return Json(new JsonModel { Data = incomeAndExpenses, Success = true });
        }
    }
}

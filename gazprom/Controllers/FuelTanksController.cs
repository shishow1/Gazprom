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
    public class FuelTanksController : Controller
    {
        private readonly BaseContext db;

        public FuelTanksController(BaseContext context)
        {
            db = context;
        }

        // GET: FuelTanks
        [Authorize]
        public IActionResult Index(string sort, Filter filter, int page = 1)
        {
            IQueryable<FuelTank> fuelTanks = db.FuelTanks.Include(f => f.Fuel);
            int pageSize = 10;

            ViewBag.Filters = new SelectList(new List<SelectListItem>
            {
                new SelectListItem("Код", "Id"),
                new SelectListItem("Объем", "Size"),
                new SelectListItem("Значение", "Value"),
                new SelectListItem("Тип ГСМ", "Fuel.Name")
            }, "Value", "Text", filter.Field);

            if (fuelTanks.Count() > 0)
            {
                if (!string.IsNullOrEmpty(filter.Field)
                    && !string.IsNullOrEmpty(filter.Value)
                    && fuelTanks.First().GetType().GetProperty(filter.Field) != null)
                {
                    fuelTanks = fuelTanks.Where(filter.Field + ".ToString().Contains(@0)", filter.Value);
                }

                if (!string.IsNullOrEmpty(sort))
                {
                    try
                    {
                        fuelTanks = fuelTanks.OrderBy(sort);
                    }
                    catch
                    {
                        sort = "Id";
                        fuelTanks = fuelTanks.OrderBy(sort);
                    }
                }
            }
            
            int pageCount = fuelTanks.Count();
            fuelTanks = fuelTanks.Skip((page - 1) * pageSize).Take(pageSize);

            Page<FuelTank> pageModel = new Page<FuelTank>
            {
                Filter = filter,
                Sort = sort,
                Pagination = new Pagination(pageCount, page, pageSize),
                Items = fuelTanks.ToList()
            };

            return View(pageModel);
        }

        // GET: FuelTanks/Details/5
        [Authorize]
        public IActionResult Details(int id)
        {
            FuelTank fuelTank = db.FuelTanks
                .Include(f => f.Fuel)
                .FirstOrDefault(m => m.Id == id);

            if (fuelTank != null)
            {
                return View(fuelTank);
            }

            return NotFound();
        }

        // GET: FuelTanks/Create
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            ViewBag.Fuels = new SelectList(db.Fuels, "Id", "Name");

            return View();
        }

        // POST: FuelTanks/Create
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FuelTank fuelTank)
        {
            ViewBag.Fuels = new SelectList(db.Fuels, "Id", "Name", fuelTank.FuelId);

            if (ModelState.IsValid)
            {
                try
                {
                    db.Add(fuelTank);
                    db.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(fuelTank);
                }
                
            }

            return View(fuelTank);
        }

        // GET: FuelTanks/Edit/5
        [Authorize(Roles = "admin")]
        public IActionResult Edit(int id)
        {
            FuelTank fuelTank = db.FuelTanks.FirstOrDefault(f => f.Id == id);

            //TOD: add checking when edit fuelTank's type
            ViewBag.FuelId = fuelTank.FuelId;

            if (fuelTank != null)
            {
                ViewBag.Fuels = new SelectList(db.Fuels, "Id", "Name", fuelTank.FuelId);

                return View(fuelTank);
            }

            return NotFound();
        }

        // POST: FuelTanks/Edit/5
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FuelTank fuelTank, int fuelId)
        {
            ViewBag.Fuels = new SelectList(db.Fuels, "Id", "Name", fuelTank.FuelId);

            if(fuelId != fuelTank.FuelId && fuelTank.Value != 0)
            {
                ModelState.AddModelError("FuelId", "Невозможно изменить тип ГСМ, емкость должна быть пустой");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    db.FuelTanks.Update(fuelTank);
                    db.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(fuelTank);
                }
            }

            return View(fuelTank);
        }

        // GET: FuelTanks/Delete/5
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {

            FuelTank fuelTank = db.FuelTanks
                .Include(f => f.Fuel)
                .FirstOrDefault(m => m.Id == id);

            if (fuelTank != null)
            {
                return View(fuelTank);
            }

            return NotFound();
        }

        // POST: FuelTanks/Delete/5
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(FuelTank fuelTank)
        {
            try
            {
                db.FuelTanks.Remove(fuelTank);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(fuelTank);
            }
        }
    }
}

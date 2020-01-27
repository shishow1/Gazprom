using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using gazprom.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace gazprom.Controllers
{
    public class FuelsController : Controller
    {
        private BaseContext db;

        public FuelsController(BaseContext context)
        {
            db = context;
        }

        // GET: Fuels
        [Authorize]
        public ActionResult Index(string sort, Filter filter, int page = 1)
        {
            IQueryable<Fuel> fuels = db.Fuels;
            int pageSize = 10;

            ViewBag.Filters = new SelectList(new List<SelectListItem>
            {
                new SelectListItem("Код", "Id"),
                new SelectListItem("Тип", "Name"),
                new SelectListItem("Характеристика", "Description")
            }, "Value", "Text", filter.Field);

            if (fuels.Count() > 0)
            {
                if (!string.IsNullOrEmpty(filter.Field) 
                    && !string.IsNullOrEmpty(filter.Value)
                    && fuels.First().GetType().GetProperty(filter.Field) != null)
                {
                    fuels = fuels.Where(filter.Field + ".ToString().Contains(@0)", filter.Value);
                }

                if (!string.IsNullOrEmpty(sort))
                {
                    try
                    {
                        fuels = fuels.OrderBy(sort);
                    }
                    catch
                    {
                        sort = "Id";
                        fuels = fuels.OrderBy(sort);
                    }
                }
            }
            
            int pageCount = fuels.Count();
            fuels = fuels.Skip((page - 1) * pageSize).Take(pageSize);

            Page<Fuel> pageModel = new Page<Fuel>
            {
                Filter = filter,
                Sort = sort,
                Pagination = new Pagination(pageCount, page, pageSize),
                Items = fuels.ToList()
            };

            return View(pageModel);
        }


        // GET: Fuels/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            Fuel fuel = db.Fuels.FirstOrDefault(f => f.Id == id);

            if(fuel != null)
            {
                return View(fuel);
            }
                

            return NotFound();
        }

        [Authorize(Roles = "admin")]
        // GET: Fuels/Create
        public ActionResult Create()
        {
            return View();
        }
        
        // POST: Fuels/Create
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Fuel fuel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Fuels.Add(fuel);
                    db.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(fuel);
                }
            }

            return View(fuel);
        }


        // GET: Fuels/Edit/5
        [Authorize(Roles = "admin")]
        public ActionResult Edit(int id)
        {
            Fuel fuel = db.Fuels.FirstOrDefault(f => f.Id == id);

            if (fuel != null)
            {
                return View(fuel);
            }

            return NotFound();
        }

        // POST: Fuels/Edit/5
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Fuel fuel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Fuels.Update(fuel);
                    db.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(fuel);
                }
            }

            return View(fuel);
        }

        // GET: Fuels/Delete/5
        [Authorize(Roles = "admin")]
        public ActionResult Delete(int id)
        {
            Fuel fuel = db.Fuels.FirstOrDefault(f => f.Id == id);

            if(fuel != null)
                return View(fuel);

            return NotFound();
        }

        // POST: Fuels/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Fuel fuel)
        {
            try
            {
                db.Fuels.Remove(fuel);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(fuel);
            }
        }

        // GET: Fuels/GetPrices/5
        [Authorize]
        [HttpGet("Fuels/GetPrices")]
        public JsonResult GetPrices(int id)
        {
            try
            {
                IEnumerable<Price> prices = db.Prices.Where(p => p.FuelId == id).Select(p => p);

                return Json(new JsonModel { Success = true, Data = prices });
            }
            catch
            {
                return Json(new JsonModel { Success = false });
            }
            
        }

        // GET: Fuels/Status/5
        [Authorize]
        public IActionResult Status(string sort, Filter filter, int page = 1)
        {
            IQueryable<FuelStatus> fuels = db.Fuels
                .GroupBy(f => f.Name)
                .Select(f => new FuelStatus
                {
                    Id = f.First().Id,
                    Name = f.First().Name,
                    PricePerLiter = f.First().Prices
                    .OrderBy(p => p.Date)
                    .Select(p => p.PricePerLiter)
                    .First(),
                    Description = f.First().Description,
                    Date = f.First().Prices.First().Date,
                    Value = f.First().FuelTanks.Sum(ft => ft.Value)
                }); ;

            int pageSize = 10;

            ViewBag.Filters = new SelectList(new List<SelectListItem>
            {
                new SelectListItem("Код", "Id"),
                new SelectListItem("Тип", "Name"),
                new SelectListItem("Характеристика", "Description"),
                new SelectListItem("Цена", "PricePerLiter"),
                new SelectListItem("Дата выставления цены", "Date")
            }, "Value", "Text", filter.Field);

            if (fuels.Count() > 0)
            {
                if (!string.IsNullOrEmpty(filter.Field)
                    && !string.IsNullOrEmpty(filter.Value)
                    && fuels.First().GetType().GetProperty(filter.Field) != null)
                {
                    fuels = fuels.Where(filter.Field + ".ToString().Contains(@0)", filter.Value);
                }
                //TODO: add toLowerCase
                if (!string.IsNullOrEmpty(sort) && fuels.First().GetType().GetProperty(sort) != null)
                {
                    fuels = fuels.OrderBy(sort);
                }
            }

            int pageCount = fuels.Count();
            fuels = fuels.Skip((page - 1) * pageSize).Take(pageSize);

            Page<FuelStatus> pageModel = new Page<FuelStatus>
            {
                Filter = filter,
                Sort = sort,
                Pagination = new Pagination(pageCount, page, pageSize),
                Items = fuels.ToList()
            };

            return View(pageModel);
        }

        // GET: Fuels/StatusDetails/5
        [Authorize]
        public IActionResult StatusDetails(int id)
        {
            FuelStatus fuel = db.Fuels
                .Where(f => f.Id == id)
                .GroupBy(f => f.Name)
                .Select(f => new FuelStatus
                {
                    Id = f.First().Id,
                    Name = f.First().Name,
                    PricePerLiter = Math.Round(f.First().Prices
                    .OrderBy(p => p.Date)
                    .Select(p => p.PricePerLiter)
                    .First(), 2),
                    Description = f.First().Description,
                    Date = f.First().Prices
                    .OrderBy(p => p.Date)
                    .Select(p => p.Date)
                    .First().Date,
                    Value = f.First().FuelTanks.Sum(ft => ft.Value),
                    FuelTanks = f.First().FuelTanks
                }).FirstOrDefault();

            if (fuel != null)
            {
                return View(fuel);
            }

            return NotFound();
        }

        // GET: Fuels/StatusDetails/5
        [Authorize]
        [HttpGet("Fuels/GetFuelTanksByFuelId")]
        public JsonResult GetFuelTanksByFuelId(int id)
        {
            List<FuelTank> fuelTanks = db.FuelTanks.Where(f => f.FuelId == id).ToList();

            if (fuelTanks.Count() > 0)
            {
                return Json(new JsonModel { Data = fuelTanks, Success = true });
            }

            return Json(new JsonModel { Data = "Not found", Success = false });
        }
    }
}
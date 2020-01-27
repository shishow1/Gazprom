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
using Microsoft.EntityFrameworkCore;

namespace gazprom.Controllers
{
    public class PricesController : Controller
    {
        private BaseContext db;

        public PricesController(BaseContext context)
        {
            db = context;
        }

        // GET: Price
        [Authorize]
        public ActionResult Index(string sort, Filter filter, int page = 1)
        {
            IQueryable<Price> prices = db.Prices.Include(f => f.Fuel);
            int pageSize = 10;

            ViewBag.Filters = new SelectList(new List<SelectListItem>
            {
                new SelectListItem("Код", "Id"),
                new SelectListItem("Тип ГСМ", "Fuel.Name"),
                new SelectListItem("Цена за литр", "PricePerLiter"),
                new SelectListItem("Дата", "Date")
            }, "Value", "Text", filter.Field);

            if (prices.Count() > 0)
            {
                if (!string.IsNullOrEmpty(filter.Field)
                    && !string.IsNullOrEmpty(filter.Value)
                    && prices.First().GetType().GetProperty(filter.Field) != null)
                {
                    //TODO: Child property not work
                    prices = prices.Where(filter.Field + ".ToString().Contains(@0)", filter.Value);
                }

                if (!string.IsNullOrEmpty(sort))
                {
                    try
                    {
                        prices = prices.OrderBy(sort);
                    }
                    catch
                    {
                        sort = "Id";
                        prices = prices.OrderBy(sort);
                    }
                }
            }

            int pageCount = prices.Count();
            prices = prices.Skip((page - 1) * pageSize).Take(pageSize);

            Page<Price> pageModel = new Page<Price>
            {
                Filter = filter,
                Sort = sort,
                Pagination = new Pagination(pageCount, page, pageSize),
                Items = prices.ToList()
            };

            return View(pageModel);
        }

        // GET: Price/Details/5
        [Authorize]
        public ActionResult Details(int id)
        {
            Price price = db.Prices
                .Include(f => f.Fuel)
                .FirstOrDefault(p => p.Id == id);

            if(price != null)
            {
                return View(price);
            }

            return NotFound();
        }

        // GET: Price/Create
        [Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            ViewBag.Fuels = new SelectList(db.Fuels, "Id", "Name");

            return View();
        }

        // POST: Price/Create
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Price price)
        {
            ViewBag.Fuels = new SelectList(db.Fuels, "Id", "Name", price.Id);

            if (ModelState.IsValid)
            {
                try
                {
                    db.Prices.Update(price);
                    db.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(price);
                }
            }

            return View(price);
        }

        // GET: Price/Edit/5
        [Authorize(Roles = "admin")]
        public ActionResult Edit(int id)
        {
            Price price = db.Prices.FirstOrDefault(p => p.Id == id);

            if(price != null)
            {
                ViewBag.Fuels = new SelectList(db.Fuels, "Id", "Name",price.FuelId);

                return View(price);
            }

            return NotFound();
        }

        // POST: Price/Edit/5
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Price price)
        {
            ViewBag.Fuels = new SelectList(db.Fuels, "Id", "Name", price.FuelId);

            if (ModelState.IsValid)
            {
                try
                {
                    db.Prices.Update(price);
                    db.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(price);
                }
            }

            return View(price);
        }

        // GET: Price/Delete/5
        [Authorize(Roles = "admin")]
        public ActionResult Delete(int id)
        {
            Price price = db.Prices
                .Include(f => f.Fuel)
                .FirstOrDefault(p => p.Id == id);

            if(price != null)
            {
                return View(price);
            }

            return NotFound();
        }

        // POST: Price/Delete/5
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Price price)
        {
            try
            {
                db.Prices.Remove(price);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(price);
            }
        }
    }
}
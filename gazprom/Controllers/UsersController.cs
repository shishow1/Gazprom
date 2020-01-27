using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using gazprom.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace gazprom.Controllers
{
    public class UsersController : Controller
    {
        private BaseContext db;
        public UsersController(BaseContext context)
        {
            db = context;
        }

        [Authorize]
        public IActionResult Index(string sort, Filter filter, int page = 1)
        {
            IQueryable<User> users = db.Users.Include(r => r.Role);
            int pageSize = 10;

            ViewBag.Filters = new SelectList(new List<SelectListItem>
            {
                new SelectListItem("Код", "Id"),
                new SelectListItem("Логин", "Login"),
                new SelectListItem("Имя", "Name"),
                new SelectListItem("Должность", "Post"),
                new SelectListItem("Роль", "Role.Name"),
            }, "Value", "Text", filter.Field);

            if (users.Count() > 0)
            {
                if (!string.IsNullOrEmpty(filter.Field)
                    && !string.IsNullOrEmpty(filter.Value)
                    && users.First().GetType().GetProperty(filter.Field) != null)
                {
                    users = users.Where(filter.Field + ".ToString().Contains(@0)", filter.Value);
                }

                if (!string.IsNullOrEmpty(sort))
                {
                    try
                    {
                        users = users.OrderBy(sort);
                    }
                    catch
                    {
                        sort = "Id";
                        users = users.OrderBy(sort);
                    }
                }
            }

            int pageCount = users.Count();
            users = users.Skip((page - 1) * pageSize).Take(pageSize);

            Page<User> pageModel = new Page<User>
            {
                Filter = filter,
                Sort = sort,
                Pagination = new Pagination(pageCount, page, pageSize),
                Items = users.ToList()
            };

            return View(pageModel);
        }

        // GET: Users/Details/5
        [Authorize]
        public IActionResult Details(int id)
        {
            User user = db.Users
                .Include(r => r.Role)
                .FirstOrDefault(m => m.Id == id);

            if (user != null)
            {
                return View(user);
            }

            return NotFound();
        }

        // GET: Users/Edit/5
        [Authorize(Roles = "admin")]
        public IActionResult Edit(int id)
        {
            User user = db.Users.Include(r => r.Role).FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                ViewBag.Roles = new SelectList(db.Roles, "Id", "Name", user.RoleId);

                return View(user);
            }

            return NotFound();
        }

        // POST: Users/Edit/5
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(User user)
        {
            ViewBag.Roles = new SelectList(db.Roles, "Id", "Name", user.Role);

            if (ModelState.IsValid)
            {
                try
                {
                    db.Users.Update(user);
                    db.SaveChanges();

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(user);
                }
            }

            return View(user);
        }

        // GET: Users/Delete/5
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {

            User user = db.Users
                .Include(r => r.Role)
                .FirstOrDefault(u => u.Id == id);

            if (user != null)
            {
                return View(user);
            }

            return NotFound();
        }

        // POST: Users/Delete/5
        [HttpPost]
        [Authorize(Roles = "admin")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(User user)
        {
            try
            {
                db.Users.Remove(user);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(user);
            }
        }
    }
}
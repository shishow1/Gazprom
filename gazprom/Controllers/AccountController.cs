using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Claims;
using System.Threading.Tasks;
using gazprom.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace gazprom.Controllers
{
    public class AccountController : Controller
    {
        private BaseContext db;
        public AccountController(BaseContext context)
        {
            db = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            User user = await db.Users.Include(r => r.Role).FirstOrDefaultAsync(u => u.Login == User.Identity.Name);

            if (user != null)
            {
                return View(user);
            }

            return NotFound();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginModel userLoginModel)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users
                    .Include(r => r.Role)
                    .FirstOrDefaultAsync(u => u.Email == userLoginModel.Email && u.Password == userLoginModel.Password);

                if (user != null)
                {
                    await Authenticate(user);

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("Password", "Некорректные логин и(или) пароль");
            }

            return View(userLoginModel);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterModel userRegisterModel)
        {
            if (ModelState.IsValid)
            {
                User user = await db.Users
                    .Include(r => r.Role)
                    .FirstOrDefaultAsync(u => u.Email == userRegisterModel.Email);

                Role userRole = await db.Roles.FirstOrDefaultAsync(r => r.Name == "user");

                if (userRole != null)
                {
                    user.Role = userRole;
                }
                    
                if (user == null)
                {
                    // добавляем пользователя в бд
                    db.Users.Add(new User { Email = userRegisterModel.Email, Password = userRegisterModel.Password });
                    await db.SaveChangesAsync();
                    await Authenticate(user);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Password", "Некорректные логин и(или) пароль");
                }
            }
            return View(userRegisterModel);
        }

        private async Task Authenticate(User  user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Login),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using TrustMeNews.Data;
using TrustMeNews.Models;

namespace TrustMeNews.Controllers
{
    public class UserController : Controller
    {
        private readonly TrustMeNewsDataContext _context;

        public UserController(TrustMeNewsDataContext context)
        {
            _context = context;
        }

        // GET: User/Login/5
        public async Task<IActionResult> Login(string? isValid)
        {
            if (isValid == null)
            {
                ViewData["Message"] = "null";
                return View();
            }
            else
            {
                ViewData["Message"] = isValid;
                return View();
            }


        }

        // POST: User/Login/5
        [HttpPost]
        public async Task<IActionResult> Login(string? unameInp, string? pw)
        {
            ViewData["Message"] = "null";
            User? user = await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == unameInp);

            if (user == null)
            {
                Response.Redirect("Login?isValid=invalid", true);
            }
            else if (!Hasher.Authenticate(pw, user.Salt, user.Password))
            {
                Response.Redirect("Login?isValid=invalid", true);
            }
            else
            {
                string sessionId = new Guid().ToString();
                user.SessionId = sessionId;
                
                await _context.SaveChangesAsync();
                HttpContext.Session.SetString("sessionId", sessionId);
                
                return RedirectToAction("Index", "Home", new { user = $"{user.UserName}" });
            }

            return View();


        }

        // GET: User
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // GET: User/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserId,Email,UserName,Password,SessionId")] User user)
        {
            if (ModelState.IsValid)
            {
                string[] saltAndHash = Hasher.HashMe(user.Password);
                user.Salt = saltAndHash[0];
                user.Password = saltAndHash[1];
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        // POST: User/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserId,Email,UserName,Password,SessionId")] User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectTrash.Data;
using ProjectTrash.Models;

namespace ProjectTrash.Controllers
{
    public class PickUpsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PickUpsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PickUps
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PickUps.Include(p => p.Account).Include(p => p.Employee);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PickUps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUp = await _context.PickUps
                .Include(p => p.Account)
                .Include(p => p.Employee)
                .FirstOrDefaultAsync(m => m.PickUpID == id);
            if (pickUp == null)
            {
                return NotFound();
            }

            return View(pickUp);
        }

        // GET: PickUps/Create
        public IActionResult Create()
        {
            ViewData["AccountID"] = new SelectList(_context.Accounts, "AccountID", "AccountID");
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "EmployeeID");
            return View();
        }

        // POST: PickUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PickUpID,AccountID,PickUpDate,EmployeeID,Completed")] PickUp pickUp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pickUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountID"] = new SelectList(_context.Accounts, "AccountID", "AccountID", pickUp.AccountID);
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "EmployeeID", pickUp.EmployeeID);
            return View(pickUp);
        }

        // GET: PickUps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUp = await _context.PickUps.FindAsync(id);
            if (pickUp == null)
            {
                return NotFound();
            }
            ViewData["AccountID"] = new SelectList(_context.Accounts, "AccountID", "AccountID", pickUp.AccountID);
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "EmployeeID", pickUp.EmployeeID);
            return View(pickUp);
        }

        // POST: PickUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PickUpID,AccountID,PickUpDate,EmployeeID,Completed")] PickUp pickUp)
        {
            if (id != pickUp.PickUpID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pickUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PickUpExists(pickUp.PickUpID))
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
            ViewData["AccountID"] = new SelectList(_context.Accounts, "AccountID", "AccountID", pickUp.AccountID);
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "EmployeeID", "EmployeeID", pickUp.EmployeeID);
            return View(pickUp);
        }

        // GET: PickUps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pickUp = await _context.PickUps
                .Include(p => p.Account)
                .Include(p => p.Employee)
                .FirstOrDefaultAsync(m => m.PickUpID == id);
            if (pickUp == null)
            {
                return NotFound();
            }

            return View(pickUp);
        }

        // POST: PickUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pickUp = await _context.PickUps.FindAsync(id);
            _context.PickUps.Remove(pickUp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PickUpExists(int id)
        {
            return _context.PickUps.Any(e => e.PickUpID == id);
        }
    }
}

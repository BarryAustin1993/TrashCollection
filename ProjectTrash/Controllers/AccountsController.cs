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
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Accounts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Accounts.Include(a => a.AccountSubscription).Include(a => a.Address).Include(a => a.WeeklyPickUp);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.AccountSubscription)
                .Include(a => a.Address)
                .Include(a => a.WeeklyPickUp)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            ViewData["AccountSubscriptionID"] = new SelectList(_context.AccountSubscriptions, "Id", "Id");
            ViewData["AddressID"] = new SelectList(_context.Addresses, "ID", "ID");
            ViewData["WeeklyPickUpID"] = new SelectList(_context.WeeklyPickUps, "ID", "ID");
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,balance,AccountSubscriptionID,AddressID,WeeklyPickUpID")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountSubscriptionID"] = new SelectList(_context.AccountSubscriptions, "Id", "Id", account.AccountSubscriptionID);
            ViewData["AddressID"] = new SelectList(_context.Addresses, "ID", "ID", account.AddressID);
            ViewData["WeeklyPickUpID"] = new SelectList(_context.WeeklyPickUps, "ID", "ID", account.WeeklyPickUpID);
            return View(account);
        }

        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            ViewData["AccountSubscriptionID"] = new SelectList(_context.AccountSubscriptions, "Id", "Id", account.AccountSubscriptionID);
            ViewData["AddressID"] = new SelectList(_context.Addresses, "ID", "ID", account.AddressID);
            ViewData["WeeklyPickUpID"] = new SelectList(_context.WeeklyPickUps, "ID", "ID", account.WeeklyPickUpID);
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,balance,AccountSubscriptionID,AddressID,WeeklyPickUpID")] Account account)
        {
            if (id != account.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.ID))
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
            ViewData["AccountSubscriptionID"] = new SelectList(_context.AccountSubscriptions, "Id", "Id", account.AccountSubscriptionID);
            ViewData["AddressID"] = new SelectList(_context.Addresses, "ID", "ID", account.AddressID);
            ViewData["WeeklyPickUpID"] = new SelectList(_context.WeeklyPickUps, "ID", "ID", account.WeeklyPickUpID);
            return View(account);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .Include(a => a.AccountSubscription)
                .Include(a => a.Address)
                .Include(a => a.WeeklyPickUp)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.ID == id);
        }
    }
}

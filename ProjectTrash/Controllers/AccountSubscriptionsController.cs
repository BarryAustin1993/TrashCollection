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
    public class AccountSubscriptionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountSubscriptionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AccountSubscriptions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AccountSubscriptions.Include(a => a.Account);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AccountSubscriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountSubscription = await _context.AccountSubscriptions
                .Include(a => a.Account)
                .FirstOrDefaultAsync(m => m.AccountSubscritionId == id);
            if (accountSubscription == null)
            {
                return NotFound();
            }

            return View(accountSubscription);
        }

        // GET: AccountSubscriptions/Create
        public IActionResult Create()
        {
            ViewData["AccountSubscritionId"] = new SelectList(_context.Accounts, "AccountID", "AccountID");
            return View();
        }

        // POST: AccountSubscriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AccountSubscritionId,IsActive,IsSuspended,AccountStartDate,AccountEndDate,SuspensionStartDate,SuspensionEndDate")] AccountSubscription accountSubscription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountSubscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountSubscritionId"] = new SelectList(_context.Accounts, "AccountID", "AccountID", accountSubscription.AccountSubscritionId);
            return View(accountSubscription);
        }

        // GET: AccountSubscriptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountSubscription = await _context.AccountSubscriptions.FindAsync(id);
            if (accountSubscription == null)
            {
                return NotFound();
            }
            ViewData["AccountSubscritionId"] = new SelectList(_context.Accounts, "AccountID", "AccountID", accountSubscription.AccountSubscritionId);
            return View(accountSubscription);
        }

        // POST: AccountSubscriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AccountSubscritionId,IsActive,IsSuspended,AccountStartDate,AccountEndDate,SuspensionStartDate,SuspensionEndDate")] AccountSubscription accountSubscription)
        {
            if (id != accountSubscription.AccountSubscritionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accountSubscription);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountSubscriptionExists(accountSubscription.AccountSubscritionId))
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
            ViewData["AccountSubscritionId"] = new SelectList(_context.Accounts, "AccountID", "AccountID", accountSubscription.AccountSubscritionId);
            return View(accountSubscription);
        }

        // GET: AccountSubscriptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountSubscription = await _context.AccountSubscriptions
                .Include(a => a.Account)
                .FirstOrDefaultAsync(m => m.AccountSubscritionId == id);
            if (accountSubscription == null)
            {
                return NotFound();
            }

            return View(accountSubscription);
        }

        // POST: AccountSubscriptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accountSubscription = await _context.AccountSubscriptions.FindAsync(id);
            _context.AccountSubscriptions.Remove(accountSubscription);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountSubscriptionExists(int id)
        {
            return _context.AccountSubscriptions.Any(e => e.AccountSubscritionId == id);
        }
    }
}

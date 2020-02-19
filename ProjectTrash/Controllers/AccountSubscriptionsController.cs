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
            return View(await _context.AccountSubscriptions.ToListAsync());
        }

        // GET: AccountSubscriptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var accountSubscription = await _context.AccountSubscriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accountSubscription == null)
            {
                return NotFound();
            }

            return View(accountSubscription);
        }

        // GET: AccountSubscriptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccountSubscriptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,isActive,isSuspended,accountStartDate,accountEndDate,suspensionStartDate,suspensionEndDate")] AccountSubscription accountSubscription)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accountSubscription);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
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
            return View(accountSubscription);
        }

        // POST: AccountSubscriptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,isActive,isSuspended,accountStartDate,accountEndDate,suspensionStartDate,suspensionEndDate")] AccountSubscription accountSubscription)
        {
            if (id != accountSubscription.Id)
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
                    if (!AccountSubscriptionExists(accountSubscription.Id))
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
                .FirstOrDefaultAsync(m => m.Id == id);
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
            return _context.AccountSubscriptions.Any(e => e.Id == id);
        }
    }
}

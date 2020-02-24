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
    public class WeeklyPickUpsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WeeklyPickUpsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WeeklyPickUps
        public async Task<IActionResult> Index()
        {
            return View(await _context.WeeklyPickUps.ToListAsync());
        }

        // GET: WeeklyPickUps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weeklyPickUp = await _context.WeeklyPickUps
                .FirstOrDefaultAsync(m => m.WeeklyPickUpId == id);
            if (weeklyPickUp == null)
            {
                return NotFound();
            }

            return View(weeklyPickUp);
        }

        // GET: WeeklyPickUps/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WeeklyPickUps/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("WeeklyPickUpId,DayOfTheWeek")] WeeklyPickUp weeklyPickUp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(weeklyPickUp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(weeklyPickUp);
        }

        // GET: WeeklyPickUps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weeklyPickUp = await _context.WeeklyPickUps.FindAsync(id);
            if (weeklyPickUp == null)
            {
                return NotFound();
            }
            return View(weeklyPickUp);
        }

        // POST: WeeklyPickUps/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("WeeklyPickUpId,DayOfTheWeek")] WeeklyPickUp weeklyPickUp)
        {
            if (id != weeklyPickUp.WeeklyPickUpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(weeklyPickUp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WeeklyPickUpExists(weeklyPickUp.WeeklyPickUpId))
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
            return View(weeklyPickUp);
        }

        // GET: WeeklyPickUps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var weeklyPickUp = await _context.WeeklyPickUps
                .FirstOrDefaultAsync(m => m.WeeklyPickUpId == id);
            if (weeklyPickUp == null)
            {
                return NotFound();
            }

            return View(weeklyPickUp);
        }

        // POST: WeeklyPickUps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var weeklyPickUp = await _context.WeeklyPickUps.FindAsync(id);
            _context.WeeklyPickUps.Remove(weeklyPickUp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WeeklyPickUpExists(int id)
        {
            return _context.WeeklyPickUps.Any(e => e.WeeklyPickUpId == id);
        }
    }
}

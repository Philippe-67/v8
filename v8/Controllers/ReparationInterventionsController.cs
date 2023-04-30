using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using v8.Data;
using v8.Models;

namespace v8.Controllers
{
    public class ReparationInterventionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReparationInterventionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ReparationInterventions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ReparationIntervention.Include(r => r.Intervention).Include(r => r.Reparation);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ReparationInterventions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ReparationIntervention == null)
            {
                return NotFound();
            }

            var reparationIntervention = await _context.ReparationIntervention
                .Include(r => r.Intervention)
                .Include(r => r.Reparation)
                .FirstOrDefaultAsync(m => m.ReparationId == id);
            if (reparationIntervention == null)
            {
                return NotFound();
            }

            return View(reparationIntervention);
        }

        // GET: ReparationInterventions/Create
        public IActionResult Create()
        {
            ViewData["InterventionId"] = new SelectList(_context.Intervention, "Id", "Id");
            ViewData["ReparationId"] = new SelectList(_context.Reparation, "Id", "Id");
            return View();
        }

        // POST: ReparationInterventions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReparationInterventionId,ReparationId,InterventionId")] ReparationIntervention reparationIntervention)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reparationIntervention);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InterventionId"] = new SelectList(_context.Intervention, "Id", "Id", reparationIntervention.InterventionId);
            ViewData["ReparationId"] = new SelectList(_context.Reparation, "Id", "Id", reparationIntervention.ReparationId);
            return View(reparationIntervention);
        }

        // GET: ReparationInterventions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ReparationIntervention == null)
            {
                return NotFound();
            }

            var reparationIntervention = await _context.ReparationIntervention.FindAsync(id);
            if (reparationIntervention == null)
            {
                return NotFound();
            }
            ViewData["InterventionId"] = new SelectList(_context.Intervention, "Id", "Id", reparationIntervention.InterventionId);
            ViewData["ReparationId"] = new SelectList(_context.Reparation, "Id", "Id", reparationIntervention.ReparationId);
            return View(reparationIntervention);
        }

        // POST: ReparationInterventions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReparationInterventionId,ReparationId,InterventionId")] ReparationIntervention reparationIntervention)
        {
            if (id != reparationIntervention.ReparationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reparationIntervention);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReparationInterventionExists(reparationIntervention.ReparationId))
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
            ViewData["InterventionId"] = new SelectList(_context.Intervention, "Id", "Id", reparationIntervention.InterventionId);
            ViewData["ReparationId"] = new SelectList(_context.Reparation, "Id", "Id", reparationIntervention.ReparationId);
            return View(reparationIntervention);
        }

        // GET: ReparationInterventions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ReparationIntervention == null)
            {
                return NotFound();
            }

            var reparationIntervention = await _context.ReparationIntervention
                .Include(r => r.Intervention)
                .Include(r => r.Reparation)
                .FirstOrDefaultAsync(m => m.ReparationId == id);
            if (reparationIntervention == null)
            {
                return NotFound();
            }

            return View(reparationIntervention);
        }

        // POST: ReparationInterventions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ReparationIntervention == null)
            {
                return Problem("Entity set 'ApplicationDbContext.ReparationIntervention'  is null.");
            }
            var reparationIntervention = await _context.ReparationIntervention.FindAsync(id);
            if (reparationIntervention != null)
            {
                _context.ReparationIntervention.Remove(reparationIntervention);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReparationInterventionExists(int id)
        {
          return (_context.ReparationIntervention?.Any(e => e.ReparationId == id)).GetValueOrDefault();
        }
    }
}

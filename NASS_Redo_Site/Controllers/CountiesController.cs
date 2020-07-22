using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NASS_Redo_Site.Models;

namespace NASS_Redo_Site.Controllers
{
    public class CountiesController : Controller
    {
        private readonly NASS_RedoContext _context;

        public CountiesController(NASS_RedoContext context)
        {
            _context = context;
        }

        // GET: Counties
        public async Task<IActionResult> Index()
        {
            var nASS_RedoContext = _context.County.Include(c => c.State);
            return View(await nASS_RedoContext.ToListAsync());
        }

        // GET: Counties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var county = await _context.County
                .Include(c => c.State)
                .FirstOrDefaultAsync(m => m.CountyId == id);
            if (county == null)
            {
                return NotFound();
            }

            return View(county);
        }

        // GET: Counties/Create
        public IActionResult Create()
        {
            ViewData["StateId"] = new SelectList(_context.State, "StateId", "Abbreviation");
            return View();
        }

        // POST: Counties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CountyId,Name,StateId")] County county)
        {
            if (ModelState.IsValid)
            {
                _context.Add(county);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StateId"] = new SelectList(_context.State, "StateId", "Abbreviation", county.StateId);
            return View(county);
        }

        // GET: Counties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var county = await _context.County.FindAsync(id);
            if (county == null)
            {
                return NotFound();
            }
            ViewData["StateId"] = new SelectList(_context.State, "StateId", "Abbreviation", county.StateId);
            return View(county);
        }

        // POST: Counties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CountyId,Name,StateId")] County county)
        {
            if (id != county.CountyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(county);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CountyExists(county.CountyId))
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
            ViewData["StateId"] = new SelectList(_context.State, "StateId", "Abbreviation", county.StateId);
            return View(county);
        }

        // GET: Counties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var county = await _context.County
                .Include(c => c.State)
                .FirstOrDefaultAsync(m => m.CountyId == id);
            if (county == null)
            {
                return NotFound();
            }

            return View(county);
        }

        // POST: Counties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var county = await _context.County.FindAsync(id);
            _context.County.Remove(county);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CountyExists(int id)
        {
            return _context.County.Any(e => e.CountyId == id);
        }
    }
}

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
    public class AddressLinesController : Controller
    {
        private readonly NASS_RedoContext _context;

        public AddressLinesController(NASS_RedoContext context)
        {
            _context = context;
        }

        // GET: AddressLines
        public async Task<IActionResult> Index()
        {
            var nASS_RedoContext = _context.AddressLine.Include(a => a.Addr);
            return View(await nASS_RedoContext.ToListAsync());
        }

        // GET: AddressLines/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressLine = await _context.AddressLine
                .Include(a => a.Addr)
                .FirstOrDefaultAsync(m => m.AddressLineId == id);
            if (addressLine == null)
            {
                return NotFound();
            }

            return View(addressLine);
        }

        // GET: AddressLines/Create
        public IActionResult Create()
        {
            ViewData["AddrId"] = new SelectList(_context.Address, "AddressId", "AddressId");
            return View();
        }

        // POST: AddressLines/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AddressLineId,AddrId,AddressLine1")] AddressLine addressLine)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addressLine);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddrId"] = new SelectList(_context.Address, "AddressId", "AddressId", addressLine.AddrId);
            return View(addressLine);
        }

        // GET: AddressLines/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressLine = await _context.AddressLine.FindAsync(id);
            if (addressLine == null)
            {
                return NotFound();
            }
            ViewData["AddrId"] = new SelectList(_context.Address, "AddressId", "AddressId", addressLine.AddrId);
            return View(addressLine);
        }

        // POST: AddressLines/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AddressLineId,AddrId,AddressLine1")] AddressLine addressLine)
        {
            if (id != addressLine.AddressLineId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addressLine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressLineExists(addressLine.AddressLineId))
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
            ViewData["AddrId"] = new SelectList(_context.Address, "AddressId", "AddressId", addressLine.AddrId);
            return View(addressLine);
        }

        // GET: AddressLines/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressLine = await _context.AddressLine
                .Include(a => a.Addr)
                .FirstOrDefaultAsync(m => m.AddressLineId == id);
            if (addressLine == null)
            {
                return NotFound();
            }

            return View(addressLine);
        }

        // POST: AddressLines/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addressLine = await _context.AddressLine.FindAsync(id);
            _context.AddressLine.Remove(addressLine);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressLineExists(int id)
        {
            return _context.AddressLine.Any(e => e.AddressLineId == id);
        }
    }
}

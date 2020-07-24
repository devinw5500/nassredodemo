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
    public class PersonPhonesController : Controller
    {
        private readonly NASS_RedoContext _context;

        public PersonPhonesController(NASS_RedoContext context)
        {
            _context = context;
        }

        // GET: PersonPhones
        public async Task<IActionResult> Index()
        {
            var nASS_RedoContext = _context.PersonPhone.Include(p => p.PersonContact);
            return View(await nASS_RedoContext.ToListAsync());
        }

        // GET: PersonPhones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personPhone = await _context.PersonPhone
                .Include(p => p.PersonContact)
                .FirstOrDefaultAsync(m => m.PersonPhoneId == id);
            if (personPhone == null)
            {
                return NotFound();
            }

            return View(personPhone);
        }

        // GET: PersonPhones/Create
        public IActionResult Create()
        {
            ViewData["PersonContactId"] = new SelectList(_context.PersonContact, "PersonContactId", "PersonContactId");
            return View();
        }

        // POST: PersonPhones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonPhoneId,PersonContactId,Phone,Type,Primary")] PersonPhone personPhone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personPhone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonContactId"] = new SelectList(_context.PersonContact, "PersonContactId", "PersonContactId", personPhone.PersonContactId);
            return View(personPhone);
        }

        // GET: PersonPhones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personPhone = await _context.PersonPhone.FindAsync(id);
            if (personPhone == null)
            {
                return NotFound();
            }
            ViewData["PersonContactId"] = new SelectList(_context.PersonContact, "PersonContactId", "PersonContactId", personPhone.PersonContactId);
            return View(personPhone);
        }

        // POST: PersonPhones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonPhoneId,PersonContactId,Phone,Type,Primary")] PersonPhone personPhone)
        {
            if (id != personPhone.PersonPhoneId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personPhone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonPhoneExists(personPhone.PersonPhoneId))
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
            ViewData["PersonContactId"] = new SelectList(_context.PersonContact, "PersonContactId", "PersonContactId", personPhone.PersonContactId);
            return View(personPhone);
        }

        // GET: PersonPhones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personPhone = await _context.PersonPhone
                .Include(p => p.PersonContact)
                .FirstOrDefaultAsync(m => m.PersonPhoneId == id);
            if (personPhone == null)
            {
                return NotFound();
            }

            return View(personPhone);
        }

        // POST: PersonPhones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personPhone = await _context.PersonPhone.FindAsync(id);
            _context.PersonPhone.Remove(personPhone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonPhoneExists(int id)
        {
            return _context.PersonPhone.Any(e => e.PersonPhoneId == id);
        }
    }
}

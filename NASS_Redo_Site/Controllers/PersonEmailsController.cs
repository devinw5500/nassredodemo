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
    public class PersonEmailsController : Controller
    {
        private readonly NASS_RedoContext _context;

        public PersonEmailsController(NASS_RedoContext context)
        {
            _context = context;
        }

        // GET: PersonEmails
        public async Task<IActionResult> Index()
        {
            var nASS_RedoContext = _context.PersonEmail.Include(p => p.PersonContact);
            return View(await nASS_RedoContext.ToListAsync());
        }

        // GET: PersonEmails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personEmail = await _context.PersonEmail
                .Include(p => p.PersonContact)
                .FirstOrDefaultAsync(m => m.PersonEmailId == id);
            if (personEmail == null)
            {
                return NotFound();
            }

            return View(personEmail);
        }

        // GET: PersonEmails/Create
        public IActionResult Create()
        {
            ViewData["PersonContactId"] = new SelectList(_context.PersonContact, "PersonContactId", "PersonContactId");
            return View();
        }

        // POST: PersonEmails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonEmailId,PersonContactId,Email,Primary")] PersonEmail personEmail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personEmail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonContactId"] = new SelectList(_context.PersonContact, "PersonContactId", "PersonContactId", personEmail.PersonContactId);
            return View(personEmail);
        }

        // GET: PersonEmails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personEmail = await _context.PersonEmail.FindAsync(id);
            if (personEmail == null)
            {
                return NotFound();
            }
            ViewData["PersonContactId"] = new SelectList(_context.PersonContact, "PersonContactId", "PersonContactId", personEmail.PersonContactId);
            return View(personEmail);
        }

        // POST: PersonEmails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonEmailId,PersonContactId,Email,Primary")] PersonEmail personEmail)
        {
            if (id != personEmail.PersonEmailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personEmail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonEmailExists(personEmail.PersonEmailId))
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
            ViewData["PersonContactId"] = new SelectList(_context.PersonContact, "PersonContactId", "PersonContactId", personEmail.PersonContactId);
            return View(personEmail);
        }

        // GET: PersonEmails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personEmail = await _context.PersonEmail
                .Include(p => p.PersonContact)
                .FirstOrDefaultAsync(m => m.PersonEmailId == id);
            if (personEmail == null)
            {
                return NotFound();
            }

            return View(personEmail);
        }

        // POST: PersonEmails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personEmail = await _context.PersonEmail.FindAsync(id);
            _context.PersonEmail.Remove(personEmail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonEmailExists(int id)
        {
            return _context.PersonEmail.Any(e => e.PersonEmailId == id);
        }
    }
}

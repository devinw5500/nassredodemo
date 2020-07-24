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
    public class PersonContactsController : Controller
    {
        private readonly NASS_RedoContext _context;

        public PersonContactsController(NASS_RedoContext context)
        {
            _context = context;
        }

        // GET: PersonContacts
        public async Task<IActionResult> Index()
        {
            var nASS_RedoContext = _context.PersonContact.Include(p => p.PersonInfo);
            return View(await nASS_RedoContext.ToListAsync());
        }

        // GET: PersonContacts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personContact = await _context.PersonContact
                .Include(p => p.PersonInfo)
                .FirstOrDefaultAsync(m => m.PersonContactId == id);
            if (personContact == null)
            {
                return NotFound();
            }

            return View(personContact);
        }

        // GET: PersonContacts/Create
        public IActionResult Create()
        {
            ViewData["PersonInfoId"] = new SelectList(_context.PersonInfo, "PersonInfoId", "FirstName");
            return View();
        }

        // POST: PersonContacts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonContactId,PersonInfoId")] PersonContact personContact)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personContact);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonInfoId"] = new SelectList(_context.PersonInfo, "PersonInfoId", "FirstName", personContact.PersonInfoId);
            return View(personContact);
        }

        // GET: PersonContacts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personContact = await _context.PersonContact.FindAsync(id);
            if (personContact == null)
            {
                return NotFound();
            }
            ViewData["PersonInfoId"] = new SelectList(_context.PersonInfo, "PersonInfoId", "FirstName", personContact.PersonInfoId);
            return View(personContact);
        }

        // POST: PersonContacts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonContactId,PersonInfoId")] PersonContact personContact)
        {
            if (id != personContact.PersonContactId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personContact);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonContactExists(personContact.PersonContactId))
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
            ViewData["PersonInfoId"] = new SelectList(_context.PersonInfo, "PersonInfoId", "FirstName", personContact.PersonInfoId);
            return View(personContact);
        }

        // GET: PersonContacts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personContact = await _context.PersonContact
                .Include(p => p.PersonInfo)
                .FirstOrDefaultAsync(m => m.PersonContactId == id);
            if (personContact == null)
            {
                return NotFound();
            }

            return View(personContact);
        }

        // POST: PersonContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personContact = await _context.PersonContact.FindAsync(id);
            _context.PersonContact.Remove(personContact);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonContactExists(int id)
        {
            return _context.PersonContact.Any(e => e.PersonContactId == id);
        }
    }
}

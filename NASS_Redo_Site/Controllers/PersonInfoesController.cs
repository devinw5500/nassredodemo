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
    public class PersonInfoesController : Controller
    {
        private readonly NASS_RedoContext _context;

        public PersonInfoesController(NASS_RedoContext context)
        {
            _context = context;
        }

        // GET: PersonInfoes
        public async Task<IActionResult> Index()
        {
            var nASS_RedoContext = _context.PersonInfo.Include(p => p.Addr).Include(p => p.Person);
            return View(await nASS_RedoContext.ToListAsync());
        }

        // GET: PersonInfoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personInfo = await _context.PersonInfo
                .Include(p => p.Addr)
                .Include(p => p.Person)
                .FirstOrDefaultAsync(m => m.PersonInfoId == id);
            if (personInfo == null)
            {
                return NotFound();
            }

            return View(personInfo);
        }

        // GET: PersonInfoes/Create
        public IActionResult Create()
        {
            ViewData["AddrId"] = new SelectList(_context.Address, "AddressId", "AddressId");
            ViewData["PersonId"] = new SelectList(_context.Person, "PersonId", "PersonId");
            return View();
        }

        // POST: PersonInfoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonInfoId,PersonId,AddrId,FirstName,MiddleInitial,LastName,Dob")] PersonInfo personInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddrId"] = new SelectList(_context.Address, "AddressId", "AddressId", personInfo.AddrId);
            ViewData["PersonId"] = new SelectList(_context.Person, "PersonId", "PersonId", personInfo.PersonId);
            return View(personInfo);
        }

        // GET: PersonInfoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personInfo = await _context.PersonInfo.FindAsync(id);
            if (personInfo == null)
            {
                return NotFound();
            }
            ViewData["AddrId"] = new SelectList(_context.Address, "AddressId", "AddressId", personInfo.AddrId);
            ViewData["PersonId"] = new SelectList(_context.Person, "PersonId", "PersonId", personInfo.PersonId);
            return View(personInfo);
        }

        // POST: PersonInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonInfoId,PersonId,AddrId,FirstName,MiddleInitial,LastName,Dob")] PersonInfo personInfo)
        {
            if (id != personInfo.PersonInfoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonInfoExists(personInfo.PersonInfoId))
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
            ViewData["AddrId"] = new SelectList(_context.Address, "AddressId", "AddressId", personInfo.AddrId);
            ViewData["PersonId"] = new SelectList(_context.Person, "PersonId", "PersonId", personInfo.PersonId);
            return View(personInfo);
        }

        // GET: PersonInfoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personInfo = await _context.PersonInfo
                .Include(p => p.Addr)
                .Include(p => p.Person)
                .FirstOrDefaultAsync(m => m.PersonInfoId == id);
            if (personInfo == null)
            {
                return NotFound();
            }

            return View(personInfo);
        }

        // POST: PersonInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personInfo = await _context.PersonInfo.FindAsync(id);
            _context.PersonInfo.Remove(personInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonInfoExists(int id)
        {
            return _context.PersonInfo.Any(e => e.PersonInfoId == id);
        }
    }
}

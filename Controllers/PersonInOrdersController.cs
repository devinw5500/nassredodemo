using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaxSystemNASS.Models;

namespace TaxSystemNASS.Controllers
{
    public class PersonInOrdersController : Controller
    {
        private readonly Nass_Redo_AzureContext _context;

        public PersonInOrdersController(Nass_Redo_AzureContext context)
        {
            _context = context;
        }

        // GET: PersonInOrders
        public async Task<IActionResult> Index()
        {
            var nass_Redo_AzureContext = _context.PersonInOrder.Include(p => p.Order).Include(p => p.Person);
            return View(await nass_Redo_AzureContext.ToListAsync());
        }

        // GET: PersonInOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personInOrder = await _context.PersonInOrder
                .Include(p => p.Order)
                .Include(p => p.Person)
                .FirstOrDefaultAsync(m => m.PersonInOrder1 == id);
            if (personInOrder == null)
            {
                return NotFound();
            }

            return View(personInOrder);
        }

        // GET: PersonInOrders/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid");
            ViewData["PersonId"] = new SelectList(_context.PersonalInfo, "PersonalInfoId", "FirstName");
            return View();
        }

        // POST: PersonInOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonInOrder1,PersonId,OrderId,Type")] PersonInOrder personInOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personInOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", personInOrder.OrderId);
            ViewData["PersonId"] = new SelectList(_context.PersonalInfo, "PersonalInfoId", "FirstName", personInOrder.PersonId);
            return View(personInOrder);
        }

        // GET: PersonInOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personInOrder = await _context.PersonInOrder.FindAsync(id);
            if (personInOrder == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", personInOrder.OrderId);
            ViewData["PersonId"] = new SelectList(_context.PersonalInfo, "PersonalInfoId", "FirstName", personInOrder.PersonId);
            return View(personInOrder);
        }

        // POST: PersonInOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersonInOrder1,PersonId,OrderId,Type")] PersonInOrder personInOrder)
        {
            if (id != personInOrder.PersonInOrder1)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personInOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonInOrderExists(personInOrder.PersonInOrder1))
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
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", personInOrder.OrderId);
            ViewData["PersonId"] = new SelectList(_context.PersonalInfo, "PersonalInfoId", "FirstName", personInOrder.PersonId);
            return View(personInOrder);
        }

        // GET: PersonInOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personInOrder = await _context.PersonInOrder
                .Include(p => p.Order)
                .Include(p => p.Person)
                .FirstOrDefaultAsync(m => m.PersonInOrder1 == id);
            if (personInOrder == null)
            {
                return NotFound();
            }

            return View(personInOrder);
        }

        // POST: PersonInOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personInOrder = await _context.PersonInOrder.FindAsync(id);
            _context.PersonInOrder.Remove(personInOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonInOrderExists(int id)
        {
            return _context.PersonInOrder.Any(e => e.PersonInOrder1 == id);
        }
    }
}

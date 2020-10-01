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
    public class UserForOrdersController : Controller
    {
        private readonly Nass_Redo_AzureContext _context;

        public UserForOrdersController(Nass_Redo_AzureContext context)
        {
            _context = context;
        }

        // GET: UserForOrders
        public async Task<IActionResult> Index()
        {
            var nass_Redo_AzureContext = _context.UserForOrder.Include(u => u.Aspnetuser).Include(u => u.Order);
            return View(await nass_Redo_AzureContext.ToListAsync());
        }

        // GET: UserForOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userForOrder = await _context.UserForOrder
                .Include(u => u.Aspnetuser)
                .Include(u => u.Order)
                .FirstOrDefaultAsync(m => m.UserForOrderId == id);
            if (userForOrder == null)
            {
                return NotFound();
            }

            return View(userForOrder);
        }

        // GET: UserForOrders/Create
        public IActionResult Create()
        {
            ViewData["AspnetuserId"] = new SelectList(_context.AspNetUsers, "Id", "Id");
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid");
            return View();
        }

        // POST: UserForOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserForOrderId,AspnetuserId,OrderId,Type")] UserForOrder userForOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userForOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AspnetuserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", userForOrder.AspnetuserId);
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", userForOrder.OrderId);
            return View(userForOrder);
        }

        // GET: UserForOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userForOrder = await _context.UserForOrder.FindAsync(id);
            if (userForOrder == null)
            {
                return NotFound();
            }
            ViewData["AspnetuserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", userForOrder.AspnetuserId);
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", userForOrder.OrderId);
            return View(userForOrder);
        }

        // POST: UserForOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("UserForOrderId,AspnetuserId,OrderId,Type")] UserForOrder userForOrder)
        {
            if (id != userForOrder.UserForOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userForOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserForOrderExists(userForOrder.UserForOrderId))
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
            ViewData["AspnetuserId"] = new SelectList(_context.AspNetUsers, "Id", "Id", userForOrder.AspnetuserId);
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", userForOrder.OrderId);
            return View(userForOrder);
        }

        // GET: UserForOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userForOrder = await _context.UserForOrder
                .Include(u => u.Aspnetuser)
                .Include(u => u.Order)
                .FirstOrDefaultAsync(m => m.UserForOrderId == id);
            if (userForOrder == null)
            {
                return NotFound();
            }

            return View(userForOrder);
        }

        // POST: UserForOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userForOrder = await _context.UserForOrder.FindAsync(id);
            _context.UserForOrder.Remove(userForOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserForOrderExists(int id)
        {
            return _context.UserForOrder.Any(e => e.UserForOrderId == id);
        }
    }
}

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
    public class OrderClientsController : Controller
    {
        private readonly NASS_RedoContext _context;

        public OrderClientsController(NASS_RedoContext context)
        {
            _context = context;
        }

        // GET: OrderClients
        public async Task<IActionResult> Index()
        {
            var nASS_RedoContext = _context.OrderClient.Include(o => o.OrderDetails).Include(o => o.User);
            return View(await nASS_RedoContext.ToListAsync());
        }

        // GET: OrderClients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderClient = await _context.OrderClient
                .Include(o => o.OrderDetails)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderClientId == id);
            if (orderClient == null)
            {
                return NotFound();
            }

            return View(orderClient);
        }

        // GET: OrderClients/Create
        public IActionResult Create()
        {
            ViewData["OrderDetailsId"] = new SelectList(_context.OrderDetails, "OrderDetailsId", "OrderDetailsId");
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "AspnetuserId");
            return View();
        }

        // POST: OrderClients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderClientId,OrderDetailsId,UserId")] OrderClient orderClient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderClient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderDetailsId"] = new SelectList(_context.OrderDetails, "OrderDetailsId", "OrderDetailsId", orderClient.OrderDetailsId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "AspnetuserId", orderClient.UserId);
            return View(orderClient);
        }

        // GET: OrderClients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderClient = await _context.OrderClient.FindAsync(id);
            if (orderClient == null)
            {
                return NotFound();
            }
            ViewData["OrderDetailsId"] = new SelectList(_context.OrderDetails, "OrderDetailsId", "OrderDetailsId", orderClient.OrderDetailsId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "AspnetuserId", orderClient.UserId);
            return View(orderClient);
        }

        // POST: OrderClients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderClientId,OrderDetailsId,UserId")] OrderClient orderClient)
        {
            if (id != orderClient.OrderClientId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderClient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderClientExists(orderClient.OrderClientId))
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
            ViewData["OrderDetailsId"] = new SelectList(_context.OrderDetails, "OrderDetailsId", "OrderDetailsId", orderClient.OrderDetailsId);
            ViewData["UserId"] = new SelectList(_context.User, "UserId", "AspnetuserId", orderClient.UserId);
            return View(orderClient);
        }

        // GET: OrderClients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderClient = await _context.OrderClient
                .Include(o => o.OrderDetails)
                .Include(o => o.User)
                .FirstOrDefaultAsync(m => m.OrderClientId == id);
            if (orderClient == null)
            {
                return NotFound();
            }

            return View(orderClient);
        }

        // POST: OrderClients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderClient = await _context.OrderClient.FindAsync(id);
            _context.OrderClient.Remove(orderClient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderClientExists(int id)
        {
            return _context.OrderClient.Any(e => e.OrderClientId == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TaxSystemNASS.Models;

namespace TaxSystemNASS.Controllers
{
    public class AddressInOrdersController : Controller
    {
        private readonly NassRedoAzureContext _context;

        public AddressInOrdersController(NassRedoAzureContext context)
        {
            _context = context;
        }

        // GET: AddressInOrders
        public async Task<IActionResult> Index()
        {
            var nass_Redo_AzureContext = _context.AddressInOrder.Include(a => a.Address).Include(a => a.Order);
            return View(await nass_Redo_AzureContext.ToListAsync());
        }

        // GET: AddressInOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressInOrder = await _context.AddressInOrder
                .Include(a => a.Address)
                .Include(a => a.Order)
                .FirstOrDefaultAsync(m => m.AddressInOrder1 == id);
            if (addressInOrder == null)
            {
                return NotFound();
            }

            return View(addressInOrder);
        }

        // GET: AddressInOrders/Create
        public IActionResult Create()
        {
            ViewData["AddressId"] = new SelectList(_context.Address, "AddressId", "AddressLine1");
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid");
            return View();
        }

        // POST: AddressInOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AddressInOrder1,AddressId,OrderId,Type")] AddressInOrder addressInOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addressInOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddressId"] = new SelectList(_context.Address, "AddressId", "AddressLine1", addressInOrder.AddressId);
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", addressInOrder.OrderId);
            return View(addressInOrder);
        }

        // GET: AddressInOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressInOrder = await _context.AddressInOrder.FindAsync(id);
            if (addressInOrder == null)
            {
                return NotFound();
            }
            ViewData["AddressId"] = new SelectList(_context.Address, "AddressId", "AddressLine1", addressInOrder.AddressId);
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", addressInOrder.OrderId);
            return View(addressInOrder);
        }

        // POST: AddressInOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AddressInOrder1,AddressId,OrderId,Type")] AddressInOrder addressInOrder)
        {
            if (id != addressInOrder.AddressInOrder1)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addressInOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddressInOrderExists(addressInOrder.AddressInOrder1))
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
            ViewData["AddressId"] = new SelectList(_context.Address, "AddressId", "AddressLine1", addressInOrder.AddressId);
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", addressInOrder.OrderId);
            return View(addressInOrder);
        }

        // GET: AddressInOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var addressInOrder = await _context.AddressInOrder
                .Include(a => a.Address)
                .Include(a => a.Order)
                .FirstOrDefaultAsync(m => m.AddressInOrder1 == id);
            if (addressInOrder == null)
            {
                return NotFound();
            }

            return View(addressInOrder);
        }

        // POST: AddressInOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var addressInOrder = await _context.AddressInOrder.FindAsync(id);
            _context.AddressInOrder.Remove(addressInOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddressInOrderExists(int id)
        {
            return _context.AddressInOrder.Any(e => e.AddressInOrder1 == id);
        }
    }
}
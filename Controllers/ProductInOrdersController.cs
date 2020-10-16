using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TaxSystemNASS.Models;

namespace TaxSystemNASS.Controllers
{
    public class ProductInOrdersController : Controller
    {
        private readonly Nass_Redo_AzureContext _context;

        public ProductInOrdersController(Nass_Redo_AzureContext context)
        {
            _context = context;
        }

        // GET: ProductInOrders
        public async Task<IActionResult> Index()
        {
            var nass_Redo_AzureContext = _context.ProductInOrder.Include(p => p.Order).Include(p => p.Product);
            return View(await nass_Redo_AzureContext.ToListAsync());
        }

        // GET: ProductInOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productInOrder = await _context.ProductInOrder
                .Include(p => p.Order)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.ProductInOrderId == id);
            if (productInOrder == null)
            {
                return NotFound();
            }

            return View(productInOrder);
        }

        // GET: ProductInOrders/Create
        public IActionResult Create()
        {
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid");
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Description");
            return View();
        }

        // POST: ProductInOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductInOrderId,ProductId,OrderId")] ProductInOrder productInOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productInOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", productInOrder.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Description", productInOrder.ProductId);
            return View(productInOrder);
        }

        // GET: ProductInOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productInOrder = await _context.ProductInOrder.FindAsync(id);
            if (productInOrder == null)
            {
                return NotFound();
            }
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", productInOrder.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Description", productInOrder.ProductId);
            return View(productInOrder);
        }

        // POST: ProductInOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductInOrderId,ProductId,OrderId")] ProductInOrder productInOrder)
        {
            if (id != productInOrder.ProductInOrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productInOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductInOrderExists(productInOrder.ProductInOrderId))
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
            ViewData["OrderId"] = new SelectList(_context.Order, "OrderId", "OrderGuid", productInOrder.OrderId);
            ViewData["ProductId"] = new SelectList(_context.Product, "ProductId", "Description", productInOrder.ProductId);
            return View(productInOrder);
        }

        // GET: ProductInOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productInOrder = await _context.ProductInOrder
                .Include(p => p.Order)
                .Include(p => p.Product)
                .FirstOrDefaultAsync(m => m.ProductInOrderId == id);
            if (productInOrder == null)
            {
                return NotFound();
            }

            return View(productInOrder);
        }

        // POST: ProductInOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productInOrder = await _context.ProductInOrder.FindAsync(id);
            _context.ProductInOrder.Remove(productInOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductInOrderExists(int id)
        {
            return _context.ProductInOrder.Any(e => e.ProductInOrderId == id);
        }
    }
}
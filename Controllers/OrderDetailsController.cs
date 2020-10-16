using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaxSystemNASS.Models;

namespace TaxSystemNASS.Controllers
{
    public class OrderDetailsController : Controller
    {
        private readonly Nass_Redo_AzureContext _context;

        public OrderDetailsController(Nass_Redo_AzureContext context)
        {
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Order.ToListAsync());
        }

        public async Task<IActionResult> OrderDetails(int? id)
        {
            var ctx = new Nass_Redo_AzureContext();
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Order
                .FirstOrDefaultAsync(m => m.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }

            var people = _context.PersonalInfo.FromSqlRaw(@$"SELECT [PersonalInfo].* FROM [PersonalInfo] INNER JOIN [PersonInOrder] ON [PersonInOrder].[PersonID] = [PersonalInfo].[PersonalInfoID] INNER JOIN [Order] ON [Order].[OrderID] = [PersonInOrder].[OrderID] WHERE [Order].[OrderID] = {id}; ").ToList();
            var peopletype = _context.PersonInOrder.FromSqlRaw(@$"SELECT [PersonInOrder].* FROM [PersonInOrder] INNER JOIN [Order] ON [Order].[OrderID] = [PersonInOrder].[OrderID] WHERE [Order].[OrderID] = {id} ORDER BY [PersonInOrder].[PersonID] ASC;").ToList();
            var address = _context.Address.FromSqlRaw(@$"SELECT [Address].* FROM [Address] INNER JOIN [AddressInOrder] ON [AddressInOrder].[AddressID] = [Address].[AddressID] INNER JOIN [Order] ON [Order].[OrderID] = [AddressInOrder].[OrderID] WHERE [Order].[OrderID] = {id} ORDER BY [Address].[AddressID] ASC;").ToList();
            var addresstype = _context.AddressInOrder.FromSqlRaw(@$"SELECT [AddressInOrder].* FROM [AddressInOrder] INNER JOIN [Order] ON [Order].[OrderID] = [AddressInOrder].[OrderID] WHERE [Order].[OrderID] = {id} ORDER BY [AddressInOrder].[AddressID] ASC;").ToList();
            var product = _context.Product.FromSqlRaw(@$"SELECT [Product].* FROM [Product] INNER JOIN [ProductInOrder] ON [ProductInOrder].[ProductID] = [Product].[ProductID] INNER JOIN [Order] ON [Order].[OrderID] = [ProductInOrder].[OrderID] WHERE [Order].[OrderID] = {id};").ToList();

            ViewBag.People = people;
            ViewBag.PeopleType = peopletype;
            ViewBag.Address = address;
            ViewBag.AddressType = addresstype;
            ViewBag.Product = product;

            return View(order);
        }
    }
}
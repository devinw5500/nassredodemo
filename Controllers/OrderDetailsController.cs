using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxSystemNASS.Models;

namespace TaxSystemNASS.Controllers
{
    public class OrderDetailsController : Controller
    {
        private NassRedoAzureContext _context;

        public OrderDetailsController(NassRedoAzureContext context)
        {
            _context = context;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Order.ToListAsync());
        }

        [Authorize]
        public async Task<IActionResult> CompletedOrders()
        {
            return View(await _context.Order.ToListAsync());
        }

        [Authorize]
        public async Task<IActionResult> OrderDetails(int? id)
        {
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
            var users = _context.UserForOrder.FromSqlRaw(@$"SELECT [UserForOrder].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [Order].[OrderID] = {id}").ToList();

            ViewBag.People = people;
            ViewBag.PeopleType = peopletype;
            ViewBag.Address = address;
            ViewBag.AddressType = addresstype;
            ViewBag.Product = product;
            ViewBag.Users = users;

            return View(order);
        }

        public IActionResult ClaimOrder(int id)
        {
            string email = User.Identity.Name;
            string type = "Employee";
            StringBuilder sqlProcedureExecute = new StringBuilder("INSERT INTO [dbo].[UserForOrder] ([ASPNETUserID], [OrderID], [Type]) VALUES");

            sqlProcedureExecute.AppendFormat(@"('{0}', {1}, '{2}')", email, id, type);

            _context.Database.ExecuteSqlRaw(sqlProcedureExecute.ToString());
            Debug.WriteLine(sqlProcedureExecute.ToString());

            return RedirectToAction("OrderDetails", new { id = id });
        }
    }
}
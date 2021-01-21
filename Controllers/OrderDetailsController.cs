using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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
        public IActionResult AllOrders()
        {
            var orders = _context.Order.FromSqlRaw(@$"SELECT * FROM [dbo].[Order]").ToList();
            ViewBag.Orders = orders;
            ViewBag.Title = "All Orders";
            ViewBag.PageTitle = "All Orders";
            return View("AllOrders");
        }

        [Authorize]
        [HttpGet]
        public IActionResult SearchOrders(string SearchBy, string SearchFor)
        {
            var orders = _context.Order.FromSqlRaw($@"SELECT * FROM [dbo].[Order]").ToList();

            if (SearchBy.Equals("StreetAddress"))
            {
                orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [Order] INNER JOIN [AddressInOrder] ON [AddressInOrder].[OrderID] = [Order].[OrderID] INNER JOIN [Address] ON [Address].[AddressID] = [AddressInOrder].[AddressID] WHERE [Address].[AddressLine1] LIKE '%{SearchFor}%';").ToList();
            }
            if (SearchBy.Equals("Name"))
            {
                orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [Order] INNER JOIN [PersonInOrder] ON [PersonInOrder].[OrderID] = [Order].[OrderID] INNER JOIN [PersonalInfo] ON [PersonalInfo].[PersonalInfoID] = [PersonInOrder].[PersonID] WHERE [PersonalInfo].[LastName] LIKE '%{SearchFor}%';").ToList();
            }
            if (SearchBy.Equals("User"))
            {
                orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [Order] INNER JOIN [UserForOrder] ON [UserForOrder].[OrderID] = [Order].[OrderID] WHERE [UserForOrder].[ASPNETUserID] LIKE '%{SearchFor}%';").ToList();
            }
            if (SearchBy.Equals("Product"))
            {
                orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [Order] INNER JOIN [ProductInOrder] ON [ProductInOrder].[OrderID] = [Order].[OrderID] INNER JOIN [Product] ON [Product].[ProductID] = [ProductInOrder].[ProductID] WHERE [Product].[Name] LIKE '%{SearchFor}%';").ToList();
            }
            // '%Tax%';
            ViewBag.Orders = orders;
            ViewBag.Title = "Searching orders by " + SearchBy + " for " + SearchFor;
            ViewBag.PageTitle = "Searching orders by " + SearchBy + " for " + SearchFor;
            return View("AllOrders");
        }

        [Authorize]
        public IActionResult YourOrders(string status)
        {
            var orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}' AND [Order].[Status] LIKE '%{status}%'").ToList();
            Debug.WriteLine(@$"SELECT [Order].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}' AND [Order].[Status] LIKE '%{status}%'");
            ViewBag.Title = status + " Orders";
            ViewBag.PageTitle = "Your " + status + " Orders";
            ViewBag.Orders = orders;
            return View("YourOrders");
        }

        [Authorize]
        [HttpGet]
        public IActionResult SearchYourOrders(string SearchBy, string SearchFor)
        {
            var orders = _context.Order.FromSqlRaw($@"SELECT * FROM [dbo].[Order]").ToList();

            if (SearchBy.Equals("StreetAddress"))
            {
                orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [Order] INNER JOIN [UserForOrder] ON [Order].[OrderID] = [UserForOrder].[OrderID] INNER JOIN [AddressInOrder] ON [AddressInOrder].[OrderID] = [Order].[OrderID] INNER JOIN [Address] ON [Address].[AddressID] = [AddressInOrder].[AddressID]  WHERE [Address].[AddressLine1] LIKE '%{SearchFor}%' AND [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}';").ToList();
            }
            if (SearchBy.Equals("Name"))
            {
                orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [Order] INNER JOIn [UserForOrder] ON [Order].[OrderID] = [UserForOrder].[OrderID] INNER JOIN [PersonInOrder] ON [PersonInOrder].[OrderID] = [Order].[OrderID] INNER JOIN [PersonalInfo] ON [PersonalInfo].[PersonalInfoID] = [PersonInOrder].[PersonID] WHERE [PersonalInfo].[LastName] LIKE '%{SearchFor}%' AND [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}';").ToList();
            }
            if (SearchBy.Equals("User"))
            {
                orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [Order] INNER JOIN [UserForOrder] ON [Order].[OrderID] = [UserForOrder].[OrderID] INNER JOIN [UserForOrder] ON [UserForOrder].[OrderID] = [Order].[OrderID] WHERE [UserForOrder].[ASPNETUserID] LIKE '%{SearchFor}%' AND [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}';").ToList();
            }
            if (SearchBy.Equals("Product"))
            {
                orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [Order] INNER JOIN [UserForOrder] ON [Order].[OrderID] = [UserForOrder].[OrderID] INNER JOIN [ProductInOrder] ON [ProductInOrder].[OrderID] = [Order].[OrderID] INNER JOIN [Product] ON [Product].[ProductID] = [ProductInOrder].[ProductID] WHERE [Product].[Name] LIKE '%{SearchFor}%' AND [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}';").ToList();
            }
            // '%Tax%';
            ViewBag.Orders = orders;
            ViewBag.Title = "Searching your orders by " + SearchBy + " for " + SearchFor;
            ViewBag.PageTitle = "Searching your orders by " + SearchBy + " for " + SearchFor;
            return View("YourOrders");
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
            var comments = _context.OrderComment.FromSqlRaw(@$"SELECT [OrderComment].* FROM [dbo].[OrderComment] INNER JOIN [Order] ON [Order].[OrderID] = [OrderComment].[OrderID] WHERE [Order].[OrderID] = {id}").ToList();

            ViewBag.People = people;
            ViewBag.PeopleType = peopletype;
            ViewBag.Address = address;
            ViewBag.AddressType = addresstype;
            ViewBag.Product = product;
            ViewBag.Users = users;
            ViewBag.Comments = comments;

            return View(order);
        }

        public IActionResult MakeComment(int id, string commentdesc, bool urgentcheck)
        {
            ViewData["commentdesc"] = commentdesc;
            ViewData["urgentcheck"] = urgentcheck;
            string date = DateTime.Now.ToString();
            string user = User.Identity.Name;

            StringBuilder sqlProcedureExecute = new StringBuilder("INSERT INTO [dbo].[OrderComment] ([OrderID], [Comment], [Urgent], [Date], [UserSubmitted]) VALUES");

            sqlProcedureExecute.AppendFormat(@"({0}, '{1}', '{2}', '{3}', '{4}')", id, commentdesc, urgentcheck, date, user);

            _context.Database.ExecuteSqlRaw(sqlProcedureExecute.ToString());
            Debug.WriteLine(sqlProcedureExecute.ToString());

            return RedirectToAction("OrderDetails", new { id = id });
        }

        public IActionResult AddAddress(int id, string AddAddrLn1, string AddAddrLn2, string AddState, string AddZip,
            string AddCounty, string AddCity, string AddParcel, string AddType, string AddAssessed)
        {
            ViewData["AddAddrLn1"] = AddAddrLn1;
            ViewData["AddAddrLn2"] = AddAddrLn2;
            ViewData["AddState"] = AddState;
            ViewData["AddZip"] = AddZip;
            ViewData["AddCity"] = AddCity;
            ViewData["AddCounty"] = AddCounty;
            ViewData["AddParcel"] = AddParcel;
            ViewData["AddAssessed"] = AddAssessed;
            ViewData["AddType"] = AddType;

            StringBuilder sqlProcedureExecute = new StringBuilder("EXECUTE AddAddress");

            sqlProcedureExecute.AppendFormat(@" @OrderID = '{0}', @AddrLine1 = '{1}', @AddrLine2 = '{2}', @StateAbbr = '{3}', @City = '{4}', @County = '{5}', @ZIP = '{6}', @Parcel = '{7}', @Assessed = '{8}', @Type = '{9}'",
                id, AddAddrLn1, AddAddrLn2, AddState, AddCity, AddCounty, AddZip, AddParcel, AddAssessed, AddType);

            _context.Database.ExecuteSqlRaw(sqlProcedureExecute.ToString());
            Debug.WriteLine(sqlProcedureExecute.ToString());

            return RedirectToAction("OrderDetails", new { id = id });
        }

        public IActionResult AddPerson(int id, string AddFname, string AddLName, string AddMI, string AddDOB,
            string AddEmail, string AddPhone, string AddFax, string AddType, string ADDSSN)
        {
            ViewData["AddFname"] = AddFname;
            ViewData["AddLName"] = AddLName;
            ViewData["AddMI"] = AddMI;
            ViewData["AddDOB"] = AddDOB;
            ViewData["AddEmail"] = AddEmail;
            ViewData["AddPhone"] = AddPhone;
            ViewData["AddFax"] = AddFax;
            ViewData["ADDSSN"] = ADDSSN;
            ViewData["AddType"] = AddType;

            StringBuilder sqlProcedureExecute = new StringBuilder("EXECUTE AddPerson");

            sqlProcedureExecute.AppendFormat(@" @OrderID = '{0}', @FName = '{1}', @MInitial = '{2}', @LName = '{3}', @DOB = '{4}', @Email = '{5}', @Phone = '{6}', @Fax = '{7}', @HashedSSN = '{8}', @Type = '{9}'",
                id, AddFname, AddMI, AddLName, AddDOB, AddEmail, AddPhone, AddFax, ADDSSN, AddType);

            _context.Database.ExecuteSqlRaw(sqlProcedureExecute.ToString());
            Debug.WriteLine(sqlProcedureExecute.ToString());

            return RedirectToAction("OrderDetails", new { id = id });
        }

        public IActionResult CompleteOrder(int id)
        {
            StringBuilder sqlProcedureExecute = new StringBuilder("UPDATE [Order] ");

            sqlProcedureExecute.AppendFormat(@"SET [CompletedDate] = '{0}', [Status] = 'Complete (Awaiting Confirmation)' WHERE [OrderID] = {1};", DateTime.Now, id);

            _context.Database.ExecuteSqlRaw(sqlProcedureExecute.ToString());
            Debug.WriteLine(sqlProcedureExecute.ToString());

            return RedirectToAction("OrderDetails", new { id = id });
        }

        public IActionResult ConfirmOrder(int id)
        {
            StringBuilder sqlProcedureExecute = new StringBuilder("UPDATE [Order] ");

            sqlProcedureExecute.AppendFormat(@"SET [ConfirmedDate] = '{0}', [Status] = 'Complete (Confirmed)' WHERE [OrderID] = {1};", DateTime.Now, id);

            _context.Database.ExecuteSqlRaw(sqlProcedureExecute.ToString());
            Debug.WriteLine(sqlProcedureExecute.ToString());

            return RedirectToAction("OrderDetails", new { id = id });
        }

        public IActionResult Reorder(int id)
        {
            //TODO: reorder stuff no idea how the best way to do is
            //StringBuilder sqlProcedureExecute = new StringBuilder("UPDATE [Order] ");

            //sqlProcedureExecute.AppendFormat(@"SET [ConfirmedDate] = '{0}', [Status] = 'Complete (Confirmed)' WHERE [OrderID] = {1};", DateTime.Now, id);

            //_context.Database.ExecuteSqlRaw(sqlProcedureExecute.ToString());
            //Debug.WriteLine(sqlProcedureExecute.ToString());

            return RedirectToAction("OrderDetails", new { id = id });
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
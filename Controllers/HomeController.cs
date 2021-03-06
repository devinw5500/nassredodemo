﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TaxSystemNASS.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

using TaxSystemNASS.Models;

using System;

namespace TaxSystemNASS.Controllers
{
    //TODO: Queue type thing for employees
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NassRedoAzureContext _context;

        public HomeController(ILogger<HomeController> logger, NassRedoAzureContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            Debug.WriteLine("id: " + User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value);
            if (User.IsInRole("Tech"))
            {
                TechHome();
                return View("TechHome");
            }
            if (User.IsInRole("Admin"))
            {
                AdminHome();
                return View("AdminHome");
            }
            if (User.IsInRole("Client"))
            {
                ClientHome();
                return View("ClientHome");
            }
            if (User.IsInRole("Employee"))
            {
                EmployeeHome();
                return View("EmployeeHome");
            }
            return View();
        }

        public IActionResult TechHome()
        {
            return View();
        }

        public IActionResult AdminHome()
        {
            return View();
        }

        public IActionResult ClientHome()
        {
            ViewBag.Orders = sqlCall();
            ViewBag.WIPNum = WIPNumber();
            ViewBag.NSNum = NotStartedNumber();
            ViewBag.ANNum = ActionNeededNumber();
            ViewBag.LONum = LateNumber();
            ViewBag.RCNum = RecCompleteNumber();
            ViewBag.NCNum = NeedConfirm();

            return View();
        }

        public IActionResult EmployeeHome()
        {
            ViewBag.Orders = sqlCall();
            ViewBag.WIPNum = WIPNumber();
            ViewBag.NSNum = NotStartedNumber();
            ViewBag.ANNum = ActionNeededNumber();
            ViewBag.LONum = LateNumber();

            return View();
        }

        public IActionResult Inbox()
        {
            var comments = _context.OrderComment.FromSqlRaw($@"SELECT [OrderComment].* FROM [dbo].[OrderComment] ORDER BY [OrderCommentID] DESC").ToList();
            ViewBag.Comments = comments;
            return View();
        }

        public System.Collections.Generic.List<Order> sqlCall()
        {
            var orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}'").ToList();

            return orders;
        }

        public int WIPNumber()
        {
            var orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}' AND [Order].[Status] = 'WIP'").ToList();
            int size = orders.Count();
            return size;
        }

        public int NotStartedNumber()
        {
            var orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}' AND [Order].[Status] = 'Not Started'").ToList();
            int size = orders.Count();
            return size;
        }

        public int ActionNeededNumber()
        {
            var orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}' AND [Order].[Status] = 'ACTION NEEDED'").ToList();
            int size = orders.Count();
            return size;
        }

        public int LateNumber()
        {
            var orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}' AND [Order].[Status] LIKE 'Late%'").ToList();
            int size = orders.Count();
            return size;
        }

        public int RecCompleteNumber()
        {
            DateTime since = DateTime.Today.AddDays(-10);
            string s = since.ToShortDateString();
            Debug.WriteLine("date: " + s);
            var orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}' AND [Order].[Status] = 'Completed' AND [Order].[ConfirmedDate] > '{s}'").ToList();

            int size = orders.Count();
            return size;
        }

        public int NeedConfirm()
        {
            var orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}' AND [Order].[Status] = 'Needs Confirmation'").ToList();
            int size = orders.Count();
            return size;
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Log in privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
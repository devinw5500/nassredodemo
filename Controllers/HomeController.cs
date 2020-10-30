using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using TaxSystemNASS.Models;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

using TaxSystemNASS.Models;

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
            var orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}'").ToList();
            ViewBag.Orders = orders;

            return View();
        }

        public IActionResult EmployeeHome()
        {
            var orders = _context.Order.FromSqlRaw(@$"SELECT [Order].* FROM [dbo].[UserForOrder] INNER JOIN [Order] ON [Order].[OrderID] = [UserForOrder].[OrderID] WHERE [UserForOrder].[ASPNETUserID] = '{User.Identity.Name}'").ToList();
            ViewBag.Orders = orders;

            return View();
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
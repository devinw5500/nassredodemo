using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TaxSystemNASS.Models;

namespace TaxSystemNASS.Controllers
{
    //TODO: Queue type thing for employees
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Nass_Redo_AzureContext _context;

        public HomeController(ILogger<HomeController> logger, Nass_Redo_AzureContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult PlaceOrder()
        {
            return View();
        }
        //TODO: add sql queries refi
        public IActionResult PlaceRefi()
        {
            return View();
        }
        //TODO: add sql queries purchase
        public IActionResult PlacePurchase()
        {
            return View();
        }
        public async Task<IActionResult> OrderQueue()
        {
            return View(await _context.Order.ToListAsync());
        }
        public async Task<IActionResult> OrderDetails()
        {
            //TODO: Viewbag to allow multiple models for each view? https://www.c-sharpcorner.com/UploadFile/ff2f08/multiple-models-in-single-view-in-mvc/ (number 4)
            return View(await _context.Order.ToListAsync());
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

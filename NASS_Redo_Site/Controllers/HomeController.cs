using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NASS_Redo_Site.Models;

namespace NASS_Redo_Site.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CreatePerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePerson(string FNameText, string MIText, string LNameText, string DOBText, 
            string ContactTypeSelect, bool PrimaryCheck, string ContactText,
            string AddrLine1Text, string AddrLine2Text, string StateSelect,
            string ZipSelect, string CitySelect, string CountySelect,
            string ParcelText)
        {
            ViewData["FNameText"] = FNameText;
            ViewData["MIText"] = MIText;
            ViewData["LNameText"] = LNameText;
            ViewData["DOBText"] = DOBText;
            ViewData["ContactTypeSelect"] = ContactTypeSelect;
            ViewData["PrimaryCheck"] = PrimaryCheck;
            ViewData["ContactText"] = ContactText;
            ViewData["AddrLine1Text"] = AddrLine1Text;
            ViewData["AddrLine2Text"] = AddrLine2Text;
            ViewData["StateSelect"] = StateSelect;
            ViewData["ZipSelect"] = ZipSelect;
            ViewData["CitySelect"] = CitySelect;
            ViewData["CountySelect"] = CountySelect;
            ViewData["ParcelText"] = ParcelText;

            Debug.WriteLine("Name: " + FNameText + " " + MIText + " " + LNameText);
            Debug.WriteLine("DOB: " + DOBText);
            Debug.WriteLine("Contact: " + ContactTypeSelect + 
                "\nPrimary: " + PrimaryCheck.ToString() +
                "\nContact: " + ContactText);
            Debug.WriteLine("AddressLines: " + AddrLine1Text + " " + AddrLine2Text +
                "\nState: " + StateSelect +
                "\nZip: " + ZipSelect +
                "\nCity: " + CitySelect +
                "\nCounty: " + CountySelect +
                "\nParcel: " + ParcelText);

            string newperson;
            string newpersoncontact;
            string newaddress;
            string newaddressline;

            return RedirectToAction("Index", "People");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

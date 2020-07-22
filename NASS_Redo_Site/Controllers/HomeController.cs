using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        //Posting method for create person, takes all variables for basic record creating
        [HttpPost]
        public IActionResult CreatePerson(string FNameText, string MIText, string LNameText, string DOBText, 
            string ContactTypeSelect, bool PrimaryCheck, string ContactText,
            string AddrLine1Text, string AddrLine2Text, string StateSelect,
            string ZipSelect, string CitySelect, string CountySelect,
            string ParcelText)
        {
            var ctx = new NASS_RedoContext();
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

            newperson = "\nDECLARE @RC int" +
                        "\nDECLARE @FName varchar(50)" +
                        "\nDECLARE @MInitial varchar(1)" +
                        "\nDECLARE @LName varchar(50)" +
                        "\nDECLARE @dob date" +
                        "\nDECLARE @CityName varchar(50)" +
                        "\nDECLARE @CountyName varchar(50)" +
                        "\nDECLARE @ZipNum varchar(10)" +
                        "\nSET @FName = \'" + FNameText + "\'" +
                        "\nSET @MInitial = \'" + MIText + "\'" +
                        "\nSET @LName = \'" + LNameText + "\'" +
                        "\nSET @dob = \'" + DOBText + "\'" +
                        "\nSET @CityName = \'" + CitySelect + "\'" +
                        "\nSET @CountyName = \'" + CountySelect + "\'" +
                        "\nSET @ZipNum = \'" + ZipSelect + "\'" +
                        "\nEXECUTE @RC = [dbo].[CreateNewPersonBasics]" +
                        "\n@FName" +
                        "\n,@MInitial" +
                        "\n,@LName" +
                        "\n,@dob" +
                        "\n,@CityName" +
                        "\n,@CountyName" +
                        "\n,@ZipNum";

            string newpersoncontact;

            switch (ContactTypeSelect)
            {
                case "Email":
                    newpersoncontact = "\nDECLARE @RC int" +
                        "\nDECLARE @FName varchar(50)" +
                        "\nDECLARE @MInitial varchar(1)" +
                        "\nDECLARE @LName varchar(50)" +
                        "\nDECLARE @dob date" +
                        "\nDECLARE @Email varchar(100)" +
                        "\nDECLARE @Prim bit" +
                        "\nSET @FName = \'" + FNameText + "\'" +
                        "\nSET @MInitial = \'" + MIText + "\'" +
                        "\nSET @LName = \'" + LNameText + "\'" +
                        "\nSET @dob = \'" + DOBText + "\'" +
                        "\nSET @Email = \'" + ContactText + "\'" +
                        "\nSET @Prim = \'" + PrimaryCheck + "\'" +
                        "\nEXECUTE @RC = [dbo].[CreateNewPersonEmail]" +
                        "\n@FName" +
                        "\n,@MInitial" +
                        "\n,@LName" +
                        "\n,@dob" +
                        "\n,@Email" +
                        "\n,@Prim";
                    break;

                case "Phone":
                    newpersoncontact = "\nDECLARE @RC int" +
                        "\nDECLARE @FName varchar(50)" +
                        "\nDECLARE @MInitial varchar(1)" +
                        "\nDECLARE @LName varchar(50)" +
                        "\nDECLARE @dob date" +
                        "\nDECLARE @Email varchar(100)" +
                        "\nDECLARE @Type varchar(20)" +
                        "\nDECLARE @Prim bit" +
                        "\nSET @FName = \'" + FNameText + "\'" +
                        "\nSET @MInitial = \'" + MIText + "\'" +
                        "\nSET @LName = \'" + LNameText + "\'" +
                        "\nSET @dob = \'" + DOBText + "\'" +
                        "\nSET @Email = \'" + ContactText + "\'" +
                        "\nSET @Type = \'" + ContactTypeSelect + "\'" +
                        "\nSET @Prim = \'" + PrimaryCheck + "\'" +
                        "\nEXECUTE @RC = [dbo].[CreateNewPersonPhone]" +
                        "\n@FName" +
                        "\n,@MInitial" +
                        "\n,@LName" +
                        "\n,@dob" +
                        "\n,@Email" +
                        "\n,@Type" +
                        "\n,@Prim";
                    break;

                case "Fax":
                    newpersoncontact = "\nDECLARE @RC int" +
                        "\nDECLARE @FName varchar(50)" +
                        "\nDECLARE @MInitial varchar(1)" +
                        "\nDECLARE @LName varchar(50)" +
                        "\nDECLARE @dob date" +
                        "\nDECLARE @Email varchar(100)" +
                        "\nDECLARE @Type varchar(20)" +
                        "\nDECLARE @Prim bit" +
                        "\nSET @FName = \'" + FNameText + "\'" +
                        "\nSET @MInitial = \'" + MIText + "\'" +
                        "\nSET @LName = \'" + LNameText + "\'" +
                        "\nSET @dob = \'" + DOBText + "\'" +
                        "\nSET @Email = \'" + ContactText + "\'" +
                        "\nSET @Type = \'" + ContactTypeSelect + "\'" +
                        "\nSET @Prim = \'" + PrimaryCheck + "\'" +
                        "\nEXECUTE @RC = [dbo].[CreateNewPersonPhone]" +
                        "\n@FName" +
                        "\n,@MInitial" +
                        "\n,@LName" +
                        "\n,@dob" +
                        "\n,@Email" +
                        "\n,@Type" +
                        "\n,@Prim";
                    break;

                default:
                    Debug.WriteLine("SWITCH AT DEFAULT");
                    newpersoncontact = "oops";
                    break;
            }

            string newaddress;

            newaddress = "\nDECLARE @RC int" +
                        "\nDECLARE @CityName varchar(50)" +
                        "\nDECLARE @CountyName varchar(50)" +
                        "\nDECLARE @ZipNum varchar(10)" +
                        "\nSET @CityName = \'" + CitySelect + "\'" +
                        "\nSET @CountyName = \'" + CountySelect + "\'" +
                        "\nSET @ZipNum = \'" + ZipSelect + "\'" +
                        "\nEXECUTE @RC = [dbo].[CreateNewAddress]" +
                        "\n@CityName" +
                        "\n,@CountyName" +
                        "\n,@ZipNum";

            string newaddressline;

            newaddressline = "\nDECLARE @RC int" +
                        "\nDECLARE @AddrLine varchar(50)" +
                        "\nDECLARE @CityName varchar(50)" +
                        "\nDECLARE @CountyName varchar(50)" +
                        "\nDECLARE @ZipNum varchar(10)" +
                        "\nSET @AddrLine = \'" + AddrLine1Text + "\'" +
                        "\nSET @CityName = \'" + CitySelect + "\'" +
                        "\nSET @CountyName = \'" + CountySelect + "\'" +
                        "\nSET @ZipNum = \'" + ZipSelect + "\'" +
                        "\nEXECUTE @RC = [dbo].[CreateNewAddressLine]" +
                        "\n@Addrline" +
                        "\n,@CityName" +
                        "\n,@CountyName" +
                        "\n,@ZipNum";

            Debug.WriteLine("\nNewPerson: " + newperson + "\n");
            Debug.WriteLine("\nNewPersonContact: " + newpersoncontact + "\n");
            Debug.WriteLine("\nNewAddress: " + newaddress + "\n");
            Debug.WriteLine("\nNewAddressLine: " + newaddressline + "\n");

            ctx.Database.ExecuteSqlRaw(newaddress);
            ctx.Database.ExecuteSqlRaw(newaddressline);
            ctx.Database.ExecuteSqlRaw(newperson);
            ctx.Database.ExecuteSqlRaw(newpersoncontact);

            if (!AddrLine2Text.Equals(null))
            {
                string newaddressline2;

                newaddressline2 = "\nDECLARE @RC int" +
                            "\nDECLARE @AddrLine varchar(50)" +
                            "\nDECLARE @CityName varchar(50)" +
                            "\nDECLARE @CountyName varchar(50)" +
                            "\nDECLARE @ZipNum varchar(10)" +
                            "\nSET @AddrLine = \'" + AddrLine2Text + "\'" +
                            "\nSET @CityName = \'" + CitySelect + "\'" +
                            "\nSET @CountyName = \'" + CountySelect + "\'" +
                            "\nSET @ZipNum = \'" + ZipSelect + "\'" +
                            "\nEXECUTE @RC = [dbo].[CreateNewAddressLine]" +
                            "\n@Addrline" +
                            "\n,@CityName" +
                            "\n,@CountyName" +
                            "\n,@ZipNum";
                Debug.WriteLine("\nNewAddressLine2: " + newaddressline2 + "\n");
                ctx.Database.ExecuteSqlRaw(newaddressline2);
            }


            return RedirectToAction("Index", "PersonInfoes");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

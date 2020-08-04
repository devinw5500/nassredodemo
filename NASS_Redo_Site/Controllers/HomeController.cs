using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using NASS_Redo_Site.Models;

namespace NASS_Redo_Site.Controllers
{
    //TODO: add todos later pls
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly NASS_RedoContext _context;
        public HomeController(NASS_RedoContext context,
            UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult CreatePersonState()
        {
            ViewData["StateSelect"] = new SelectList(_context.State, "StateId", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult CreatePersonState(string StateSelect)
        {
            ViewData["StateSelect"] = StateSelect;
            var ctx = new NASS_RedoContext();

            Debug.WriteLine("State (createperson state) : " + StateSelect);
            ViewData["StateSelect"] = new SelectList(_context.State, "StateId", "Name");
            return RedirectToAction("CreatePerson", "Home", new { StateSelect });
        }
        public IActionResult CreatePerson(string StateSelect)
        {
            var ctx = new NASS_RedoContext();

            int state = int.Parse(StateSelect);

            Debug.WriteLine("State (createperson) : " + state);

            ViewData["StateName"] = new SelectList(_context.State, "Name", "Name");
            ViewData["CityName"] = new SelectList(_context.City.Where(n => n.State.Equals(state)), "Name", "Name");
            ViewData["CountyName"] = new SelectList(_context.County.Where(n => n.State.Equals(state)), "Name", "Name");
            ViewData["ZipName"] = new SelectList(_context.Zip.Where(n => n.State.Equals(state)), "Zip1", "Zip1");
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
        public IActionResult CreateUser()
        {

            ViewData["StateName"] = new SelectList(_context.State, "Name", "Name");
            ViewData["CityName"] = new SelectList(_context.City, "Name", "Name");
            ViewData["CountyName"] = new SelectList(_context.County, "Name", "Name");
            ViewData["ZipName"] = new SelectList(_context.Zip, "Zip1", "Zip1");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateUserAsync(string Email, string Password,
            string FNameText, string MIText, string LNameText, string DOBText,
            string ContactTypeSelect, bool PrimaryCheck, string ContactText,
            string AddrLine1Text, string AddrLine2Text, string StateSelect,
            string ZipSelect, string CitySelect, string CountySelect,
            string ParcelText)
        {
            var ctx = new NASS_RedoContext();
            ViewData["Email"] = Email;
            ViewData["Password"] = Password;
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

            Debug.WriteLine("Email: " + Email);
            Debug.WriteLine("Password: " + Password);
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

            var user = new IdentityUser { UserName = Email, Email = Email };
            var result = await _userManager.CreateAsync(user, Password);

            if (result.Succeeded)
            {//only succeeds if it is a new username/emails NO REPEATS
                Debug.WriteLine("worked bro sick hahahahahah");
                Debug.WriteLine("GUID: " + user.Id);
                Debug.WriteLine("Email: " + user.Email);
                Debug.WriteLine("NormEmail: " + user.NormalizedEmail);
                Debug.WriteLine("User: " + user.UserName);
                Debug.WriteLine("NormUser: " + user.NormalizedUserName);
                Debug.WriteLine("PassHash: " + user.PasswordHash);

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

                //TODO: test newuser insert (make sure test email isnt in aspnetusers table already)
                string newuser;

                newuser = "\nDECLARE @RC int" +
                            "\nDECLARE @persid int" +
                            "\nSELECT @persid = [Person].[PersonID]" +
                            "\nFROM [Person]" +
                            "\nWHERE [Person].[UniqueUserID] = \'" + LNameText + FNameText + MIText + "\'" +
                            "\nINSERT INTO [People].[User]" +
                            "\n([PersonID]" +
                            "\n,[ASPNETUserID])" +
                            "\nVALUES" +
                            "\n(" + "" +
                            "\n," + user.Id + ")";

                Debug.WriteLine("\nNewPerson: " + newperson + "\n");
                Debug.WriteLine("\nNewPersonContact: " + newpersoncontact + "\n");
                Debug.WriteLine("\nNewAddress: " + newaddress + "\n");
                Debug.WriteLine("\nNewAddressLine: " + newaddressline + "\n");
                Debug.WriteLine("\nNewUser: " + newuser + "\n");

                ctx.Database.ExecuteSqlRaw(newaddress);
                ctx.Database.ExecuteSqlRaw(newaddressline);
                ctx.Database.ExecuteSqlRaw(newperson);
                ctx.Database.ExecuteSqlRaw(newpersoncontact);
                ctx.Database.ExecuteSqlRaw(newuser);

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


                return RedirectToAction("Index", "Users");
            }
            //TODO: display neat error if it is a repeat email
            if (!result.Succeeded)
            {
                Debug.WriteLine("it didnt work bro fuck hahahahahah " + result.Errors.ToString());
                return View();
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using Microsoft.AspNetCore.Mvc;
using TaxSystemNASS.Models;
using System.Text;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace TaxSystemNASS.Controllers
{
    public class PlaceOrdersController : Controller
    {
        public readonly Nass_Redo_AzureContext _context;

        public PlaceOrdersController(Nass_Redo_AzureContext context)
        {
            _context = context;
        }

        //TODO: Pretty up Index
        // GET: _000PlaceOrdersController
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult PlaceRefi()
        {
            ViewData["BuyFNameText"] = "test if works";
            return View();
        }

        //TODO: add sql queries purchase
        public IActionResult PlacePurchase()
        {
            return View();
        }

        //TODO: Finish reviews
        [HttpPost]
        public IActionResult ReviewPurchased(string BuyFNameText, string BuyMIText, string BuyLNameText, string BuyDOBText, string BuySSNText, string BuyEmailText, string BuyPhoneText, string BuyFaxText, string SellFNameText, string SellMIText, string SellLNameText,
            string SellDOBText, string SellSSNText, string SellEmailText, string SellPhoneText, string SellFaxText, string SellAddrLn1, string SellAddrLn2, string SellState, string SellZip,
            string SellCounty, string SellCity, string PropAddrLn1, string PropAddrLn2, string PropState, string PropZip,
            string PropCounty, string PropCity, string PropParcel, string ProductSold)
        {
            Console.WriteLine("Runing Purchase");

            ViewData["BuyFNameText"] = BuyFNameText;
            ViewData["BuyMIText"] = BuyMIText;
            ViewData["BuyLNameText"] = BuyLNameText;
            ViewData["BuyDOBText"] = BuyDOBText;
            ViewData["BuySSNText"] = BuySSNText;
            ViewData["BuyEmailText"] = BuyEmailText;
            ViewData["BuyPhoneText"] = BuyPhoneText;
            ViewData["BuyFaxText"] = BuyFaxText;
            ViewData["SellFNameText"] = SellFNameText;
            ViewData["SellMIText"] = SellMIText;
            ViewData["SellLNameText"] = SellLNameText;
            ViewData["SellDOBText"] = SellDOBText;
            ViewData["SellSSNText"] = SellSSNText;
            ViewData["SellEmailText"] = SellEmailText;
            ViewData["SellPhoneText"] = SellPhoneText;
            ViewData["SellFaxText"] = SellFaxText;
            ViewData["SellAddrLn1"] = SellAddrLn1;
            ViewData["SellAddrLn2"] = SellAddrLn2;
            ViewData["SellState"] = SellState;
            ViewData["SellZip"] = SellZip;
            ViewData["SellCity"] = SellCity;
            ViewData["SellCounty"] = SellCounty;
            ViewData["PropAddrLn1"] = PropAddrLn1;
            ViewData["PropAddrLn2"] = PropAddrLn2;
            ViewData["PropState"] = PropState;
            ViewData["PropZip"] = PropZip;
            ViewData["PropCity"] = PropCity;
            ViewData["PropCounty"] = PropCounty;
            ViewData["PropParcel"] = PropParcel;
            ViewData["Product"] = ProductSold;

            string SellParcel = "NULL";

            Debug.WriteLine("SellAddrln1:" + SellAddrLn1);

            StringBuilder sqlProcedureExecute = new StringBuilder("EXECUTE usp_PurchaseInsert");

            sqlProcedureExecute.AppendFormat(@" @BuyerFNameText = '{0}', @BuyerMIText = '{1}', @BuyerLNameText = '{2}', @BuyerDOBText = '{3}', @BuyerSSNText = '{4}', @BuyerEmailText = '{5}', @BuyerPhoneText = '{6}', @BuyerFaxText = '{7}', @SellerFNameText = '{8}', @SellerMIText = '{9}', @SellerLNameText = '{10}', @SellerDOBText = '{11}', @SellerSSNText = '{12}', @SellerEmailText = '{13}', @SellerPhoneText = '{14}', @SellerFaxText = '{15}', @SellAddrLn1 = '{16}', @SellAddrLn2 = '{17}', @SellState = '{18}', @SellZip = '{19}', @SellCounty = '{20}', @SellCity = '{21}', @SellParcel = '{22}', @PropAddrLn1 = '{23}', @PropAddrLn2 = '{24}', @PropState = '{25}', @PropZip = '{26}', @PropCounty = '{27}', @PropCity = '{28}', @PropParcel = '{29}', @Product = '{30}', @Date = '{31}'", BuyFNameText, BuyMIText, BuyLNameText, BuyDOBText, BuySSNText, BuyEmailText, BuyPhoneText, BuyFaxText, SellFNameText, SellMIText, SellLNameText, SellDOBText, SellSSNText, SellEmailText, SellPhoneText, SellFaxText, SellAddrLn1, SellAddrLn2, SellState, SellZip, SellCounty, SellCity, SellParcel, PropAddrLn1, PropAddrLn2, PropState, PropZip, PropCounty, PropCity, PropParcel, ProductSold, DateTime.Now);

            _context.Database.ExecuteSqlRaw(sqlProcedureExecute.ToString());

            return View();
        }

        [HttpPost]
        public IActionResult ReviewRefi(string RefiFNameText, string RefiMIText, string RefiLNameText, string RefiDOBText, string RefiSSNText, string RefiEmailText, string RefiPhoneText, string RefiFaxText, string RefiAddrLn1, string RefiAddrLn2, string RefiState, string RefiZip, string RefiCounty, string RefiCity, string RefiParcel, string ProductSold)
        {
            Console.WriteLine("RunningRefi");

            ViewData["RefiFNameText"] = RefiFNameText;
            ViewData["RefiMIText"] = RefiMIText;
            ViewData["RefiLNameText"] = RefiLNameText;
            ViewData["RefiDOBText"] = RefiDOBText;
            ViewData["RefiSSNText"] = RefiSSNText;
            ViewData["RefiEmailText"] = RefiEmailText;
            ViewData["RefiPhoneText"] = RefiPhoneText;
            ViewData["RefiFaxText"] = RefiFaxText;
            ViewData["RefiAddrLn1"] = RefiAddrLn1;
            ViewData["RefiAddrLn2"] = RefiAddrLn2;
            ViewData["RefiState"] = RefiState;
            ViewData["RefiZip"] = RefiZip;
            ViewData["RefiCounty"] = RefiCounty;
            ViewData["RefiCity"] = RefiCity;
            ViewData["RefiParcel"] = RefiParcel;
            ViewData["Product"] = ProductSold;

            StringBuilder sqlProcedureExecute = new StringBuilder("EXECUTE usp_RefiInsert ");

            sqlProcedureExecute.AppendFormat(@"@RefiFNameText = '{0}', @RefiMIText = '{1}', @RefiLNameText = '{2}', @RefiDOBText = '{3}', @RefiSSNText = '{4}', @RefiEmailText = '{5}', @RefiPhoneText = '{6}', @RefiFaxText = '{7}', @RefiAddrLn1 = '{8}', @RefiAddrLn2 = '{9}', @RefiState = '{10}', @RefiZip = '{11}', @RefiCounty = '{12}', @RefiCity = '{13}', @RefiParcel = '{14}', @Product = '{15}', @Date = '{16}'", RefiFNameText, RefiMIText, RefiLNameText, RefiDOBText, RefiSSNText, RefiEmailText, RefiPhoneText, RefiFaxText, RefiAddrLn1, RefiAddrLn2, RefiState, RefiZip, RefiCounty, RefiCity, RefiParcel, ProductSold, DateTime.Now);

            _context.Database.ExecuteSqlRaw(sqlProcedureExecute.ToString());

            return View();
        }
    }
}
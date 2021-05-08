using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Models.Factories;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger){_logger = logger;}

        public IActionResult Index(){ 
            ViewBag.Products = Root.getJson(); 
            return View();}

        public IActionResult Basket()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buy(int id)
        {
            var product  = Root.getJson()[id];
            PurchaseRealizationFactory purchFac = getPurchase(product.brand);
            @ViewBag.brand = product.brand;
            var purchase = purchFac.Checkout();

            @ViewBag.product = product;
            @ViewBag.WarrantyDuration = purchase.getWarrantyDuration();
            @ViewBag.ShippingCost = purchase.getShippingCost();
            return View("Basket");
        }

        private PurchaseRealizationFactory getPurchase(string brand)
        {

            switch (brand)
            {
                case "Apple":
                    return new ApplePurchaseRealization();
                case "Acer":

                    return new AcerPurchaseRealization();
                default:

                    return new OtherPurchaseRealization();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

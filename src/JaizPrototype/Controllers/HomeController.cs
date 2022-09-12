using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using JaizPrototype.Models;
using JaizPrototype.ViewModels;

namespace JaizPrototype.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        Merchant x = new Merchant()
        {
            MerchantId = 1,
            Name = "LIZPEE GLOBAL RESOURCES",
            Location = "NO. 174 NTA/MBUORA RD, PORTHARCO URT",
            TerminalId = 23011845
        };

        Transaction transaction = new Transaction()
        {
            TransactionId = 1,
            Status = "TRANSACTION DECLINED",
            ResponseCode = 91, 
            AID = "A0000000041010",
            RRN = "000210002450"
        };
         Card card = new Card()
         {
            cardID = 1,
            CardNumber = 12345,
            ExpiryDate = "11/24",
            CardType = "Mastercard"
         };
          Purchase purchase= new Purchase()
         {
          PurchaseId = 1
         };

    }


    public IActionResult Index()
    {
        var jaizSlipViewModel = new JaizSlipViewModel()
        {
            Merchant = new Merchant()
        {
            MerchantId = 1,
            Name = "LIZPEE GLOBAL RESOURCES",
            Location = "NO. 174 NTA/MBUORA RD, PORTHARCO URT",
            TerminalId = 23011845
        },
            Card = new Card()
         {
            cardID = 1,
            CardNumber = 12345,
            ExpiryDate = "11/24"
         },
            Purchase = new Purchase()
         {
          PurchaseId = 1,
          Stan = 003862,
          Date = "2022-08-30 17:32:58",
          Amount = 0.01
         },
            Transaction = new Transaction()
        {
            TransactionId = 1,
            Status = "TRANSACTION DECLINED",
            ResponseCode = 91, 
            AID = "A0000000041010",
            RRN = "000210002450"
        }
        };
        return View(jaizSlipViewModel);
    }

}

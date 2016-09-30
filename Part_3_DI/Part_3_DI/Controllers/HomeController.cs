using Part_3_DI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Part_3_DI.Controllers
{
    public class HomeController : Controller
    {
        //建立計算object變數
        private IValueCalculator calc;
        //測試產品陣列資料
        private Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 19.50M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M}
        };

        //建立HomeController建構式,提供DI注入計算種金額object
        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }

        // GET: Home
        public ActionResult Index()
        {
            //建立購物車
            ShoppingCart cart = new ShoppingCart(calc) { Products = products };
            //計算產品總金額
            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }
    }
}
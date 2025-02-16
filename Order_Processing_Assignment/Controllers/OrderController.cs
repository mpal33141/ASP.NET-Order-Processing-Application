using Order_Processing_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Order_Processing_Assignment.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessOrder(string customerName, string email, decimal orderAmount, string customerType)
        {
            decimal discount = CalculateDiscount(orderAmount, customerType);
            decimal finalTotal = orderAmount - discount;

            ViewBag.CustomerName = customerName;
            ViewBag.Email = email;
            ViewBag.OrderAmount = orderAmount;
            ViewBag.Discount = discount;
            ViewBag.FinalTotal = finalTotal;
            ViewBag.CustomerType = customerType;

            return View("Result");
        }

        private decimal CalculateDiscount(decimal amount, string customerType)
        {
            if (amount >= 100 && customerType == "Loyal")
            {
                return amount * 0.10m; 
            }
            return 0;
        }
    }
}
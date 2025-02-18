using Microsoft.VisualStudio.TestTools.UnitTesting;
using Order_Processing_Assignment.Controllers;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Discount_ShouldBe10Percent_WhenLoyalCustomerAndOrderAbove100()
        {
            // Arrange
            var controller = new OrderController();
            decimal orderAmount = 150;  
            string customerType = "Loyal";

            // Act
            var discount = controller.GetType()
                                     .GetMethod("CalculateDiscount", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                                     .Invoke(controller, new object[] { orderAmount, customerType });

            // Assert
            Assert.AreEqual(15, (decimal)discount); 
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantReviews.Controllers;
using System.Web.Mvc;

namespace RestaurantReviews.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void AboutTest()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            ViewResult result = controller.About() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Model);
        }
    }
}

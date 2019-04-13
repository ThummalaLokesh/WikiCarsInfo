using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WikiCarsInfo;
using WikiCarsInfo.Controllers;

namespace WikiCarsInfo.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AUDI()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.AUDI() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BMW()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.BMW() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MERC()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.MERC() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

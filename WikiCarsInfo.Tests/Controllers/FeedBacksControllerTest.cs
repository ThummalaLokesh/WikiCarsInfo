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
    public class FeedBacksControllerTest
    {
        [TestMethod]
<<<<<<< HEAD
        public void DeleteConfirmed(int FeedBackId)
        {
            // Arrange
            FeedBacksController controller = new FeedBacksController();

            // Act
            ViewResult result = controller.DeleteConfirmed(FeedBackId) as ViewResult;
=======
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;
>>>>>>> master

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
<<<<<<< HEAD
            FeedBacksController controller = new FeedBacksController();

            // Act
            ViewResult result = controller.Create() as ViewResult;
=======
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Delete()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;
>>>>>>> master

            // Assert
            Assert.IsNotNull(result);
        }

<<<<<<< HEAD
        
=======
>>>>>>> master
        [TestMethod]
        public void Details()
        {
            // Arrange
<<<<<<< HEAD
            FeedBacksController controller = new FeedBacksController();

            // Act
            ViewResult result = controller.Details() as ViewResult;
=======
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;
>>>>>>> master

            // Assert
            Assert.IsNotNull(result);
        }

<<<<<<< HEAD
        
=======
        [TestMethod]
        public void Edit()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
>>>>>>> master
    }
}

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
        public void DeleteConfirmed(int FeedBackId)
        {
            // Arrange
            FeedBacksController controller = new FeedBacksController();

            // Act
            ViewResult result = controller.DeleteConfirmed(FeedBackId) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            FeedBacksController controller = new FeedBacksController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        
        [TestMethod]
        public void Details()
        {
            // Arrange
            FeedBacksController controller = new FeedBacksController();

            // Act
            ViewResult result = controller.Details() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        
    }
}

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
    public class ReviewsControllerTest
    {
        [TestMethod]
        public void AUDIA8()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.AUDIA8() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AUDIQ8()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.AUDIQ8() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void AUDIR8()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.AUDIR8() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BMW520()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.BMW520() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BMW7()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.BMW7() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BMWi8()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.BMWi8() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.Create() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        

        [TestMethod]
        public void Details()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Edit()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MERCC()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MERCS()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void MERCSLS()
        {
            // Arrange
            ReviewsController controller = new ReviewsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SadgguruTeaShopUnitTest;
using SadgguruTeaShopUnitTest.Controllers;
using SadgguruTeaShopUnitTest.Models;

namespace SadgguruTeaShopUnitTest.Tests.Controllers
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
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
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

        public void GetAllComponentsFromRepository()

        {

            // Arrange
            ComponentRepository cmprepository = new ComponentRepository();


            var testComponents = new List<SadgguruTeaShopUnitTest.Models.Component>();
            testComponents.Add(new Component { ComponentId = 1, Name = "cvb", Description = "asc", Price = 12 });
            testComponents.Add(new Component { ComponentId = 2, Name = "Sugar", Description = "Crystal Sugar", Price = 77 });
            testComponents.Add(new Component { ComponentId = 3, Name = "Tea Powder", Description = "TATA Tea", Price = 46 });



            var components=cmprepository.GetAllComponents();

            Assert.AreEqual(components.Count, testComponents.Count);

        }
    }
}

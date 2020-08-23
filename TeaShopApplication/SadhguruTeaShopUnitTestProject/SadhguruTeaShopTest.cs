using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Component = SadhguruTeaShop.Models.Component;


namespace SadhguruTeaShop
{
    [TestClass]
    public class SadhguruTeaShopTest
    {
        [TestMethod]
        public void GetAllComponents_ShouldReturnAllComponents()
        {

            var components = getAllComponents();
            ComponentController componentController = new ComponentController();
            var result = componentController.GetAllComponents();
            Assert.AreEqual(components.Count, result.Count);
        }

        [TestMethod]
        public List<Component> getAllComponents()
        {
            var testComponents = new List<SadhguruTeaShop.Models.Component>();
            testComponents.Add(new Component { ComponentId = 1, Name = "cvb", Description = "asc", Price = 12 });
            testComponents.Add(new Component { ComponentId = 2, Name = "Sugar", Description = "Crystal Sugar", Price = 77 });
            testComponents.Add(new Component { ComponentId = 3, Name = "Tea Powder", Description = "TATA Tea", Price = 46 });


            return testComponents;
        }
    }
}

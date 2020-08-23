using SadhguruTeaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadguruTeaShop.Test
{
     public class ComponentController
    {
        public List<Component> GetAllComponents()
        {
            var components = new List<Component>();
            using (SadhguruTeaShopDBEntities dc = new SadhguruTeaShopDBEntities())
            {
                components = dc.Components.OrderBy(a => a.Name).ToList();
            }

            return components;
        }
    }
}

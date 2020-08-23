using SadhguruTeaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SadgguruTeaShopUnitTest.Models
{
    public class ComponentRepository:IComponentRepository
    {
        private SadhguruTeaShopDBEntities db = new SadhguruTeaShopDBEntities();

        public void CreateNewComponent(Component componentToCreate)
        {
            db.Components.Add(componentToCreate);

            db.SaveChanges();
        }

        public void DeleteComponent(int id)
        {
            var conToDel = GetComponentByID(id);

            db.Components.Remove(conToDel);

            db.SaveChanges();
        }

        public List<Component> GetAllComponents()
        {
            return db.Components.ToList();
        }

        public Component GetComponentByID(int id)
        {
            return db.Components.FirstOrDefault(d => d.ComponentId == id);
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }
    }
}
using SadhguruTeaShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SadhguruTeaShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // GET: Component

        public ActionResult GetComponents()
        {
            using (SadhguruTeaShopDBEntities dc = new SadhguruTeaShopDBEntities())
            {
                var components = dc.Components.OrderBy(a => a.Name).ToList();
                return Json(new { data = components }, JsonRequestBehavior.AllowGet);
            }


        }

    
        //Save method Get
        [HttpGet]
        public ActionResult Save(int id)
        {
            using (SadhguruTeaShopDBEntities dc = new SadhguruTeaShopDBEntities())
            {
                var v = dc.Components.Where(i => i.ComponentId == id).FirstOrDefault();
                return View(v);
            }
        }
        //Save method Post
        [HttpPost]
        public ActionResult Save(Component component)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                using (SadhguruTeaShopDBEntities dc = new SadhguruTeaShopDBEntities())
                {
                    if (component.ComponentId > 0)
                    {
                        //Edit
                        var v = dc.Components.Where(i => i.ComponentId == component.ComponentId).FirstOrDefault();
                        if (v != null)
                        {
                            v.Name = component.Name;
                            v.Description = component.Description;
                            v.Price = component.Price;
                         
                        }
                    }
                    else
                    {
                        //save
                        dc.Components.Add(component);
                        
                    }
                    dc.SaveChanges();
                    status = true;

                }
            }
            return RedirectToAction("Index");
          

        }
        //Delete Method Get
        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (SadhguruTeaShopDBEntities dc = new SadhguruTeaShopDBEntities())
            {
                var component = dc.Components.Where(x => x.ComponentId == id).FirstOrDefault();
                if (component != null)
                {
                    return View(component);
                }
                else
                {
                    return HttpNotFound();
                }
            }
        }
        //Delete Method Post
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteComponent(int id)
        {
            bool status = false;
            using (SadhguruTeaShopDBEntities dc = new SadhguruTeaShopDBEntities())
            {
                var v = dc.Components.Where(x => x.ComponentId == id).FirstOrDefault();
                if (v != null)
                {
                    dc.Components.Remove(v);
                    dc.SaveChanges();
                    status = true;
                }
            }
          
            return RedirectToAction("Index");
        }

       

    }

}

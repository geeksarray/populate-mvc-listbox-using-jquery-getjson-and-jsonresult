using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCListBoxExample.Models;

namespace MVCListBoxExample.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCategories()
        {
            Dictionary<string, string> lstCategories = new Dictionary<string, string>();
            lstCategories.Add("1", "Beverages");
            lstCategories.Add("2", "Condiments");
            lstCategories.Add("3", "Confections");
            lstCategories.Add("4", "Dairy Products");
            lstCategories.Add("5", "Grains/Cereals");
            lstCategories.Add("6", "Meat/Poultry");
            lstCategories.Add("7", "Produce");
            lstCategories.Add("8", "Seafood");            
            return Json(lstCategories, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCategoriesWithModel()
        {
            List<Category> lstCateogories = new List<Category>();
            lstCateogories.Add(new Category() { CategoryID = "1", CategoryName = "Beverages" });
            lstCateogories.Add(new Category() { CategoryID = "2", CategoryName = "Condiments" });
            lstCateogories.Add(new Category() { CategoryID = "3", CategoryName = "Confections" });
            lstCateogories.Add(new Category() { CategoryID = "4", CategoryName = "Dairy Products" });
            lstCateogories.Add(new Category() { CategoryID = "5", CategoryName = "Grains/Cereals" });
            lstCateogories.Add(new Category() { CategoryID = "6", CategoryName = "Meat/Poultry" });
            lstCateogories.Add(new Category() { CategoryID = "7", CategoryName = "Produce" });
            lstCateogories.Add(new Category() { CategoryID = "8", CategoryName = "Seafood" });

            return Json(lstCateogories, JsonRequestBehavior.AllowGet);
        }
    }
}

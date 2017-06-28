using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models.DB;
using OnlineShopping.Models;
using System.IO;
namespace OnlineShopping.Controllers
{
    public class UCategoriesController : Controller
    {
        // GET: User
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        public ActionResult Categorieslist()
        {
            IList<Sp_categories_Details_Result> list = db.Sp_categories_Details().ToList();
            return View(list);
        }
    }
}
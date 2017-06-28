using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models.DB;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    public class UItemController : Controller
    {
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        // GET: UItem
        public ActionResult UItemlist(int id)
        {
            IList<Sp_UItem_Details_Result> list = db.Sp_UItem_Details(id).ToList();
            return View(list);
        }
    }
}
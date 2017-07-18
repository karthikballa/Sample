using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models.DB;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    public class UOrderController : Controller
    {
        // GET: UOdre
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        public ActionResult UOrderlist(int id)
        {
            IList<Sp_Uorder_Details_Result> list = db.Sp_Uorder_Details(id).ToList();
          
            //List<tbl_Item> itemlist = new List<tbl_Item>();
            return View(list);
        }




        //public ActionResult AddtoCart(int itemid)
        //{

        //    List<tbl_Item> itemlist = new List<tbl_Item>();

        //   tbl_Item item = new tbl_Item();

        //    item.ItemID = itemid;

        //    itemlist.Add(item);

        //    Session["itemlist"] = itemlist;

        //    return View(UOrderlist(itemid));

        //}

    }
}
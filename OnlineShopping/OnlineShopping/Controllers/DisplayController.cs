using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using OnlineShopping.Models.DB;
using OnlineShopping.Models;

namespace OnlineShopping.Controllers
{
    public class DisplayController : Controller
    {
        // GET: Display
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        public ActionResult Categorieslst()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Categorieslst(tbl_Categories obj)
        //{
        //    return View();
        //}
      
        public ActionResult Brandlist()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Brandlist()
        //{
        //    return View();
        //}
        public ActionResult Itemlist()
        {
            return View();
        }
        public ActionResult Orderlist()
        {
            return View();
        }
    }
}
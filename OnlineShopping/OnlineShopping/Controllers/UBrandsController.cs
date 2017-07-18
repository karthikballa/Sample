using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models;
using OnlineShopping.Models.DB;

namespace OnlineShopping.Controllers
{
    
    public class UBrandsController : Controller
    {
        // GET: UBrands
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        public ActionResult Brandlist(int id)
        {
            IList<Sp_UBrands_Details_Result> list = db.Sp_UBrands_Details(id).ToList();
            return View(list);
        }

        public ActionResult CategoryBrand(int id)
        {

            IList<Sp_UCtgryBrand_Details_Result> list = db.Sp_UCtgryBrand_Details(id).ToList();
            return View(list);
        }
    }
}
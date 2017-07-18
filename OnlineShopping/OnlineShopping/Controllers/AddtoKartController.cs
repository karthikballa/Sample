using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models;
using OnlineShopping.Models.DB;

namespace OnlineShopping.Controllers
{
    public class AddtoKartController : Controller
    {
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        public ActionResult List()
        {
            IList<Sp_Kart_Details_Result> list = db.Sp_Kart_Details().ToList();
            return View(list);
        }

        // GET: AddtoKart/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddtoKart/Create
        [HttpPost]
        public ActionResult Create(tbl_Kart obj)
        {
               tbl_Order o = new tbl_Order();
            List<tbl_Kart> UserInfo = db.tbl_Kart.Where(x => x.OrderID == obj.OrderID && x.UserID == obj.UserID).ToList();
            db.Sp_Kart_insert(obj.OrderID, obj.UserID);
            // TODO: Add insert logic here

            return RedirectToAction("List");
        }

        // POST: AddtoKart/Create
        public ActionResult Create()
        {
            try
            {
                return View();
            }
            catch 
            {
                return View();
            }
        }

        // GET: AddtoKart/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddtoKart/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: AddtoKart/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AddtoKart/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
               

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
    }
}

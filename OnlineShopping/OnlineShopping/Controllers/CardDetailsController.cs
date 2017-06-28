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
    public class CardDetailsController : Controller
    {

        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        // GET: CardDetails
        public ActionResult List()
        {
            IList<Sp_CardDetails_Details_Result> list = db.Sp_CardDetails_Details().ToList();
            return View(list);
        }

        // GET: CardDetails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CardDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CardDetails/Create
        [HttpPost]
        public ActionResult Create(tbl_CardDetails obj)
        {
            try
            {
                db.Sp_CardDetails_Insert(obj.LoginID, obj.OrderID, obj.Type, obj.CardNumber, obj.CardName, obj.Expirydate, obj.CVV);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: CardDetails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CardDetails/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: CardDetails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CardDetails/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

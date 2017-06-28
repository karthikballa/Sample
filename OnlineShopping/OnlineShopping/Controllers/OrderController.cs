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
    public class OrderController : Controller
    {
        // GET: Order
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        public ActionResult Categories()
        {
            List<tbl_Categories> list = new List<tbl_Categories>();
            list = db.tbl_Categories.ToList();
            ViewBag.Categoriess = new SelectList(list, "CategoriesID", "CategoriesName");
            return View();
        }
        public ActionResult List()
        {
            IList<Sp_order_Details_Result> list = db.Sp_order_Details().ToList();
            return View(list);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            Categories();
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(tbl_Order obj,HttpPostedFileBase image)
        {
            try
            {
                string imgpath = string.Empty;
                if(image!=null)
                {
                    string filename = Path.GetFileName(image.FileName);
                    imgpath = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(image.FileName));
                    image.SaveAs(imgpath);
                    imgpath = filename;
                }
                obj.OrderImage = imgpath;
                db.Sp_order_insert(obj.ItemID, obj.OrderDescription, obj.OrderImage, obj.Price, obj.Quality);
                // TODO: Add insert logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        public JsonResult Brand(string CategoriesID)
        {
            if (CategoriesID != string.Empty)
            {
                int BID = Convert.ToInt32(CategoriesID);
                var getlist = db.tbl_Brands.Where(x => x.CategoriesID == BID).ToList();
                return Json(getlist, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult Item(string BrandID)
        {
            if (BrandID != string.Empty)
            {
                int Bid = Convert.ToInt32(BrandID);
                var getlist = db.tbl_Item.Where(x => x.BrandID == Bid).ToList();
                return Json(getlist, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("", JsonRequestBehavior.AllowGet);
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            Categories();
           Sp_order_Display_Result edit = db.Sp_order_Display(id).FirstOrDefault();
            return View(edit);
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,tbl_Order obj,HttpPostedFileBase image)
        {
            try
            {
                string imgpath = string.Empty;
                if(image !=null)
                {
                    string filename = Path.GetFileName(image.FileName);
                    imgpath = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(image.FileName));
                    image.SaveAs(imgpath);
                    imgpath = filename;
                }
                obj.OrderImage = imgpath;
                db.Sp_order_Update(obj.OrderID, obj.ItemID, obj.OrderDescription, obj.OrderImage, obj.Price, obj.Quality);
                // TODO: Add update logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                db.Sp_order_Delete(id).ToString();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

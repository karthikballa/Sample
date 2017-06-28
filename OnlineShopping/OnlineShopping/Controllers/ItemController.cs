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
    public class ItemController : Controller
    {
        // GET: Item
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        public ActionResult List()
        {
            IList<Sp_Item_Details_Result> list =db.Sp_Item_Details().ToList();
            return View(list);
        }

        // GET: Item/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Categories()
        {
            SelectList Categories = new SelectList(db.tbl_Categories.ToList(), "CategoriesID", "CategoriesName");
            ViewBag.Categorieslist = Categories;
            return View();
        }
        public JsonResult Brand(string CategoriesID)
        {
           if(CategoriesID !=string.Empty)
           {
               int Cid = Convert.ToInt32(CategoriesID);
               var getlist = db.tbl_Brands.Where(x => x.CategoriesID == Cid).ToList();
               return Json(getlist, JsonRequestBehavior.AllowGet);
           }
            else
            return Json("BrandID", JsonRequestBehavior.AllowGet);
        }
              
        public ActionResult Create()
        {
            Categories();
            return View();
        }

        // POST: Item/Create
        [HttpPost]
        public ActionResult Create(tbl_Item obj, HttpPostedFileBase image)
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
                obj.itemimage = imgpath;
               
               db.Sp_Item_insert(obj.BrandID, obj.ItemName, obj.itemimage);
               

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Categories();
            Sp_Item_Display_Result edit = db.Sp_Item_Display(id).FirstOrDefault();
            return View(edit);
        }

        // POST: Item/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,tbl_Item obj,HttpPostedFileBase image)
        {
            try
            {
                string imgpath = string.Empty;
                if (image != null)
                {
                    string filename = Path.GetFileName(image.FileName);
                    imgpath = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(image.FileName));
                    image.SaveAs(imgpath);
                    imgpath = filename;
                }
                obj.itemimage = imgpath;
                ViewBag.FileStatus = "YES";
                db.Sp_Item_update(obj.ItemID, obj.BrandID, obj.ItemName, obj.itemimage);

                // TODO: Add update logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Item/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                db.Sp_Item_Delete(id).ToString();
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

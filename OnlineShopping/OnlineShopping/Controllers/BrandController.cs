using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.Models.DB;
using OnlineShopping.Models;
using System.IO;
using System.Data.Entity;
namespace OnlineShopping.Controllers
{
    public class BrandController : Controller
    {
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        // GET: Brand
        public ActionResult List()
        {
            //IList<> list = db.Sp_Brands_Details().ToList();
            IList<Sp_Brands_Details_Result> list=db.Sp_Brands_Details().ToList();
            return View(list);
        }

        // GET: Brand/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
         public ActionResult Categories()
        {
            List<tbl_Categories> list = new List<tbl_Categories>();
            list = db.tbl_Categories.ToList();
            ViewBag.Categoriess = new SelectList(list, "CategoriesID", "CategoriesName");
            return View();
        }
        // GET: Brand/Create
        public ActionResult Create()
        {
            Categories();
            return View();
            
        }

        // POST: Brand/Create
        [HttpPost]
        public ActionResult Create(tbl_Brands obj, HttpPostedFileBase image)
        {
            try
            {
                string imgPath = string.Empty;
                if(image!=null)
                {
                    string filename = Path.GetFileName(image.FileName);
                    imgPath = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(image.FileName));
                    image.SaveAs(imgPath);
                    imgPath = filename;
                    //obj.Brandimage = filename;
                }
                obj.Brandimage = imgPath;
                ViewBag.Filestatus = "YES";
                    db.Sp_Brands_insert(obj.CategoriesID, obj.BrandName, obj.Brandimage);
                    return RedirectToAction("List");
            }
            // TODO: Add insert logic her
            catch
            {
                return View();
            }
           
        }

        // GET: Brand/Edit/5
        public ActionResult Edit(int id)
        {
            Categories();
            Sp_Brands_Display_Result edit = db.Sp_Brands_Display(id).FirstOrDefault();
            return View(edit);
        }

        // POST: Brand/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, tbl_Brands obj,HttpPostedFileBase image)
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
                obj.Brandimage = imgpath;
                ViewBag.FileStatus = "YES";
             
                // TODO: Add update logic here
               db.Sp_Brands_update(obj.BrandID, obj.CategoriesID, obj.BrandName, obj.Brandimage);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Brand/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Brand/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                db.Sp_Brands_Delete(id).ToString();
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

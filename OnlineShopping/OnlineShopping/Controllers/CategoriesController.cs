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
    public class CategoriesController : Controller
    {
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        // GET: Categories
        public ActionResult List()
        {
            IList<Sp_categories_Details_Result> list = db.Sp_categories_Details().ToList();
            return View(list);
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Categories/Create 
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create  upload sir are u there sir plz upload run 
        [HttpPost]
        public ActionResult Create(tbl_Categories obj, HttpPostedFileBase image)
        {

            try
            {

                // string empty path  .. Ok run the app ok sir
                string imgPath = string.Empty;

                // Check the image file
                if (image != null)
                {
                    string filename = Path.GetFileName(image.FileName); 
                    // Get the location of image path
                    imgPath = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(image.FileName));
                    // Save the image 
                    image.SaveAs(imgPath);

                    imgPath = filename;
                }
                // Assign path to category 
                obj.Categoriesimage = imgPath;

                // Assign message to viewbag
                ViewBag.FileStatus = "File uploaded successfully.";

                db.Sp_Categories_insert(obj.CategoriesName, obj.Categoriesimage);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Sp_Categories_Display_Result edit = db.Sp_Categories_Display(id).FirstOrDefault();
            return View(edit);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, HttpPostedFileBase image,tbl_Categories obj)
        {
            try
            {
                string imgPath = string.Empty;
                // Check the image file
                if (image != null)
                {
                    string filename = Path.GetFileName(image.FileName);
                    // Get the location of image path
                    imgPath = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(image.FileName));
                    // Save the image 
                    image.SaveAs(imgPath);
                    imgPath = filename;
                }
                // Assign path to category 
                obj.Categoriesimage = imgPath;
                // Assign message to viewbag
                ViewBag.FileStatus = "File uploaded successfully.";
                db.Sp_Categories_update(obj.CategoriesID, obj.CategoriesName, obj.Categoriesimage);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Categories/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                db.Sp_Categories_Delete(id).ToString();

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
    }
}

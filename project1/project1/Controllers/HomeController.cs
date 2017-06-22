using project1.Models;
using project1.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1.Controllers
{
    public class HomeController : Controller
    {
        myproEntities db = new myproEntities();
        // GET: Home
        public ActionResult Index()
        {
            // Get All records in List
            IList<allrecords_Result> dat = db.allrecords().ToList();

            return View(dat);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Mymodel obj)
        {
            try
            {
                db.Register(obj.FirstName, obj.LastName, obj.Email, obj.Gender);
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            // Get Selected Single Records in first defualt
            getrecord_Result EditRecord = db.getrecord(id).FirstOrDefault();

            return View(EditRecord);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Mymodel u1)
        {
            try
            {
                // TODO: Add update logic here
                db.Updaterecord(u1.id, u1.FirstName, u1.LastName, u1.Email, u1.Gender);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {

            return View();
        }

        // POST: Home/Delete/5
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

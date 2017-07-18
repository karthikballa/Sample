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
    public class LoginPageController : Controller
    {
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        // GET: LoginPage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            ViewBag.LoginError="";
            return View();
        }
        [HttpPost]
        public ActionResult Login(tbl_User_Registration obj)
        {

            List<tbl_User_Registration> UserInfo = db.tbl_User_Registration.Where(x => x.EmailID == obj.EmailID && x.Password == obj.Password).ToList();
            Session["EmailID"] = obj.EmailID;
            if (UserInfo.Count > 0)
            {
                Session["UserInfo"] = UserInfo as List<tbl_User_Registration>;
                return RedirectToAction("Categorieslist", "UCategories");
            }
            else
            {
                ViewBag.LoginError="User Email and password entered wrong.";
                return View();
            }
        }
        // GET: LoginPage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LoginPage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoginPage/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: LoginPage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LoginPage/Edit/5
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

        // GET: LoginPage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LoginPage/Delete/5
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

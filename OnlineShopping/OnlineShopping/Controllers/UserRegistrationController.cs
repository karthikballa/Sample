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
    public class UserRegistrationController : Controller
    {
        // GET: UserRegistration
        OnlineShoppingEntities2 db = new OnlineShoppingEntities2();
        public ActionResult List()
        {
            IList<Sp_UserRegistration_Details_Result> list = db.Sp_UserRegistration_Details().ToList();
            return View(list);
        }

        // GET: UserRegistration/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserRegistration/Create
        public ActionResult Create()
        {
            Country();
            return View();
        }
        public ActionResult Country()
        {
            List<tbl_Countrys> list = new List<tbl_Countrys>();
            list = db.tbl_Countrys.ToList();
            ViewBag.Country = new SelectList(list, "CountryID", "CountryName");
            return View();
        }

        // POST: UserRegistration/Create
        [HttpPost]
        public ActionResult Create(tbl_User_Registration obj)
        {
            try
            {
                
                db.Sp_Userregistration_Insert(obj.FirstName, obj.LastName, obj.MiddleName, obj.EmailID, obj.Password, obj.Gender, obj.MobileNumber, obj.CountryName, obj.StateName, obj.CityName, obj.Address1, obj.Address2,obj.IsActive);
                // TODO: Add insert logic here

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
        public JsonResult State(string CountryName)
        {
            if (CountryName != string.Empty)
            {
                int BID = Convert.ToInt32(CountryName);
                var getlist = db.tbl_State.Where(x => x.CountryID == BID).ToList();
                return Json(getlist, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("", JsonRequestBehavior.AllowGet);
            }
        }
        public JsonResult City(string StateName)
        {
            if (StateName != string.Empty)
            {
                int Bid = Convert.ToInt32(StateName);
                var getlist = db.tbl_City.Where(x => x.StateID == Bid).ToList();
                return Json(getlist, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("", JsonRequestBehavior.AllowGet);
            }
        }

        // GET: UserRegistration/Edit/5
        public ActionResult Edit(int id)
        {
            Country();
            Sp_UserRegistration_Display_Result edit = db.Sp_UserRegistration_Display(id).FirstOrDefault();
            return View(edit);
        }

        // POST: UserRegistration/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,tbl_User_Registration obj)
        {
            try
            {
                // TODO: Add update logic here
                db.Sp_Userregistration_Update(obj.UserID, obj.FirstName, obj.LastName, obj.MiddleName, obj.EmailID, obj.Password, obj.Gender, obj.MobileNumber, obj.CountryName, obj.StateName, obj.CityName,obj.Address1,obj.Address2, obj.IsActive);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserRegistration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserRegistration/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                db.Sp_UserRegistraion_Delete(id).ToString();
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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class User_TableController : Controller
    {
        private Applicant_InformationEntities6 db = new Applicant_InformationEntities6();

        // GET: User_Table
        public ActionResult Index()
        {
            return View(db.User_Table.ToList());
        }

        // GET: User_Table/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Table user_Table = db.User_Table.Find(id);
            if (user_Table == null)
            {
                return HttpNotFound();
            }
            return View(user_Table);
        }

        // GET: User_Table/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User_Table/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,Father_Name,CNIC,Current_Address,Product_Name,Phone_Number")] User_Table user_Table)
        {
            if (ModelState.IsValid)
            {
                db.User_Table.Add(user_Table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user_Table);
        }

        // GET: User_Table/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Table user_Table = db.User_Table.Find(id);
            if (user_Table == null)
            {
                return HttpNotFound();
            }
            return View(user_Table);
        }

        // POST: User_Table/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Father_Name,CNIC,Current_Address,Product_Name,Phone_Number")] User_Table user_Table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user_Table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user_Table);
        }

        // GET: User_Table/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User_Table user_Table = db.User_Table.Find(id);
            if (user_Table == null)
            {
                return HttpNotFound();
            }
            return View(user_Table);
        }

        // POST: User_Table/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User_Table user_Table = db.User_Table.Find(id);
            db.User_Table.Remove(user_Table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

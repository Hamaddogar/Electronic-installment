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
    public class Addmin_TableController : Controller
    {
        private Applicant_InformationEntities8 db = new Applicant_InformationEntities8();

        // GET: Addmin_Table
        [HttpGet]
        public ActionResult Index()
        {
            return View(db.Addmin_Table.ToList());
        }
        [HttpPost]
        public ActionResult Index(string CNIC,Addmin_Table adm)
        {
            var amdn = db.Addmin_Table.ToList().Where(p => p.CNIC.StartsWith(CNIC));
            return View(amdn);
        }

        // GET: Addmin_Table/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Addmin_Table addmin_Table = db.Addmin_Table.Find(id);
            if (addmin_Table == null)
            {
                return HttpNotFound();
            }
            return View(addmin_Table);
        }

        // GET: Addmin_Table/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Addmin_Table/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Name,CNIC,Product_Name,Payed_Installment,C_Remaning_Installment")] Addmin_Table addmin_Table)
        {
            if (ModelState.IsValid)
            {
                db.Addmin_Table.Add(addmin_Table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addmin_Table);
        }

        // GET: Addmin_Table/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Addmin_Table addmin_Table = db.Addmin_Table.Find(id);
            if (addmin_Table == null)
            {
                return HttpNotFound();
            }
            return View(addmin_Table);
        }

        // POST: Addmin_Table/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,CNIC,Product_Name,Payed_Installment,C_Remaning_Installment")] Addmin_Table addmin_Table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addmin_Table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addmin_Table);
        }

        // GET: Addmin_Table/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Addmin_Table addmin_Table = db.Addmin_Table.Find(id);
            if (addmin_Table == null)
            {
                return HttpNotFound();
            }
            return View(addmin_Table);
        }

        // POST: Addmin_Table/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Addmin_Table addmin_Table = db.Addmin_Table.Find(id);
            db.Addmin_Table.Remove(addmin_Table);
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

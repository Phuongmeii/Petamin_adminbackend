using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nhom8_Web.Migrations;
using Nhom8_Web.Models;
using DichVu = Nhom8_Web.Models.DichVu;

namespace Nhom8_Web.Controllers
{
    public class DichVusController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: DichVus
        public ActionResult Index()
        {
            return View(db.Dichvus.ToList());
        }

        // GET: DichVus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DichVu dichVu = db.Dichvus.Find(id);
            if (dichVu == null)
            {
                return HttpNotFound();
            }
            return View(dichVu);
        }

        // GET: DichVus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DichVus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DichVu dichVu)
        {
            if (ModelState.IsValid)
            {
                if (dichVu.PictureUpload != null && new byte[dichVu.PictureUpload.ContentLength] != null)
                {
                    dichVu.HinhAnh = new byte[dichVu.PictureUpload.ContentLength];
                    dichVu.PictureUpload.InputStream.Read(dichVu.HinhAnh, 0,
                    dichVu.PictureUpload.ContentLength);
                }
                db.Dichvus.Add(dichVu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dichVu);
        }

        // GET: DichVus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DichVu dichVu = db.Dichvus.Find(id);
            if (dichVu == null)
            {
                return HttpNotFound();
            }
            return View(dichVu);
        }

        // POST: DichVus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DichVu dichVu)
        {
            if (dichVu.PictureUpload != null && new byte[dichVu.PictureUpload.ContentLength] != null)
            {
                dichVu.HinhAnh = new byte[dichVu.PictureUpload.ContentLength];
                dichVu.PictureUpload.InputStream.Read(dichVu.HinhAnh, 0,
                dichVu.PictureUpload.ContentLength);
            }

            if (ModelState.IsValid)
            {
                db.Entry(dichVu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dichVu);
        }

        // GET: DichVus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DichVu dichVu = db.Dichvus.Find(id);
            if (dichVu == null)
            {
                return HttpNotFound();
            }
            return View(dichVu);
        }

        // POST: DichVus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DichVu dichVu = db.Dichvus.Find(id);
            db.Dichvus.Remove(dichVu);
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

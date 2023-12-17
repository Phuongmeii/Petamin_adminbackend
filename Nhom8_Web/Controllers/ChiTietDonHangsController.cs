using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nhom8_Web.Models;

namespace Nhom8_Web.Controllers
{
    public class ChiTietDonHangsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ChiTietDonHangs
        public ActionResult Index()
        {
            var donHangChiTiets = db.DonHangChiTiets.Include(c => c.DichVuObj).Include(c => c.DonHangObj).Include(c => c.SanPhamObj);
            return View(donHangChiTiets.ToList());
        }

        // GET: ChiTietDonHangs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHang chiTietDonHang = db.DonHangChiTiets.Find(id);
            if (chiTietDonHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietDonHang);
        }

        // GET: ChiTietDonHangs/Create
        public ActionResult Create()
        {
            ViewBag.DichVuID = new SelectList(db.Dichvus, "ID", "TenDichVu");
            ViewBag.DonHangID = new SelectList(db.DonHangs, "ID", "ID");
            ViewBag.SanPhamID = new SelectList(db.SanPhams, "ID", "TenSanPham");
            return View();
        }

        // POST: ChiTietDonHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ChiTietDonHang chiTietDonHang)
        {
            if (ModelState.IsValid)
            {
                //DonHang donHang = new DonHang();
                //if (chiTietDonHang.DichVuID != null)
                //{
                //    donHang.TongTien = chiTietDonHang.DichVuObj.GiaTien * chiTietDonHang.SoLuong;
                //}
                //else
                //    donHang.TongTien = chiTietDonHang.SanPhamObj.GiaTien * chiTietDonHang.SoLuong;

                //db.DonHangs.Add(donHang);
                //chiTietDonHang.DonHangID = db.DonHangs.Count();
                db.DonHangChiTiets.Add(chiTietDonHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DichVuID = new SelectList(db.Dichvus, "ID", "TenDichVu", chiTietDonHang.DichVuID);
            ViewBag.DonHangID = new SelectList(db.DonHangs, "ID", "ID", chiTietDonHang.DonHangID);
            ViewBag.SanPhamID = new SelectList(db.SanPhams, "ID", "TenSanPham", chiTietDonHang.SanPhamID);
            return View(chiTietDonHang);
        }

        // GET: ChiTietDonHangs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHang chiTietDonHang = db.DonHangChiTiets.Find(id);
            if (chiTietDonHang == null)
            {
                return HttpNotFound();
            }
            ViewBag.DichVuID = new SelectList(db.Dichvus, "ID", "TenDichVu", chiTietDonHang.DichVuID);
            ViewBag.DonHangID = new SelectList(db.DonHangs, "ID", "ID", chiTietDonHang.DonHangID);
            ViewBag.SanPhamID = new SelectList(db.SanPhams, "ID", "TenSanPham", chiTietDonHang.SanPhamID);
            return View(chiTietDonHang);
        }

        // POST: ChiTietDonHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DonHangID,SanPhamID,DichVuID,SoLuong")] ChiTietDonHang chiTietDonHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietDonHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DichVuID = new SelectList(db.Dichvus, "ID", "TenDichVu", chiTietDonHang.DichVuID);
            ViewBag.DonHangID = new SelectList(db.DonHangs, "ID", "ID", chiTietDonHang.DonHangID);
            ViewBag.SanPhamID = new SelectList(db.SanPhams, "ID", "TenSanPham", chiTietDonHang.SanPhamID);
            return View(chiTietDonHang);
        }

        // GET: ChiTietDonHangs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietDonHang chiTietDonHang = db.DonHangChiTiets.Find(id);
            if (chiTietDonHang == null)
            {
                return HttpNotFound();
            }
            return View(chiTietDonHang);
        }

        // POST: ChiTietDonHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChiTietDonHang chiTietDonHang = db.DonHangChiTiets.Find(id);
            db.DonHangChiTiets.Remove(chiTietDonHang);
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

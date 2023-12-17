using Nhom8_Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nhom8_Web.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ql_index()
        {

            return View();
        }

        public ActionResult ql_dang_nhap_admin()
        {
            return View();
        }

        public ActionResult empty_gio_hang() 
        {
            return View();
        }
        public ActionResult empty_YEU_thich()
        {
            return View();
        }
        public ActionResult empty_tim_kiem()
        {
            return View();
        }
        public ActionResult TDK_Bang_dieu_khien()
        {
            return View();
        }
        public ActionResult TDK_chinh_sua_dia_chi()
        {
            return View();
        }
        public ActionResult TDK_chinh_sua_pro_file()
        {
            return View();
        }
        public ActionResult TDK_chon_dia_chi_mac_dinh()
        {
            return View();
        }
        public ActionResult TDK_dia_chi_giao_hang_book()
        {
            return View();
        }
        public ActionResult TDK_don_hang_cua_toi()
        {
            return View();
        }
        public ActionResult TDK_huy_don_hang()
        {
            return View();
        }
        public ActionResult TDK_phuong_thuc_thanh_toan()
        {
            return View();
        }
        public ActionResult TDK_quan_ly_don_hang()
        {
            return View();
        }
        public ActionResult TDK_them_dia_chi()
        {
            return View();
        }
        public ActionResult TDK_theo_doi_don_hang()
        {
            return View();
        }
        public ActionResult TDK_thong_tin_cua_toi()
        {
            return View();
        }
        public ActionResult Trang_blog()
        {
            return View();
        }
        public ActionResult Trang_chi_tiet_blog_1()
        {
            return View();
        }
        public ActionResult Trang_chi_tiet_blog_2()
        {
            return View();
        }
        public ActionResult Trang_chi_tiet_blog_3()
        {
            return View();
        }
        public ActionResult Trang_chi_tiet_dich_vu()
        {
            return View();
        }
        public ActionResult Trang_chi_tiet_dich_vu_01()
        {
            return View();
        }
        public ActionResult Trang_chi_tiet_dich_vu_02()
        {
            return View();
        }
        public ActionResult Trang_chi_tiet_dich_vu_03()
        {
            return View();
        }
        public ActionResult Trang_chi_tiet_dich_vu_04()
        {
            return View();
        }
        public ActionResult Trang_chi_tiet_dich_vu_05()
        {
            return View();
        }
        public ActionResult Trang_chi_tiet_dich_vu_06()
        {
            return View();
        }

        public ActionResult Trang_chi_tiet_san_pham()
        {
            return View();
        }
        public ActionResult Trang_chi_tiet_san_pham_2()
        {
            return View();
        }
        public ActionResult Trang_dang_ky()
        {
            return View();
        }
        public ActionResult Trang_dang_nhap()
        {
            return View();
        }
        public ActionResult Trang_dich_vu()
        {
            return View();
        }
        public ActionResult Trang_FAQ()
        {
            return View();
        }
        public ActionResult Trang_gio_hang()
        {
            return View();
        }
        public ActionResult Trang_gioi_thieu()
        {
            return View();
        }
        public ActionResult Trang_Lien_he()
        {
            return View();
        }
        public ActionResult Trang_Quen_mat_khau()
        {
            return View();
        }
        public ActionResult Trang_san_pham()
        {
            return View();
        }
        public ActionResult Trang_san_pham_2()
        {
            return View();
        }
        public ActionResult Trang_Thanh_Toan()
        {
            return View();
        }
        public ActionResult Yeu_thich()
        {
            return View();
        }

    }
}
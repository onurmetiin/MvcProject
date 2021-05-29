using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class istatistikController : Controller
    {

        public ActionResult Index()
        {
            using (Context context =new Context())
            {
            ViewBag.KategoriSayisi = context.Categories.ToList().Count().ToString();
            ViewBag.YazilimBaslikSayisi = context.Headers.Where(x => x.CategoryID == 24).ToList().Count().ToString();
            ViewBag.AgecenYazarSayisi = context.Writers.Where(x => x.WriterNane.Contains("a")).ToList().Count().ToString();
            ViewBag.TopKategori = context.Categories.Max(x => x.CategoryName).ToString();
            int StatusTrue = context.Categories.Where(x => x.CategoryStatus == true).Count();
            int StatusFalse = context.Categories.Where(x => x.CategoryStatus == false).Count();
            ViewBag.StatusFark = StatusTrue - StatusFalse;
            }
            return View();
        }
    }
}
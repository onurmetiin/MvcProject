using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HeaderController : Controller
    {
        HeaderManager headerManager = new HeaderManager(new EfHeaderDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        public ActionResult Index()
        {
            var headerValues = headerManager.GetList();
            return View(headerValues);
        }

        [HttpGet]
        public ActionResult AddHeader()
        {
            List<SelectListItem> valuecategory = (from x in categoryManager.GetList()
                select new SelectListItem
                    {
                       Text = x.CategoryName,
                       Value = x.CategoryID.ToString()
                }).ToList();

            List<SelectListItem> valuewriter = (from x in writerManager.Getlist()
                select new SelectListItem
                    { 
                        Text = x.WriterNane + " " + x.WriterSurname,
                        Value = x.WriterID.ToString()
                    }).ToList();
            ViewBag.valueCategory = valuecategory;
            ViewBag.valueWriter = valuewriter;
            return View();   
        }

        [HttpPost]
        public ActionResult AddHeader(Header header)
        {
            header.HeaderDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            headerManager.HeaderAdd(header);
            return RedirectToAction("Index");
        }
    }
}
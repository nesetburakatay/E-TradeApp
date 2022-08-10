using E_TradeAppUI.Entity;
using E_TradeAppUI.Identity;
using E_TradeAppUI.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity.EntityFramework;

namespace E_TradeAppUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        MainPageQuery mq = new MainPageQuery();

        // GET: Home
        public ActionResult Index()
        {
            return View(mq.MainQuery()
);
        }
        public ActionResult Details(int? id)
        {
            if (id == null || id == 0)
            {
                return View("Index", mq.MainQuery());
            }

            return View(db.Products.Find(id));
        }
        public ActionResult List(int? id)
        {
            var ToUpload = db.Products.Where(i => i.IsApproved == true).AsQueryable();

            if (id != null)
            {
                ToUpload = ToUpload.Where(i => i.CategoryId == id);
            }

            return View(ToUpload.ToList());
        }
        public PartialViewResult GetCategories()
        {
            return PartialView(db.Categories.ToList());
        }
    }
}
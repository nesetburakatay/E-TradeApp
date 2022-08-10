using E_TradeAppUI.Entity;
using E_TradeAppUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_TradeAppUI.Controllers
{
    public class CartController : Controller
    {
        DataContext db = new DataContext();

        // GET: Cart
        public ActionResult Index()
        {
            return View(GetCart()); //"GetCart()" metodunu çağırarak sisteme bağlanan her kullanıcı için yeni bir kart oluşutulur ve bu kart sadece o kullanıcıya gösterilir. session kullanılarak yapılır.
        }
        public ActionResult AddToCart(int Id)
        {
            var product= db.Products.Where(i => i.Id == Id).FirstOrDefault();
            GetCart().AddProduct(product, 1);
            return RedirectToAction("Index");
        }
        public ActionResult RemoveFromCart(int Id)
        {
            var product = db.Products.Where(i => i.Id == Id).FirstOrDefault();
            GetCart().DeleteProduct(product);
            return RedirectToAction("Index");
        }

        public Cart GetCart()
        {
            var cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        public PartialViewResult Summary()
        {
            return PartialView(GetCart());
        }
    }
}
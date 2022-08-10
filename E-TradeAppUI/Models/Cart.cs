using E_TradeAppUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_TradeAppUI.Models
{
    public class Cart
    {
        private List<CartLine> _cartLines = new List<CartLine>();
        public List<CartLine> CartLines { get { return _cartLines; } set { } }

        public void AddProduct(Product product, int quantity)
        {
            var Line = _cartLines.Where(i => i.Product.Id == product.Id).FirstOrDefault();
            if (Line == null)
            {
                _cartLines.Add(new CartLine() { Product = product, Quantity = quantity });
            }
            else
            {
                Line.Quantity += quantity;
            }
        }
        public void DeleteProduct(Product product)
        {
            var aaa = _cartLines.Where(i => i.Product.Id == product.Id).FirstOrDefault();
            _cartLines.Remove(aaa);
        }

        public double Total()
        {
            return _cartLines.Sum(i => i.Quantity * i.Product.Price);//incelelllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllllll
        }
        public void Clear()
        {
            _cartLines.Clear();
        }

    }
}
public class CartLine
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
}


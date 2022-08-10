using E_TradeAppUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_TradeAppUI.Models
{
    public class MainPageQuery
    {
        DataContext db = new DataContext();
        public List<ProductModel> MainQuery()
        {
            var ToIndex = db.Products
                .Where(i => i.IsHome == true)
                .Select(i => new ProductModel
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 30 ? i.Description.Substring(0, 30) + "..." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Picture = i.Picture,
                    IsHome = i.IsHome,
                    IsApproved = i.IsApproved
                })
                .ToList();

            return ToIndex;
        }
    }
}
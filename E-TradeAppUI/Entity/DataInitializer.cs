using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_TradeAppUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext db)
        {
            var productNum = 20;
            var categorytNum = 6;


            var CategoryList = new List<Category>() { };

            for (int i = 0; i < categorytNum; i++)
            {
                var generatedCategoryItem = new Category()
                {
                    Name = $"Kategori-{i + 1}",
                    Description = "Lorem Ipsum is simply"
                };
                CategoryList.Add(generatedCategoryItem);
            };
            foreach (var item in CategoryList)
            {
                db.Categories.Add(item);
            }
            db.SaveChanges();

            string[] rndProductName = { "Ferrari", "Lamborghini", "Maserati", "Mercedes", "Ford", "Mazda", };
            string[] rndPictureName = { "1.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", };
            bool[] rndIsApproved = { true, false };

            var ProductList = new List<Product>() { };
            var rndnum = new Random();

            for (int i = 0; i < productNum; i++)
            {
                var generatedProductItem = new Product()
                {
                    Name = rndProductName[rndnum.Next(rndProductName.Count())],
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy",
                    Price = rndnum.Next(200, 4000),
                    Stock = rndnum.Next(1, 200),
                    Picture = rndPictureName[rndnum.Next(rndPictureName.Count())],
                    IsHome = rndIsApproved[rndnum.Next(rndIsApproved.Count())],
                    IsApproved = rndIsApproved[rndnum.Next(rndIsApproved.Count())],
                    CategoryId = rndnum.Next(1, categorytNum + 1)
                };
                ProductList.Add(generatedProductItem);
            };

            foreach (var item in ProductList)
            {
                db.Products.Add(item);
            }
            db.SaveChanges();

            base.Seed(db);
        }
    }
}
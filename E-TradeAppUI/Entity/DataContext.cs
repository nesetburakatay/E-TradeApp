using E_TradeAppUI.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace E_TradeAppUI.Entity
{
    public class DataContext:DbContext
    {
        public DataContext() : base("dataConnection") //ana dizindeki "Web.config" dosyası altındaki "dataConnection" isimli connection stringe bağlanıyor.
        {
            Database.SetInitializer(new DataInitializer()); // "DataContext classı çağırılınca ilk olarak içindeki constructor çalışdı. ardından constructor içindeki "dataInitializer.cs" yi başlattık 
            /*Database.SetInitializer(new IdentityInitializer());*/ //Identity init
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
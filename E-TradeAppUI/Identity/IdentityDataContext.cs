using E_TradeAppUI.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace E_TradeAppUI.Identity
{
    public class IdentityDataContext:IdentityDbContext<ApplicationUser>
    {

        public IdentityDataContext() : base("dataConnectionIdentity") //ana dizindeki "Web.config" dosyası altındaki "dataConnection" isimli connection stringe bağlanıyor.
        {
        }
    }
}
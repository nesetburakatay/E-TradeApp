using E_TradeAppUI.Entity;
using E_TradeAppUI.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace E_TradeAppUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //-------------------------------- creates a test user to initiliaze Identity database
        private UserManager<ApplicationUser> UserManager;
        //-------------------------------- creates a test user to initiliaze Identity database


        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer(new IdentityInitializer());



            //-------------------------------- creates a test user to initiliaze Identity database. when this methot is started, "IdentityInitializer.cs" under "ýdentity" folder starts and create dummy database
            var UserStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            UserManager = new UserManager<ApplicationUser>(UserStore);
            ApplicationUser user = new ApplicationUser();
            user.Name = "test";
            user.Surname = "test";
            user.Email = "test@hotmail.com";
            user.UserName = "test";
            IdentityResult result = UserManager.Create(user, "12345678");
            //-------------------------------- creates a test user to initiliaze Identity database
        }
    }
}

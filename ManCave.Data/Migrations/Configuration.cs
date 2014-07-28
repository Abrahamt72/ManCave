namespace ManCave.Data.Migrations
{
    using ManCave.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManCave.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ManCave.Data.ApplicationDbContext context)
        {
            var RoleStore = new RoleStore<IdentityRole>(context);
            var RoleManager = new RoleManager<IdentityRole>(RoleStore);
            var UserStore = new UserStore<ApplicationUser>(context);
            var UserManager = new UserManager<ApplicationUser>(UserStore);


            if (!RoleManager.RoleExists("Admin"))
            {
                IdentityRole Role = new IdentityRole("Admin");
                RoleManager.Create(Role);
            }

            if (!RoleManager.RoleExists("User"))
            {
                IdentityRole Role = new IdentityRole("User");
                RoleManager.Create(Role);
            }
            

            if (!context.Users.Any(u => u.UserName == "Admin"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "Admin";
                UserManager.Create(User, "123456");
                UserManager.AddToRole(User.Id, "Admin");
            }

            if (!context.Users.Any(u => u.UserName == "Abraham"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "Abraham";
                UserManager.Create(User, "123456");
                UserManager.AddToRole(User.Id, "User");
            }
            if (!context.Users.Any(u => u.UserName == "Eric"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "Eric";
                UserManager.Create(User, "123456");
                UserManager.AddToRole(User.Id, "User");
            }
            if (!context.Users.Any(u => u.UserName == "Josh"))
            {
                ApplicationUser User = new ApplicationUser();
                User.UserName = "Josh";
                UserManager.Create(User, "123456");
                UserManager.AddToRole(User.Id, "User");
            }
        }
    }
}

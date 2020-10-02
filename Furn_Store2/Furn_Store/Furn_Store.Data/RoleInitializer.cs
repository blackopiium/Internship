using Furn_Store.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Furn_Store.Data
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<MyUser> userManager, RoleManager<MyRole> roleManager)
        {
            string adminUsername = "admin";
            string adminEmail = "admin@gmail.com";
            string password = "qwerty7P";
            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new MyRole { Name = "admin" });
            }
            if (await roleManager.FindByNameAsync("user") == null)
            {
                await roleManager.CreateAsync(new MyRole { Name = "user" });
            }
            if (await userManager.FindByNameAsync(adminUsername) == null)
            {
                MyUser admin = new MyUser { Email = adminEmail, UserName = adminUsername };
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }
    }
}

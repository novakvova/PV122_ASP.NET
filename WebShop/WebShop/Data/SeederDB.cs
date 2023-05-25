﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebShop.Constants;
using WebShop.Data.Entities;
using WebShop.Data.Entities.Identity;

namespace WebShop.Data
{
    public static class SeederDB
    {
        public static void SeedData(this IApplicationBuilder app)
        {
            using(var scope=app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var service = scope.ServiceProvider;
                var context = service.GetRequiredService<AppEFContext>();
                var userNamager = service.GetRequiredService<UserManager<UserEntity>>();
                var roleNamager = service.GetRequiredService<RoleManager<RoleEntity>>();
                context.Database.Migrate(); //автоматично запускає міграції на БД

                if(!context.Categories.Any())
                {
                    CategoryEntity categoryEntity = new CategoryEntity()
                    {
                        Name = "Піжами",
                        Image = "1.jpg",
                        Priority = 1,
                        DateCreated = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc),
                        Description = "Для нічних прогулок"
                    };
                    context.Categories.Add(categoryEntity);
                    context.SaveChanges();
                }
                if(!context.Roles.Any())
                {
                    foreach(string name in Roles.All)
                    {
                        var role = new RoleEntity
                        {
                            Name = name
                        };
                        var result = roleNamager.CreateAsync(role).Result;
                    }
                }
                if(!context.Users.Any())
                {
                    var user = new UserEntity()
                    {
                        FirstName = "Вова",
                        LastName = "Новак",
                        Email = "admin@gmail.com",
                        UserName = "admin@gmail.com"
                    };
                    var result = userNamager.CreateAsync(user,"123456").Result;
                    if(result.Succeeded)
                    {
                        result = userNamager.AddToRoleAsync(user, Roles.Admin).Result;
                    }
                }

            }
        }
    }
}

using Project.Data.Entities;
using Project.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
       
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                    Name = "Áo nữ",
                    Description = "Sản phẩm áo thời trang nam",
                },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active,
                     Name = "Áo nam",
                     Description = "Sản phẩm áo thời trang nam",

                 });
            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   Name = "Áo sơ mi nam trắng Việt Tiến",
                   Description = "Áo sơ mi nam trắng Việt Tiến",
                   Details = "Áo sơ mi nam trắng Việt Tiến",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0
               }, new Product()
               {
                   Id = 2,
                   DateCreated = DateTime.Now,
                   Name = "Áo sơ mi nữ trắng Việt Tiến",
                   Description = "Áo sơ mi nữ trắng Việt Tiến",
                   Details = "Áo sơ mi nữ trắng Việt Tiến",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0
               }, new Product()
                    {
                        Id = 6,
                        DateCreated = DateTime.Now,
                        Name = "Áo sơ mi nữ trắng Việt Tiến",
                        Description = "Áo sơ mi nữ trắng Việt Tiến",
                        Details = "Áo sơ mi nữ trắng Việt Tiến",
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0
                });
            
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
            
            //8D04DCE3-969A-435D-BBA4-DF3F325983DC
            //// any guid
            //string roleId ="8D04DCE2-969A-435D-BBA4-DF3F325983DC";
            //string adminId = "69BD714F-9576-45BA-B5B7-F00649BE00DE";
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                    Name = "admin",
                    NormalizedName = "ADMIN",
                }, new IdentityRole
                {
                    Id = "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                    Name = "editor",
                    NormalizedName = "EDITOR",
                });

                var hasher = new PasswordHasher<AppUser>();
                modelBuilder.Entity<AppUser>().HasData(new AppUser
                {
                    Id = "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "Thang-dev",
                    NormalizedUserName = "admin",
                    Email = "thangnguyenquyetvlth@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "69BD711F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "raw-account1",
                    NormalizedUserName = "raw-account1",
                    Email = "thangnguyenquyetvlth1@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth1@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "69BD712F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "raw-account2",
                    NormalizedUserName = "raw-account2",
                    Email = "thangnguyenquyetvlth2@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth2@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "61BD714F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "raw-account3",
                    NormalizedUserName = "raw-account3",
                    Email = "thangnguyenquyetvlth3@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth3@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "19BD714F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "raw-account4",
                    NormalizedUserName = "raw-account4",
                    Email = "thangnguyenquyetvlth4@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth4@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "65BD710F-9576-45BA-B5B7-F00649BE00DE",
                    UserName = "raw-account5",
                    NormalizedUserName = "raw-account5",
                    Email = "thangnguyenquyetvlth5@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth5@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "69BD714F-9576-45BA-B5B6-F00649BE01DE",
                    UserName = "raw-account6",
                    NormalizedUserName = "raw-account6",
                    Email = "thangnguyenquyetvlth6@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth6@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "09BD714F-9576-45BA-B5B7-F00649BE04DE",
                    UserName = "raw-account7",
                    NormalizedUserName = "raw-account7",
                    Email = "thangnguyenquyetvlth7@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth7@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday = DateTime.Now
                }, new AppUser
                {
                    Id = "69BD114F-9576-45BA-B4B7-F00649BE00DE",
                    UserName = "raw-account8",
                    NormalizedUserName = "raw-account8",
                    Email = "thangnguyenquyetvlth8@gmail.com",
                    NormalizedEmail = "thangnguyenquyetvlth8@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456"),
                    SecurityStamp = string.Empty,
                    Birthday=DateTime.Now
                });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                    UserId = "69BD714F-9576-45BA-B5B7-F00649BE00DE"
                }, new IdentityUserRole<string>()
                {
                    RoleId = "8D04DCE2-969A-435D-BBA4-DF3F325983DC",
                    UserId = "69BD714F-9576-45BA-B5B7-F00649BE00DE"
                });
            modelBuilder.Entity<IdentityRoleClaim<string>>().HasData(new IdentityRoleClaim<string>()
            {
                Id = -1,
                RoleId = "8D04DCE3-969A-435D-BBA4-DF3F325983DC",
                ClaimType = "permission",
                ClaimValue = "manage.user"
            }) ;
            /*
            // any guid
            var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "tedu.international@gmail.com",
                NormalizedEmail = "tedu.international@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Toan",
                LastName = "Bach",
                Dob = new DateTime(2020, 01, 31)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });

            modelBuilder.Entity<Slide>().HasData(
              new Slide() { Id = 1, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 1, Url = "#", Image = "/themes/images/carousel/1.png", Status = Status.Active },
              new Slide() { Id = 2, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 2, Url = "#", Image = "/themes/images/carousel/2.png", Status = Status.Active },
              new Slide() { Id = 3, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 3, Url = "#", Image = "/themes/images/carousel/3.png", Status = Status.Active },
              new Slide() { Id = 4, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 4, Url = "#", Image = "/themes/images/carousel/4.png", Status = Status.Active },
              new Slide() { Id = 5, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 5, Url = "#", Image = "/themes/images/carousel/5.png", Status = Status.Active },
              new Slide() { Id = 6, Name = "Second Thumbnail label", Description = "Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.", SortOrder = 6, Url = "#", Image = "/themes/images/carousel/6.png", Status = Status.Active }
              );*/
        }
    }
}
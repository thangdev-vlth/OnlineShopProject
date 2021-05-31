using Project.Data.Entities;
using Project.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

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

                 }, 
                  new Category()
                 {
                     Id = 3,
                     IsShowOnHome = false,
                     ParentId = null,
                     SortOrder = 3,
                     Status = Status.Active,
                     Name = "Áo nam",
                     Description = "Sản phẩm áo thời trang nam",

                 });
            modelBuilder.Entity<Product>().HasData(
               new Product()
               {
                   Id = 1,
                   DateCreated = DateTime.Now,
                   Name = "SKINNY",
                   Description = "99% Cotton, 1% Elastane . Bền Vững Khi Giặt Máy . Skinny Ôm Sát Và Tôn Lên Những Đường Nét Quyến Rũ Của Bạn",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured=true
                   //Categories=categories
               }, 
               new Product()
               {
                   Id = 2,
                   DateCreated = DateTime.Now,
                   Name = "ORGINAL SHORT",
                   Description = "100% Cotton . Sản Phẩm Mang Đậm Phong Cách Cá Tính Và Không Kém Phần Quyến Rũ. Orginal Được Thiết Kế Để Có Thể Ôm Sát Vòng Ba Và Tôn Lên Làn Da Của Bạn",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories = categories
               }, 
               new Product()
                    {
                        Id = -1,
                        DateCreated = DateTime.Now,
                        Name = "TOPS",
                        Description = "100% Cotton . TOPS Với Thiết Kế Cạp Cao Sẽ Mang Lại Cho Bạn Cảm Giác Tự tin , Thích Hợp Để Phối Với Những Dạng Áo ONTOP cá tính",
                        //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                        Price = 200000,
                        Stock = 0,
                        ViewCount = 0,
                        IsFeatured = true
                   //Categories = categories
               }, 
               new Product()
               {
                   Id = -2,
                   DateCreated = DateTime.Now,
                   Name = "BOYFRIEND",
                   Description = "Vâng , Đúng Như Cái Tên Của Nó, BoyFriend Sẽ Là Người Bạn Đồng Hành Của Bạn Trong Mọi Thời Điểm Của Cuộc Sống, BOYFRIEND Được Thiết Kết Để Tạo Cho Bạn Cảm Giác Thoải Mái, Sang Trọng Và An Toàn",
                   //Details = "SẢN PHẨM ĐƯỢC CUNG CẤP BỞI TARTARUSS",
                   Price = 200000,
                   Stock = 0,
                   ViewCount = 0,
                   IsFeatured = true
                   //Categories = categories
               });
            modelBuilder.Entity("CategoryProduct").HasData(
                      new Dictionary<string, object> { ["ProductsId"] = 1, ["CategoriesId"] = 1 },
                      new Dictionary<string, object> { ["ProductsId"] = 1, ["CategoriesId"] = 2 },
                      new Dictionary<string, object> { ["ProductsId"] = -2, ["CategoriesId"] = 1 },
                      new Dictionary<string, object> { ["ProductsId"] = -1, ["CategoriesId"] = 1 },
                      new Dictionary<string, object> { ["ProductsId"] = -1, ["CategoriesId"] = 2 }
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
                }, new IdentityRole
                {
                    Id = "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                    Name = "customer",
                    NormalizedName = "CUSTOMER",
                }, new IdentityRole
                {
                    Id = "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                    Name = "staff",
                    NormalizedName = "STAFF",
                });

                var hasher = new PasswordHasher<AppUser>();
                for (int i = 0; i < 10; i++)
                {
                    modelBuilder.Entity<AppUser>().HasData(new AppUser
                    {
                        Id = "10BD711F-9576-45BA-B5B7-F00649BE0" + i + "DE",
                        UserName = "raw-account-customer" + i,
                        NormalizedUserName = "raw-account-customer" + i,
                        Email = "rawaccountcustomer" + i + "@gmail.com",
                        NormalizedEmail = "rawaccountcustomer" + i + "@gmail.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "123456"),
                        SecurityStamp = string.Empty,
                        Birthday = DateTime.Now

                    });
                    modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>()
                    {
                       RoleId = "8D04DCC2-969A-435D-BBA4-DF3F315983DC",
                       UserId = "10BD711F-9576-45BA-B5B7-F00649BE0" + i + "DE"
                    });
                    
                }
                for (int i = 0; i < 10; i++)
                {
                    modelBuilder.Entity<AppUser>().HasData(new AppUser
                    {
                        Id = "11BD711F-95" + i + "6-45BA-B5B7-F00649BE0" + i + "DE",
                        UserName = "raw-account-staff" + i,
                        NormalizedUserName = "raw-account-staff" + i,
                        Email = "rawaccountstaff" + i + "@gmail.com",
                        NormalizedEmail = "rawaccountstaff" + i + "@gmail.com",
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "123456"),
                        SecurityStamp = string.Empty,
                        Birthday = DateTime.Now

                    });
                    modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                    new IdentityUserRole<string>()
                    {
                        RoleId = "1D04DCC2-969A-435D-BBA4-DF3F315983DC",
                        UserId = "11BD711F-95" + i + "6-45BA-B5B7-F00649BE0" + i + "DE"
                    });

                }
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
            modelBuilder.Entity<Cart>().HasData(new Cart()
            {
                Id=1,
                UserId= "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                ProductId=-2,
                Quantity=2,
                Price=20000,
                DateCreated=DateTime.Now
            }, new Cart()
            {
                Id = 1,
                UserId = "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                ProductId = -1,
                Quantity = 2,
                Price = 20000,
                DateCreated = DateTime.Now
            });
            
            
            //seed data for address
            string json = string.Empty;
            // read json string from file
            using (StreamReader reader = new StreamReader("data.json"))
            {
                json = reader.ReadToEnd();
            }
            List<City> cities = new List<City>();
            var obj = JsonConvert.DeserializeObject<dynamic>(json);
            int fuck = 1;
            List<int> fuckLife = new List<int>();
            List<Ward> DeadWard = new List<Ward>();
            foreach (var cityite in obj)
            {
                var city = new City();
                city.CityId = cityite["Id"];
                city.Name = cityite["Name"];
                //seed data for city
                modelBuilder.Entity<City>().HasData(new City
                {
                    CityId = city.CityId,
                    Name = city.Name
                });
                //end seed for city
                var JDistricts = cityite["Districts"];//danh sách các phường/huyện của tỉnh dạng Json

                List<District> Districts = new List<District>();
                foreach (var districtIte in JDistricts)
                {
                    var district = new District();
                    district.CityId = city.CityId;
                    district.Id = districtIte["Id"];
                    district.Name = districtIte["Name"];
                    //seed data for district
                    modelBuilder.Entity<District>().HasData(new District
                    {
                        CityId = district.CityId,
                        Id = district.Id,
                        Name = district.Name
                    });
                    //end seed for dustrict
                    var JWards = districtIte["Wards"];//danh sách huyện/xã/tt của huyện dạng Json
                    List<Ward> Wards = new List<Ward>();
                    
                    foreach (var wardite in JWards)
                    {
                        Ward ward = new Ward();
                        ward.CityId = city.CityId;
                        ward.DistrictId = district.Id;
                        ward.Id = wardite["Id"];
                        ward.Name = wardite["Name"];
                        ward.Level = wardite["Level"];
                        //duyệt xong 1 huyện/xã/thị trấn
                        Wards.Add(ward);//thêm vào danh sách xã/thị trấn của 1 huyện
                        //seed data ward
                            modelBuilder.Entity<Ward>().HasData(new Ward
                            {
                                CityId = ward.CityId,
                                DistrictId = ward.DistrictId,
                                Id = ward.Id??(fuck++).ToString(),
                                Name = ward.Name,
                                Level = ward.Level,
                            });
                        if (!fuckLife.Any(x=>x==fuck))
                        {
                            fuckLife.Add(fuck);
                            DeadWard.Add(ward);
                        }
                        //end seed ward
                    }
                    district.Wards = Wards;//gắn vào danh sách xã/tt của huyện
                    Districts.Add(district);//thêm vào danh sách huyện  của tỉnh
                    
                }
                city.Districts = Districts;//gắn vào  danh sách  huyện của tỉnh
                cities.Add(city);//thêm thành phố/tỉnh này vào danh sách các thành phố tỉnh của quốc gia
                
            }
            var count = cities.Count();//đếm thành phố
            //end seed for address
            //seed data for address card
            modelBuilder.Entity<Address>().HasData(new Address()
            {
                AddressCardId=1,
                UserId = "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                CityId= "01",
                City= "Thành phố Hà Nội",
                DistricstId="008",
                Districst= "Quận Hoàng Mai",
                WardsId= "00322",
                Ward= "Phường Hoàng Văn Thụ",
                FullName="Nguyễn Quyết Thắng",
                phoneNumber="0328025122",
                address="353 Đường Tam Trinh",
                status=0,
                isDefault=true
            });
            modelBuilder.Entity<OrderDetail>().HasData(new OrderDetail()
            {
                OrderId = 1,
                ProductId = -2,
                Quantity = 2,
                Price = 20000,
                size = "M"

            }, new OrderDetail()
            {
                OrderId = 1,
                ProductId = -1,
                Quantity = 2,
                Price = 20000,
                size = "M"

            });
            modelBuilder.Entity<Order>().HasData(new Order()
            {
                Id = 1,
                OrderDate = DateTime.Now,
                UserId = "11BD711F-9506-45BA-B5B7-F00649BE00DE",
                ShipName = "Nguyễn Quyết Thắng",
                ShipAddress = "353 Đường Tam Trinh",
                ShipEmail = "rawaccountstaff0@gmail.com",
                ShipPhoneNumber = "0328025122",
                Status = OrderStatus.New,
                CityId = "01",
                DistricstId = "008",
                WardsId = "00322"
            });
        }
    }
}
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project.Application.Catalog.Categories;
using Project.Application.Catalog.Products;
using Project.Application.Catalog.Users;
using Project.Application.Common;
using Project.Application.Mail;
using Project.Data.EF;
using Project.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            var connectionString = Configuration.GetConnectionString("ProjectOnlineShopDb");
            services.AddDbContext<ProjectDbContext>(options =>
                    options.UseSqlServer(connectionString, b => b.MigrationsAssembly("Project.WebApp")));

            services.AddRazorPages();
            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<ProjectDbContext>()
                .AddDefaultTokenProviders();
            services.AddTransient<IUserService, UserService>();
            services.ConfigureApplicationCookie(options => {
                // options.Cookie.HttpOnly = true;
                // options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = $"/User/Login";
                options.LogoutPath = $"/User/Logout";
                options.AccessDeniedPath = $"/User/Login";
            });
            // truy cap IdentityOptions
            services.Configure<IdentityOptions>(options => {
                // thiet lap ve  Password
                options.Password.RequireDigit = false; // khong bat phai co so
                options.Password.RequireLowercase = false; // khong bat phai co chu thuong
                options.Password.RequireNonAlphanumeric = false; // khong bat co ki tu dac biet
                options.Password.RequireUppercase = false; // khong bat buoc chu in
                options.Password.RequiredLength = 3; // so ki tu toi thieu cua password
                options.Password.RequiredUniqueChars = 1; // so ki tu rieng biet

                //Cau hinh lockout -khoa user
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1); // khoa 5 phut
                options.Lockout.MaxFailedAccessAttempts = 5; // that bai 5 lan thi khoa
                options.Lockout.AllowedForNewUsers = true;

                // cau hinh ve User.
                options.User.AllowedUserNameCharacters = // cac ki tu dat ten cho user
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;  // Email la duy nhat

                // cau hinh dang nhap
                options.SignIn.RequireConfirmedEmail = true;            // cau hinh xac thuc dia chi email (email phai ton tai)
                options.SignIn.RequireConfirmedPhoneNumber = false;     // xac thuc so dien thoai

            });
            services.AddOptions();                                        // kich hoat Options
            var mailsettings = Configuration.GetSection("MailSettings");  // doc config
            services.Configure<MailSettings>(mailsettings);               // dang ki de  Inject

            services.AddTransient<IEmailSender, SendMailService>();        // dang ki dich vu Mail
            
            services.Configure<SecurityStampValidatorOptions>(options =>
            {
                // tren 30 s truy cap lai se nap lai thong tin  User (Role)
                // SecurityStamp trong bang User doi -> nap lai thong tin  Security
                options.ValidationInterval = TimeSpan.FromSeconds(30);
            });
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IStorageService, FileStorageService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=AdminHome}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalog.Users;
using Project.Data.Entities;
using Project.ViewModels.common;
using Project.ViewModels.User;
using Project.Views.Shared.Components.MessagePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Controllers
{
    [Authorize(Roles = "Admin,staff")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        public UserController(IUserService userService, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userService = userService;
            _signInManager = signInManager;
            _userManager = userManager;
        }
       
        public async Task<IActionResult> Index(string role)
        {
            PageResult<UserViewModel> users = await _userService.GetAllUser(role);
            ViewData["role"] = role;
            return View(users);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login([FromRoute] string returnUrl = "")
        {
            
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        
        public async Task<IActionResult> Login([FromForm]LoginRequest model, [FromRoute] string returnUrl = null)
        {
            IdentityUser user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                user = await _userManager.FindByNameAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Tài khoản không tồn tại.");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(
                    user.UserName,
                    model.Password,
                    model.RememberMe,           // Có lưu cookie - khi đóng trình duyệt vẫn nhớ
                    false                        // CÓ ÁP DỤNG LOCKOUT
                );

            if (result.Succeeded)
            {
                var User =await _userService.GetById(user.Id);
                return RedirectToAction("Index");
            }
            
            else
            {
                
                ModelState.AddModelError(string.Empty, "Sai tên đăng nhập hoặc mật khẩu");
                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
            
    
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            //var result = await _userService.GetById(id);
            //if (result.IsSuccessed)
            //{
            //    var user = result.ResultObj;
            //    var updateRequest = new UserUpdateRequest()
            //    {
            //        Dob = user.Dob,
            //        Email = user.Email,
            //        FirstName = user.FirstName,
            //        LastName = user.LastName,
            //        PhoneNumber = user.PhoneNumber,
            //        Id = id
            //    };
            //    return View(updateRequest);
            //}
            return RedirectToAction("Error", "Home");
        }
        [HttpGet]
        public async Task<IActionResult> Details(string id,string role)
        {
            var result = await _userService.GetById(id);
            ViewData["role"] = role;
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            
            if (!ModelState.IsValid)
                return View();
            var result=await _userService.Delete(id);
            ViewData["result"] = result;
            return View();
        }
    }
}

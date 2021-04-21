using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalog.Users;
using Project.ViewModels.common;
using Project.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Controllers
{
   
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
       
        public async Task<IActionResult> Index()
        {
            PageResult<UserViewModel> users = await _userService.GetAllUser();
            return View(users);
        }
        public async Task<IActionResult> Login()
        {
            return View();
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
        public async Task<IActionResult> Details(string id)
        {
            var result = await _userService.GetById(id);
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

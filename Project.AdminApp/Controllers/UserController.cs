using Microsoft.AspNetCore.Mvc;
using Project.Application.Catalog.Users;
using Project.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.AdminApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService
        public async Task<IActionResult> Index()
        {
            //var request = new GetUserPagingRequest()
            //{
            //    Keyword = "_all"
            //};

            return View();
        }
        
    }
}

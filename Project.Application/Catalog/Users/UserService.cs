using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Data.EF;
using Project.Data.Entities;
using Project.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Application.Catalog.Users
{
    public class UserService : IUserService
    {
        private readonly ProjectDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public UserService(ProjectDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<List<UserViewModel>> GetAllUser()
        {
            var User = _userManager.Users;
            var data = await User.Select(user => new UserViewModel()
            {
                Id=user.Id,
                UserName=user.UserName,
                Email=user.Email,
                PhoneNumber=user.PhoneNumber??"",
                Fullname=user.FullName,
                Birthday=user.Birthday,
                Address=user.Address
            }).ToListAsync();
            return data ;
        }
    }
}

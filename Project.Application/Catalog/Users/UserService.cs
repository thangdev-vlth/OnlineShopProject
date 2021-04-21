using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Data.EF;
using Project.Data.Entities;
using Project.ViewModels.common;
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
        
        private readonly UserManager<AppUser> _userManager;
        public UserService(UserManager<AppUser> userManager)
        {
            
            _userManager = userManager;
        }

        

        public async Task<PageResult<UserViewModel>> GetAllUser()
        {
            var User = _userManager.Users.Where(x=>x.disable==false);
            var data = await User.Select(user => new UserViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber ?? "",
                Fullname = user.FullName,
                Birthday = user.Birthday,
                Address = user.Address,
                Disable = user.disable?"Đang Hoạt động":"Đã bị vô hiệu hóa"
            }).ToListAsync();
            return new PageResult<UserViewModel>() { Items = data };
        }

        public async Task<UserViewModel> GetById(string id)
        {
            var user = await _userManager.FindByIdAsync(id);

            var result = new UserViewModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber ?? "",
                Fullname = user.FullName,
                Birthday = user.Birthday,
                Address = user.Address,
                EmailConfirmed=user.EmailConfirmed?"Đã Xác Nhận":"Chưa Xác Nhận"
            };
            return result;
        }
        public async Task<bool> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.disable = true;
                var result =await _userManager.UpdateAsync(user);
                return result.Succeeded;
            }
            return false;
        }
    }
}

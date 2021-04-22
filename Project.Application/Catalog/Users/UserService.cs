using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project.Data.EF;
using Project.Data.Entities;
using Project.ViewModels.common;
using Project.ViewModels.User;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Application.Catalog.Users
{
    public class UserService : IUserService
    {

        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        
        private readonly ProjectDbContext _projectDbContext;
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,  ProjectDbContext projectDbContext)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            
            _projectDbContext = projectDbContext;
        }



        public async Task<PageResult<UserViewModel>> GetAllUser(string role)
        {
            var data =await (from user in _userManager.Users
                         join userRoles in _projectDbContext.UserRoles on user.Id equals userRoles.UserId
                         join roles in _projectDbContext.Roles on userRoles.RoleId equals roles.Id
                         where roles.Name == role
                         select user).Select(user => new UserViewModel()
                         {
                             Id = user.Id,
                             UserName = user.UserName,
                             Email = user.Email,
                             PhoneNumber = user.PhoneNumber ?? "",
                             Fullname = user.FullName,
                             Birthday = user.Birthday,
                             Address = user.Address,
                             Disable = user.disable ? "Đang Hoạt động" : "Đã bị vô hiệu hóa"
                         }).ToListAsync();
            
             
            //var data =  query.Select(user => new UserViewModel()
            //{
            //    Id = user.Id,
            //    UserName = user.UserName,
            //    Email = user.Email,
            //    PhoneNumber = user.PhoneNumber ?? "",
            //    Fullname = user.FullName,
            //    Birthday = user.Birthday,
            //    Address = user.Address,
            //    Disable = user.disable ? "Đang Hoạt động" : "Đã bị vô hiệu hóa"
            //});
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
                EmailConfirmed = user.EmailConfirmed ? "Đã Xác Nhận" : "Chưa Xác Nhận"
            };
            return result;
        }
        public async Task<bool> Delete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                user.disable = true;
                var result = await _userManager.UpdateAsync(user);
                return result.Succeeded;
            }
            return false;
        }
    }
}

using Project.ViewModels.common;
using Project.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Application.Catalog.Users
{
    public interface IUserService
    {
        Task<PageResult<UserViewModel>> GetAllUser(string role);
        Task<UserViewModel> GetById(String id);
        Task<bool> Delete(string id);
        
    }
}

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
        Task<List<UserViewModel>> GetAllUser();
    }
}

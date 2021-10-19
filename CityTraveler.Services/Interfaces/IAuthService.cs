
using CityTraveler.Domain.Entities;
using CityTraveler.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services.Interfaces
{
    public interface IAuthService
    {
        Task<UserProfileModel> Register(RegisterModel model);
        Task<UserProfileModel> Login(LoginModel model);
        Task<bool> UpdateRole(UpdateRoleModel model);
        Task<bool> Logout(LogoutModel model);
        Task<bool> Unblock(UnblockModel model);
    }
}

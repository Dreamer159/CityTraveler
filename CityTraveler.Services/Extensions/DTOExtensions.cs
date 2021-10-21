using CityTraveler.Domain.DTO;
using CityTraveler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services.Extensions
{
    public static class DTOExtensions
    {
        public static UserDTO ToUserDTO(this ApplicationUserModel userModel)
        {
            return new UserDTO()
            {
                Name = user.Profile.Name,
                AvatarSrc = user.Profile.AvatarSrc,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email
            };
        }
    }
}

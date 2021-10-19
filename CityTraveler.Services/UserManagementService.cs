using CityTraveler.Domain.Entities;
using CityTraveler.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Services
{
    public class UserManagementService : IUserManagementService
    {
        public bool IsActive { get; set; }
        public string Version { get; set; }
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        bool IServiceMetadata.IsActive { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string IServiceMetadata.Version { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /*public IUser GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public IUser GetUserById(Guid userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IUser> GetUsers(int skip = 0, int take = 10)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IUser> GetUsers(IEnumerable<Guid> guids)
        {
            throw new NotImplementedException();
        }

        public bool RemoveUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUserData(IUser user)
        {
            throw new NotImplementedException();
        }*/

        UserProfileModel IUserManagementService.GetUserByEmail(string email)
        {
            throw new NotImplementedException();
        }

        UserProfileModel IUserManagementService.GetUserById(Guid userId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<UserProfileModel> IUserManagementService.GetUsers(int skip, int take)
        {
            throw new NotImplementedException();
        }

        IEnumerable<UserProfileModel> IUserManagementService.GetUsers(IEnumerable<Guid> guids)
        {
            throw new NotImplementedException();
        }

        bool IUserManagementService.RemoveUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        bool IUserManagementService.UpdateUserData(UserProfileModel user)
        {
            throw new NotImplementedException();
        }
    }
}

using CityTraveler.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Entities
{
    public class UserManagementService : IUserManagementService
    {
        public IEnumerable<IUser> Users { get; set; }
        public bool IsActive { get; set; }
        public string Version { get; set; }
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public bool SetUsers(IEnumerable<IUser> users)
        {
            try
            {
                Users = users;
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool BlockUser(Guid userId)
        {
            try
            {
                User updated = (User)Users.FirstOrDefault<IUser>(x => x.Id == userId);
                updated.Blocked = true;
                Users = Users.Where(x => x.Id != userId).Append<IUser>(updated);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public IUser GetUserByEmail(string email)
        {
            return Users.FirstOrDefault(x => x.ContactInfo.Email == email);
        }

        public IUser GetUserById(Guid userId)
        {
            return Users.FirstOrDefault(x => x.Id == userId);
        }

        public IEnumerable<IUser> GetUsers(int skip = 0, int take = 10)
        {
            return Users;
        }

        public IEnumerable<IUser> GetUsers(IEnumerable<Guid> guids)
        {
            return Users.Where(x => guids.Contains<Guid>(x.Id));
        }

        public bool RemoveUser(Guid userId)
        {
            try
            {
                Users = Users.Where(x => x.Id != userId);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        //not rwally sure
        public bool UnblockUser(Guid userId)
        {
            try
            {
                User updated = (User)Users.FirstOrDefault<IUser>(x => x.Id == userId);
                updated.Blocked = false;
                Users = Users.Where(x => x.Id != userId).Append<IUser>(updated);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UpdateUserData(IUser user)
        {
            try
            {
                Users = Users.Where(x => x.Id != user.Id).Append<IUser>(user);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}

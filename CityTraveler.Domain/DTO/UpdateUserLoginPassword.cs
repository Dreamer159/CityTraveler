using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Domain.DTO
{
    public class UpdateUserLoginPassword
    {
        public string UserName { get; set; }
        public string NewPassword { get; set; }
        
    }
}

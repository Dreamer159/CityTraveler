using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Infrastructure.Interfaces
{
    public interface IComment: IDbData
    {
        Guid OwnerId { get; set; }
        string Description { get; set; }

    }
}

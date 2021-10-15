using CityTraveler.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Repository.DbContext
{
    public class DbCollection<T> : IDbCollection<T> where T : IDbData
    {
        public IDbRequestManager<T> RequestManager { get; set; }
        public List<T> Collection { get; set; } = new List<T>();

        public DbCollection(string conn)
        {
            RequestManager = new DbRequestManager<T>(conn);
        }
    }
}

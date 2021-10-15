using CityTraveler.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Repository.DbContext
{
    public interface IDbSyncManager
    {
        public void SetSource(IEnumerable<ISyncModel> tablesToSync, IDbRequestManager<IDbData> requestManager);
        public Task StartSync();
        public bool IsSynchronized { get; }
    }
}

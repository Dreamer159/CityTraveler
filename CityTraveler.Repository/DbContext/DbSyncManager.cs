using CityTraveler.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityTraveler.Repository.DbContext
{
    public class DbSyncManager : IDbSyncManager
    {
        public bool IsSynchronized => SyncTables.All(x => x.IsSynchronized);
        private IDbRequestManager<IDbData> RequestManager { get; set; }
        private IEnumerable<ISyncModel> SyncTables { get; set; } = new List<SyncModel>();

        public void SetSource(IEnumerable<ISyncModel> tablesToSync, IDbRequestManager<IDbData> requestManager)
        {
            RequestManager = requestManager;
            SyncTables = tablesToSync;
        }

        public async Task StartSync()
        {
            var query = $@"write";
            var result = await RequestManager.CommonQueryAsync(query, null, false);
            SyncTables = result.Select(x =>
                new SyncModel
                {
                    ExtraFields = x.ExtraFields,
                    FieldsToSync = x.FieldsToSync,
                    IsSynchronized = x.IsSynchronized,
                    TableName = x.TableName,
                    MissedFields = x.MissedFields
                });
        }
    }
}

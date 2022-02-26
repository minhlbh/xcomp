using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class DeviceFollowRepository : BaseRepository<DeviceFollow>, IDeviceFollowRepository
    {
        public DeviceFollowRepository(IMongoContext context) : base(context)
        {
        }
    }
}

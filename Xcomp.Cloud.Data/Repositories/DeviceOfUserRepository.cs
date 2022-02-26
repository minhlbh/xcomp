using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class DeviceOfUserRepository: BaseRepository<DeviceOfUser>, IDeviceOfUserRepository
    {
        public DeviceOfUserRepository(IMongoContext context) : base(context)
        {
        }
    }
}

using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class DeviceRepository: BaseRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(IMongoContext context) : base(context)
        {
        }
    }
}

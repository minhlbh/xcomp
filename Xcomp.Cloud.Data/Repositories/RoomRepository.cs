using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class RoomRepository: BaseRepository<Room>, IRoomRepository
    {
        public RoomRepository(IMongoContext context) : base(context)
        {
        }
    }
}

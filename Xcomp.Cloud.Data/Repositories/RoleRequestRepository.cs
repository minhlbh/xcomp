using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class RoleRequestRepository: BaseRepository<RoleRequest>, IRoleRequestRepository
    {
        public RoleRequestRepository(IMongoContext context) : base(context)
        {
        }
    }
}

using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class DutyGroupRepository: BaseRepository<DutyGroup>, IDutyGroupRepository
    {
        public DutyGroupRepository(IMongoContext context) : base(context)
        {
        }
    }
}

using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class HospitalRepository: BaseRepository<Hospital>, IHospitalRepository
    {
        public HospitalRepository(IMongoContext context) : base(context)
        {
        }
    }
}

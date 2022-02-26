using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class PatientFollowRepository : BaseRepository<PatientFollow>, IPatientFollowRepository
    {
        public PatientFollowRepository(IMongoContext context) : base(context)
        {
        }
    }
}

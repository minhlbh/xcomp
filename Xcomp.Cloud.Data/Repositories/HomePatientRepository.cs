using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class HomePatientRepository: BaseRepository<HomePatient>, IHomePatientRepository
    {
        public HomePatientRepository(IMongoContext context) : base(context)
        {
        }
    }
}

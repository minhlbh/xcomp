using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;
namespace Xcomp.Cloud.Data.Repositories
{
    public class HomePatientFollowRepository : BaseRepository<HomePatientFollow>, IHomePatientFollowRepository
    {
        public HomePatientFollowRepository(IMongoContext context) : base(context)
        {
        }
    }
}

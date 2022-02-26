using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class AppRepository: BaseRepository<App>, IAppRepository
    {
        public AppRepository(IMongoContext context) : base(context)
        {
        }
    }
}

using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class BedRepository: BaseRepository<Bed>, IBedRepository
    {
        public BedRepository(IMongoContext context) : base(context)
        {
        }
    }
}

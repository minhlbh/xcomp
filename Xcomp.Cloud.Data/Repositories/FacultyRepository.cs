using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class FacultyRepository: BaseRepository<Faculty>, IFacultyRepository
    {
        public FacultyRepository(IMongoContext context) : base(context)
        {
        }
    }
}

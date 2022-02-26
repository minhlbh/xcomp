using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.Repositories
{
    public class UserRepository: BaseRepository<User>, IUserRepository
    {
        public UserRepository(IMongoContext context) : base(context)
        {
        }
    }
}

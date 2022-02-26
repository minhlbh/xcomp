using Xcomp.Cloud.Data.IRepositories;
using Xcomp.Cloud.Share.Domain;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace Xcomp.Cloud.Data.Repositories
{
    public class PatientRepository: BaseRepository<Patient>, IPatientRepository
    {
        public PatientRepository(IMongoContext context) : base(context)
        {
        }

        public async Task<List<Call>> GetCallPagingAsync(string patientId, int pageSize, int pageIndex)
        {
            var notes = await DbSet.AsQueryable()
                .Where(c => c.Id == patientId)
                .SelectMany(c => c.Calls)
                .OrderByDescending(c => c.CreatedAt)
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToListAsync();
            return notes;
        }

        public async Task<List<Message>> GetMessagePagingAsync(string patientId, int pageSize, int pageIndex)
        {
            var notes = await DbSet.AsQueryable()
                .Where(c => c.Id == patientId)
                .SelectMany(c => c.Messages)
                .OrderByDescending(c => c.CreatedAt)
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToListAsync();
            return notes;
        }

        public async Task<List<Note>> GetNotePagingAsync(string patientId, int pageSize, int pageIndex)
        {
            var notes = await DbSet.AsQueryable()
                .Where(c => c.Id == patientId)
                .SelectMany(c => c.Notes)
                .OrderByDescending(c => c.CreatedAt)
                .Skip(pageIndex * pageSize)
                .Take(pageSize)
                .ToListAsync();
            return notes;
        }
    }
}

using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Data.IRepositories
{
    public interface IPatientRepository : IRepository<Patient>
    {
        Task<List<Note>> GetNotePagingAsync(string patientId, int pageSize, int pageIndex);
        Task<List<Message>> GetMessagePagingAsync(string patientId, int pageSize, int pageIndex);
        Task<List<Call>> GetCallPagingAsync(string patientId, int pageSize, int pageIndex);
    }
}

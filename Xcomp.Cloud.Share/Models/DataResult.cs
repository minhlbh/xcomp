
namespace Xcomp.Cloud.Share.Models
{
    public class DataResult<T>
    {
        public T[] Data { get; set; }
        public int Total { get; set; }
    }

    public class DataResult
    {
        public dynamic Data { get; set; }
        public int Total { get; set; }
    }
}

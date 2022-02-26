using Xcomp.Cloud.Share.Domain;
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models
{
    public class DeviceOfUserModel : BaseModel
    {
        public string Phone { get; set; }
        public Device Device { get; set; }

    }

    public class CreateDeviceOfUserModel
    {
        [Required]
        public string Phone { get; set; }
        [Required]
        public string DeviceCode { get; set; }

    }

    public class UpdateDeviceOfUserModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string DeviceCode { get; set; }

    }

    public class SearchDeviceOfUserModel
    {
        public string ParentId { get; set; }
        

    }

}

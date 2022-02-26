using Xcomp.Cloud.Share.Domain;
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models
{
    public class DeviceFollowModel: BaseModel
    {
        public List<DeviceFollowDetail> Devices { get; set; }
    }

    public class AddDeviceInDeviceFollowModel 
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string DeviceId { get; set; }
    }

    public class DeviceFollowDetail : BaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }
        public string HomePatientName { get; set; }

    }

}

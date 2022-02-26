using Xcomp.Cloud.Share.Domain;
using System.ComponentModel.DataAnnotations;


namespace Xcomp.Cloud.Share.Models
{
    public class BedModel: BaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public RoomModel RoomParent { get; set; }
        public PatientModel Patient { get; set; }
        public DeviceModel Device { get; set; }
    }

    public class BedInDeviceModel : BaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Room RoomParent { get; set; }
    }

    public class CreateBedModel 
    {
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }
        [Required]
        public string RoomParentId { get; set; }
        public string Status { get; set; }
    }

    public class UpdateBedModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }

    }

}

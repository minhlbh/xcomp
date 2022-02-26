using Xcomp.Cloud.Share.Domain;
using System.ComponentModel.DataAnnotations;


namespace Xcomp.Cloud.Share.Models
{
    public class DeviceModel : BaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string ProduceDate { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string HardwareVersion { get; set; }
        public string SoftwareVersion { get; set; }
        public string SellDate { get; set; }
        public string Price { get; set; }
        public BedInDeviceModel Bed { get; set; }

    }

    public class CreateDeviceModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string FacultyId { get; set; }
        public string Type { get; set; }
        public string ProduceDate { get; set; }
        [Required]
        public string Code { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string HardwareVersion { get; set; }
        public string SoftwareVersion { get; set; }
        public string SellDate { get; set; }
        public string Price { get; set; }

    }

    public class CreateHomeDeviceModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Code { get; set; }
        

    }

    public class UpdateDeviceModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string FacultyId { get; set; }
        public string Type { get; set; }
        public string ProduceDate { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public string HardwareVersion { get; set; }
        public string SoftwareVersion { get; set; }
        public string SellDate { get; set; }
        public string Price { get; set; }

    }

    public class SearchDeviceModel
    {
        public string ParentId { get; set; }
        

    }

    public class InformationDeviceModel
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

    }

    public class MapDeviceBedModel
    {
        [Required]
        public string DeviceId { get; set; }
        [Required]
        public string BedId { get; set; }

    }

    
}

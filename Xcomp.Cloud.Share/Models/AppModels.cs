using Xcomp.Cloud.Share.Domain;

using System.ComponentModel.DataAnnotations;


namespace Xcomp.Cloud.Share.Models
{
    public class AppModel : BaseModel
    {
        public string Name { get; set; }
        public string DeviceCode { get; set; }
        public string UserActive { get; set; }
        public string Os { get; set; }

    }

    public class CreateAppModel
    {
        [Required]
        public string Name { get; set; }
        public string DeviceCode { get; set; }
        public string UserActive { get; set; }
        public string Os { get; set; }

    }

    public class UpdateAppModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string DeviceCode { get; set; }
        public string UserActive { get; set; }
        public string Os { get; set; }

    }

    public class SearchAppModel
    {
        public string ParentId { get; set; }
        

    }

    public class InformationAppModel
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

    }
}

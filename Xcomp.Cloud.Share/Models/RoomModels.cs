using Xcomp.Cloud.Share.Domain;
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models
{
    public class RoomModel: BaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public FacultyModel FacultyParent { get; set; }
        public string Note { get; set; }
    }

    public class CreateRoomModel 
    {
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }
        public string FacultyParentId { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
    }

    public class UpdateRoomModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }

    }

}

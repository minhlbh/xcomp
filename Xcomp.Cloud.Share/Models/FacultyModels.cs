using System.ComponentModel.DataAnnotations;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Share.Models
{
    public class FacultyModel: BaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
        public HospitalModel Parent  { get; set; }
        public UserModel Manager { get; set; }
    }

    public class BasicFacultyModel : BaseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
    }

    public class CreateFacultyModel 
    {
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public string ParentId { get; set; }
        public string ManagerId { get; set; }
    }

    public class UpdateFacultyModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        
    }

    public class ModelId
    {
        [Required]
        public string Id { get; set; }

    }
}

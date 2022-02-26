using Xcomp.Cloud.Share.Domain;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Xcomp.Cloud.Share.Models
{
    public class HospitalModel : BaseModel
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public string GPS { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
        public string Domain { get; set; }
        public string LocalDomain { get; set; }

    }

    public class CreateHospitalModel
    {
        [Required]
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public string GPS { get; set; }
        public string Email { get; set; }
        public string Domain { get; set; }
        public string LocalDomain { get; set; }

    }

    public class UpdateHospitalModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Address { get; set; }
        public string GPS { get; set; }
        public string Email { get; set; }
        public string Domain { get; set; }
        public string LocalDomain { get; set; }

    }

    public class SearchHospitalModel
    {
        public string ParentId { get; set; }
        

    }
}

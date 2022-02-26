using Xcomp.Cloud.Share.Domain;
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models
{
    public class PatientFollowModel: BaseModel
    {
        public List<PatientModel> Patients { get; set; }
    }

    public class AddPatientInPatientFollowModel 
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string PatientId { get; set; }
    }

}

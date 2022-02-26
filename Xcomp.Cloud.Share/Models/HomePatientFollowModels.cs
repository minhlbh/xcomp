using System.ComponentModel.DataAnnotations;
using System.Text;
using Xcomp.Cloud.Share.Domain;

namespace Xcomp.Cloud.Share.Models
{
    public class HomePatientFollowModel: BaseModel
    {
        public List<PatientModel> Patients { get; set; }
    }

    public class AddPatientInHomePatientFollowModel 
    {
        [Required]
        public string UserId { get; set; }
        [Required]
        public string PatientId { get; set; }
    }

}

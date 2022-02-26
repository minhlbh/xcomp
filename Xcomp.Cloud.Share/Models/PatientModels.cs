using Xcomp.Cloud.Share.Domain;
using Microsoft.AspNetCore.Http;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;
namespace Xcomp.Cloud.Share.Models
{
    public class PatientModel: BaseModel
    {
        public string Name { get; set; }
        public string PID { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string HospitalId { get; set; }
        public string Room { get; set; }
        public Bed Bed { get; set; }
        public string AccessCode { get => Id.ToUpper(); set { } }
        public string RelativeStatus { get; set; }
    }

    public class CreatePatientModel 
    {
        [Required]
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string HospitalId { get; set; }
        public string Room { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        [Required]
        public string FacultyId { get; set; }
    }

    public class UpdatePatientModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Room { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }

    }

    public class UpdatePatientStatusModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Status { get; set; }

    }

    public class PatientFullInfoModel : BaseModel
    {
        public List<Note> Notes { get; set; }
        public List<Call> Calls { get; set; }
        public List<Message> Messages { get; set; }
    }

    public class CreatePatientNoteModel
    {
        [Required]
        public string PatientId { get; set; }
        [Required]
        public string CreateName { get; set; }
        public string Text { get; set; }
        public List<IFormFile> Files { get; set; }

    }


    public class CreatePatientCallModel
    {
        [Required]
        public string PatientId { get; set; }
        public string Type { get; set; }
        public string CreateName { get; set; }
        public string Role { get; set; }

    }

    public class MapPatientBedModel
    {
        [Required]
        public string PatientId { get; set; }
        [Required]
        public string BedId { get; set; }

    }

    public class DutyGroupPatientModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string PID { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Room { get; set; }
        public Bed Bed { get; set; }
        public List<DoctorModel> Doctors { get; set; }
        public DateTime LastCall { get; set; }
        public int WaitCallCount { get; set; }
    }

    public class CreatePatientMessageModel
    {
        [Required]
        public string PatientId { get; set; }
        [Required]
        public string CreateName { get; set; }
        public string Text { get; set; }
        public List<IFormFile> Files { get; set; }

    }

    public class CreatePatientRelativeModel
    {
        [Required]
        public string PatientId { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Relationship { get; set; }
        [Required]
        [RegularExpression("Pending|Active|Disabled", ErrorMessage = "Value is required in Pending|Active|Disabled")]
        public string Status { get; set; }
    }

    public class DeletePatientRelativeModel
    {
        [Required]
        public string PatientId { get; set; }
        [Required]
        public string PatientRelativeId { get; set; }
    }

    public class CrudPatientDoctorModel
    {
        [Required]
        public string PatientId { get; set; }
        [Required]
        public string UserId { get; set; }
    }

    public class PatientRelativeModel
    {
        public string Id { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }
        public string Relationship { get; set; }
        public string Status { get; set; }

    }

    public class UpdatePatientRelativeModel
    {
        [Required]
        public string PatientRelativeId { get; set; }
        [Required]
        public string PatientId { get; set; }
        [Required]
        public string Relationship { get; set; }
        [Required]
        [RegularExpression("Pending|Active|Disabled", ErrorMessage = "")]
        public string Status { get; set; }

    }

    public class DoctorModel
    {
        public string Id { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }
    }
}

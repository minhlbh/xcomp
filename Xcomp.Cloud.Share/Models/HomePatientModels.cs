using Xcomp.Cloud.Share.Domain;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models
{
    public class HomePatientModel: BaseModel
    {
        public string Name { get; set; }
        public string DeviceName { get; set; }
        public string AccessCode { get => Id.ToUpper(); set { } }
    }

    public class CreateHomePatientModel 
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserId { get; set; }
        
    }

    public class UpdateHomePatientModel
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }

    }

    public class HomePatientFullInfoModel : BaseModel
    {
        public List<Note> Notes { get; set; }
        public List<Call> Calls { get; set; }
        public List<Message> Messages { get; set; }
    }

    public class CreateHomePatientNoteModel
    {
        [Required]
        public string HomePatientId { get; set; }
        [Required]
        public string CreateName { get; set; }
        public string Text { get; set; }
        public List<IFormFile> Files { get; set; }
    }

    public class CreateHomePatientCallModel
    {
        [Required]
        public string HomePatientId { get; set; }
        public string Type { get; set; }
        public string CreateName { get; set; }
        public string Role { get; set; }

    }

    public class MapHomePatientBedModel
    {
        [Required]
        public string HomePatientId { get; set; }
        [Required]
        public string DeviceId { get; set; }

    }

    public class CreateHomePatientMessageModel
    {
        [Required]
        public string HomePatientId { get; set; }
        [Required]
        public string CreateName { get; set; }
        public string Text { get; set; }
        public List<IFormFile> Files { get; set; }

    }

    public class CreateHomePatientRelativeModel
    {
        [Required]
        public string HomePatientId { get; set; }
        [Required]
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Relationship { get; set; }
    }

    public class DeleteHomePatientRelativeModel
    {
        [Required]
        public string HomePatientId { get; set; }
        [Required]
        public string HomePatientRelativeId { get; set; }
    }

}

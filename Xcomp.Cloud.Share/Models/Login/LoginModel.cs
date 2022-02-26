using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models.Login
{
    public class LoginModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

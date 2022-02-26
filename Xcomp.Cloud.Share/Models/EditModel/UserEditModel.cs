using Xcomp.Cloud.Core.Extentions;
using System.ComponentModel.DataAnnotations;
using Xcomp.Cloud.Core.Ultis;
using Xcomp.Cloud.Core.Attributes.Web;
using Xcomp.Cloud.Core.Enums;

namespace Xcomp.Cloud.Share.Models.EditModel
{
    public class UserEditModel : EditBaseModel
    {
        public string Id { get; set; }
        [Display(Name = "Điện thoại")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        public string Phone { get; set; }
        [Display(Name = "Họ và tên")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(32, ErrorMessage = "Mật khẩu phải có độ dài từ 8 đến 32 ký tự.", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^\da-zA-Z]).+$", ErrorMessage = "Mật khẩu phải bao gồm đầy đủ ký tự chữ thường, chữ hoa, số và ký tự đặc biệt.")]
        [DataType(DataType.Password)]
        [Field(FieldType.Password)]
        [Display(Name = "Mật khẩu")]
        public virtual string Password { get; set; }

        [Required(ErrorMessage = "Xác nhận mật khẩu không được để trống.")]
        [DataType(DataType.Password)]
        [Field(FieldType.Password)]
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu phải giống với mật khẩu.")]
        [Display(Name = "Nhập lại mật khẩu")]
        public virtual string ConfimPassword { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime? BirthOfDate { get; set; }
        [Display(Name = "Chức vụ")]
        public string Title { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Ngày sửa")]
        public DateTime UpdatedAt { get; set; }
        [Display(Name = "Tạo bởi")]
        public string CreatedBy { get; set; }
        [Display(Name = "Chỉnh sửa bởi")]
        public string UpdatedBy { get; set; }
        //[Display(Name = "Trạng thái")]
        //public string Status { get; set; }
        Property<UserEditModel> property = new Property<UserEditModel>();

        public UserEditModel(bool isEdit = true)
        {
            InputFields.Add<UserEditModel>(c => c.Phone);
            InputFields.Add<UserEditModel>(c => c.FullName);
            if (!isEdit)
            {
                InputFields.Add<UserEditModel>(c => c.Password);
                InputFields.Add<UserEditModel>(c => c.ConfimPassword);
            }
            InputFields.Add<UserEditModel>(c => c.BirthOfDate);
            InputFields.Add<UserEditModel>(c => c.Email);
            InputFields.Add<UserEditModel>(c => c.Avatar);
            if (isEdit)
            {
                InputFields.Add<UserEditModel>(c => c.CreatedAt);
                InputFields.Add<UserEditModel>(c => c.UpdatedAt);
                InputFields.Add<UserEditModel>(c => c.CreatedBy);
                InputFields.Add<UserEditModel>(c => c.UpdatedBy);
                //InputFields.Add<UserEditModel>(c => c.Status);

                DisableInputFields.Add<UserEditModel>(c => c.Phone);
                DisableInputFields.Add<UserEditModel>(c => c.CreatedAt);
                DisableInputFields.Add<UserEditModel>(c => c.UpdatedAt);
                DisableInputFields.Add<UserEditModel>(c => c.CreatedBy);
                DisableInputFields.Add<UserEditModel>(c => c.UpdatedBy);
                //DisableInputFields.Add<UserEditModel>(c => c.Status);
            }
        }
    }
}

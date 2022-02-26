using System.Threading.Tasks;
using Xcomp.Cloud.Core.Extentions;
using System.ComponentModel.DataAnnotations;

namespace Xcomp.Cloud.Share.Models.EditModel
{
    public class HospitalEditModel : EditBaseModel
    {
        public string Id { get; set; }
        [Display(Name = "Tên cơ sở y tế")]
        [Required(ErrorMessageResourceType = typeof(AlertResource), ErrorMessageResourceName = "Required")]
        public string Name { get; set; }
        [Display(Name = "Ảnh")]
        public string Logo { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "Domain/Ip")]
        public string Domain { get; set; }
        [Display(Name = "Lan Domain/Ip")]
        public string LocalDomain { get; set; }
        [Display(Name = "Mã hệ thống")]
        public string Code { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreatedAt { get; set; }
        [Display(Name = "Ngày sửa")]
        public DateTime UpdatedAt { get; set; }
        [Display(Name = "Tạo bởi")]
        public string CreatedBy { get; set; }
        [Display(Name = "Chỉnh sửa bởi")]
        public string UpdatedBy { get; set; }

        public HospitalEditModel(bool isEdit = true)
        {
            InputFields.Add<HospitalEditModel>(c => c.Name);
            InputFields.Add<HospitalEditModel>(c => c.Logo);
            InputFields.Add<HospitalEditModel>(c => c.Address);
            InputFields.Add<HospitalEditModel>(c => c.Domain);
            InputFields.Add<HospitalEditModel>(c => c.LocalDomain);
            //InputFields.Add<HospitalEditModel>(c => c.Email);
            //InputFields.Add<HospitalEditModel>(c => c.Code);
            //InputFields.Add<HospitalEditModel>(c => c.Status);
            if (isEdit)
            {
                InputFields.Add<HospitalEditModel>(c => c.Code);
                InputFields.Add<HospitalEditModel>(c => c.CreatedAt);
                InputFields.Add<HospitalEditModel>(c => c.UpdatedAt);
                InputFields.Add<HospitalEditModel>(c => c.CreatedBy);
                InputFields.Add<HospitalEditModel>(c => c.UpdatedBy);

                DisableInputFields.Add<HospitalEditModel>(c => c.Code);
                DisableInputFields.Add<HospitalEditModel>(c => c.CreatedAt);
                DisableInputFields.Add<HospitalEditModel>(c => c.UpdatedAt);
                DisableInputFields.Add<HospitalEditModel>(c => c.CreatedBy);
                DisableInputFields.Add<HospitalEditModel>(c => c.UpdatedBy);
            }


        }
    }
}

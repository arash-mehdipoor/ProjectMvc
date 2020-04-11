using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Start.Models
{
   public class User
    {
        [Key]
        public int UserID { get; set; }
        [Display(Name = "نقش کاربر")]
        public int RoleID { get; set; }

        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        public string UserName { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [EmailAddress(ErrorMessage ="لطفا ایمیل را درست وارد نمایید")]
        public string Email { get; set; }

        [Display(Name = "شماره تماس")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        public string PhonNumber { get; set; }

        [Display(Name = "کد فعالسازی")]
        public string ActiveCode { get; set; }

        [Display(Name = "فعال / غیرفعال")]
        public bool IsActive { get; set; }

        [Display(Name = "تاریخ ثبت نام")]
        public DateTime RegisterDate { get; set; }

        [ForeignKey("RoleID")]
        public virtual Role Roles { get; set; }
    }
}

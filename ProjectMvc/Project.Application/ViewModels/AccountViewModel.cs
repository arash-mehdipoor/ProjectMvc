using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Project.Application
{
    public class RegisterViewModel
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        public string UserName { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "تکرار کلمه عبور")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="تکرار کلمه عبور را درست وارد نمایید")]
        public string RePassword { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل را درست وارد نمایید")]
        public string Email { get; set; }

        [Display(Name = "شماره تماس")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        [StringLength(11,ErrorMessage ="شماره تماس نمی تواند کمتر از 11 کاراکتر باشد",MinimumLength =11)]
        [DataType(DataType.PhoneNumber)]


        public string PhonNumber { get; set; }
    }
}

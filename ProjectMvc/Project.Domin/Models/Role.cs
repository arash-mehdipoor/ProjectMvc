using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domin.Models
{
   public class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Display(Name = "نقش کاربر")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        public string RoleName { get; set; }

        [Display(Name = "عنوان نقش")]
        [Required(ErrorMessage = "مقداری برای {0} وارد نمایید")]
        public string RoleTitle { get; set; }

        public virtual  IEnumerable<User> Users { get; set; }
    }
}

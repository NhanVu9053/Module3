using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserDangKy.Models
{
    public class UserClass
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Hãy nhập họ tên...")]
        [Display(Name = "Họ và tên")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Hãy nhập email...")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Hãy nhập đúng định dạng email !")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Hãy nhập Số điện thoại...")]
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Confirm Password incorrect")]
        public string ConfirmPassword { get; set; }

    }
}

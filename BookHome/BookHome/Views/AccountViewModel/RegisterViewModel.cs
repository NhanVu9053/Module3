using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookHome.Views.AccountViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "E-Mail")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
          ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Số điện thoại")]
        [RegularExpression(@"(09[0|1|2|3|4|6|7|8|9]|08[1|2|3|4|5|6|8|9]|07[0|6|7|8|9]|03[2|3|4|5|6|7|8|9]|05[6|8|9])+([0-9]{7})\b",
          ErrorMessage = "Số điện thoại không tồn tại.")]
        public string SoDienThoai { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Mật khẩu"), DataType(DataType.Password)]
        public string MatKhau { get; set; }

        [Required(ErrorMessage = "Đây là trường bắt buộc")]
        [Display(Name = "Xác nhận mật khẩu"), DataType(DataType.Password)]
        [Compare("MatKhau", ErrorMessage = "Mật khẩu xác nhận không chính xác")]
        public string XacnhanMatKhau { get; set; }
    }
}

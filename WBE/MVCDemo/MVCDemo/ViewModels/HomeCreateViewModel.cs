using Microsoft.AspNetCore.Http;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.ViewModels
{
    public class HomeCreateViewModel
    {
        [Required(ErrorMessage = "Xin Nhập Họ Tên")]
        [MaxLength(20, ErrorMessage = "Can not exceed 20 characters")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Office Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "invalid email format")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public IFormFile Avatar { get; set; }
    }
}

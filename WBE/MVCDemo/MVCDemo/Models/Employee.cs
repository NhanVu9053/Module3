using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Xin Nhập Họ Tên")]
        [MaxLength(20,ErrorMessage ="Can not exceed 20 characters")]
        public string FullName { get; set; }
        [Required]
        [Display(Name ="Office Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="invalid email format")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public string AvatarPath { get; set; }

       
       
        public override string ToString()
        {
            return $"Id: { Id}, Name: {FullName}, Email: {Email}," +
                $"Department : {Department}, AvatarPath: {AvatarPath}";
        }
    }
    
}

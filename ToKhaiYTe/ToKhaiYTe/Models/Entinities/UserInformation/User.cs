using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYTe.Models.Entinities.UserInformation
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(100)]
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        [Required]
        [MaxLength(20)]
        public string GioiTinh { get; set; }
        [Required]
        [MaxLength(50)]
        public string QuocTich { get; set; }
        [Required]
        [MaxLength(50)]
        public string HoChieu { get; set; }
    }
}

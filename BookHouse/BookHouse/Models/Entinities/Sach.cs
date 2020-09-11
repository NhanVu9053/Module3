using BookHouse.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Entinities
{
    public class Sach
    {
        [Key]
        public int SachId { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public DateTime NgayNhap { get; set; }
        public TinhTrang TinhTrang { get; set; }
        public string AvatarPath { get; set; }
        [ForeignKey("DauSachId")]
        public int _DauSachId { get; set; }
        public DauSach DauSach { get; set; }
    }
}

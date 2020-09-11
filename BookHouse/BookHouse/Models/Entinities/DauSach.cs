using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Entinities
{
    public class DauSach
    {
        [Key]
        public int DauSachID { get; set; }
        public string TenDauSach { get; set; }
        public int SoTrang { get; set; }
        public int SoLuong { get; set; }
        public int SoLuongCon { get; set; }
        public string NXB { get; set; }
        [ForeignKey("ChuyenNganhId")]
        public int _ChuyenNganhId { get; set; }
        public ChuyenNganh ChuyenNganh { get; set; }
        public ICollection<Sach> Sachs { get; set; }
    }
}

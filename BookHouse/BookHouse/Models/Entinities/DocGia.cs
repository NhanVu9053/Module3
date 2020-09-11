using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Entinities
{
    public class DocGia
    {
        [Key]
        public int DocGiaId { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public DateTime NgaySinh { get; set; }
        [ForeignKey("LopId")]
        public int _LopId { get; set; }
        public Lop Lop { get; set; }
    }
}

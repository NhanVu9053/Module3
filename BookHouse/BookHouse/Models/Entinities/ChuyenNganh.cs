using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Entinities
{
    public class ChuyenNganh
    {
        [Key]
        public int ChuyenNganhId { get; set; }
        [Required]
        public string TenChuyenNganh { get; set; }
       
        public string Mota { get; set; }

        [ForeignKey("DauSach")]
        public string _IdDauSach { get; set; }
        public ICollection<DauSach> dauSachs { get; set; }
    }
}

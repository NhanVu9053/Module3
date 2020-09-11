using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookHouse.Models.Entinities
{
    public class Lop
    {
        [Key]
        public int LopId { get; set; }
        public string TenLop { get; set; }

        public ICollection<DocGia> DocGias { get; set; }
    }
}

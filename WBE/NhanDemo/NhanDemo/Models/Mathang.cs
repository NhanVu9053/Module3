using System;
using System.Collections.Generic;

namespace NhanDemo.Models
{
    public partial class Mathang
    {
        public Mathang()
        {
            Chungtu = new HashSet<Chungtu>();
        }

        public int Idmathang { get; set; }
        public string Tenhang { get; set; }
        public string Loaihang { get; set; }
        public string Quycach { get; set; }
        public int Giaban { get; set; }
        public int Soluong { get; set; }

        public virtual ICollection<Chungtu> Chungtu { get; set; }
    }
}

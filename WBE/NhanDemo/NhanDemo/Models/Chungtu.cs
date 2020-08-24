using System;
using System.Collections.Generic;

namespace NhanDemo.Models
{
    public partial class Chungtu
    {
        public Chungtu()
        {
            Phieuthu = new HashSet<Phieuthu>();
        }

        public int Idchungtu { get; set; }
        public DateTime Ngaylapchungtu { get; set; }
        public int Idkhachhang { get; set; }
        public int Idmathang { get; set; }
        public int? Soluong { get; set; }
        public decimal? Dongia { get; set; }

        public virtual Khachhang IdkhachhangNavigation { get; set; }
        public virtual Mathang IdmathangNavigation { get; set; }
        public virtual ICollection<Phieuthu> Phieuthu { get; set; }
    }
}

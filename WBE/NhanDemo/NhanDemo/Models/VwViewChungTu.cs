using System;
using System.Collections.Generic;

namespace NhanDemo.Models
{
    public partial class VwViewChungTu
    {
        public int Idchungtu { get; set; }
        public DateTime Ngaylapchungtu { get; set; }
        public int Idkhachhang { get; set; }
        public int Idmathang { get; set; }
        public int? Soluong { get; set; }
        public decimal? Dongia { get; set; }
    }
}

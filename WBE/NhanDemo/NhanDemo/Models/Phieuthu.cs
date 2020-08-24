using System;
using System.Collections.Generic;

namespace NhanDemo.Models
{
    public partial class Phieuthu
    {
        public int Idphieuthu { get; set; }
        public DateTime Ngaythutien { get; set; }
        public decimal Sotienthu { get; set; }
        public int Idchungtu { get; set; }

        public virtual Chungtu IdchungtuNavigation { get; set; }
    }
}

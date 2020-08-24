using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NhanDemo.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Chungtu = new HashSet<Chungtu>();
        }
        [DisplayName ("Id Customer")]
        public int Idkhachhang { get; set; }
        [DisplayName("Ho ten")]
        public string Hotenkhachhang { get; set; }
        public string Diachikhachhang { get; set; }

        public virtual ICollection<Chungtu> Chungtu { get; set; }
    }
}

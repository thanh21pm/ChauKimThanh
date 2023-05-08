using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System;

namespace DPM205XXX_QLHS.Models
{
    public class HocSinhViewModel
    {
        public HocSinhViewModel()
        {
        }
        public int MaHS { get; set; }
        public string TenHS { get; set; }
        public int Tuoi { get; set; }
        public string Lop { get; set; }
        public string Khoa { get; set; }
        public string DiaChi { get; set; }

    }
}

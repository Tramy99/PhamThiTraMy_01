using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PhamThiTraMy_01.Models
{
    public class SinhVien
    {
        [Key]
        [DisplayName("Mã sinh viên"),MaxLength(20)]
        public string MaSinhVien { get; set; }
        [DisplayName("Họ Tên"), MaxLength(50)]
        public string HoTen { get; set; }
        [DisplayName("Mã lớp")]
        public int MaLop { get; set; }
        [ForeignKey("MaLop")]
        public virtual LopHoc LopHoc { get; set; }

    }
}
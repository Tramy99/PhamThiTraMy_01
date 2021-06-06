using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhamThiTraMy_01.Models
{
    public class LopHoc
    {
        [Key]
        [DisplayName("Mã lớp")]
        public int MaLop { get; set; }
        [MaxLength(50),DisplayName("Tên lớp")]
        public string TenLop { get; set; }
        public ICollection<SinhVien> SinhViens { get; set; }
    }
}
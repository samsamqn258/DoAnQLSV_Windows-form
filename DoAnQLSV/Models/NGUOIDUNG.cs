namespace DoAnQLSV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUOIDUNG")]
    public partial class NGUOIDUNG
    {
        [Key]
        [StringLength(11)]
        public string MaNguoiDung { get; set; }

        [StringLength(11)]
        public string MaGiangVien { get; set; }

        [StringLength(11)]
        public string MaSinhVien { get; set; }

        [StringLength(11)]
        public string TaiKhoan { get; set; }

        [StringLength(11)]
        public string MatKhau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public virtual GIANGVIEN GIANGVIEN { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}

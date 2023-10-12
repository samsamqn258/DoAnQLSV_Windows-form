namespace DoAnQLSV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANGDIEM")]
    public partial class BANGDIEM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string MaSinhVien { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string MaLopMonHoc { get; set; }

        public double? DiemLan1 { get; set; }

        public double? DiemLan2 { get; set; }

        public double? DiemQuaTrinh { get; set; }

        public double? DiemThi { get; set; }

        [StringLength(4)]
        public string DanhGia { get; set; }

        public virtual LOPMONHOC LOPMONHOC { get; set; }

        public virtual SINHVIEN SINHVIEN { get; set; }
    }
}

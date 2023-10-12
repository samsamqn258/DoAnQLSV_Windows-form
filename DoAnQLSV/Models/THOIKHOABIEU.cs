namespace DoAnQLSV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THOIKHOABIEU")]
    public partial class THOIKHOABIEU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(11)]
        public string MaHocKi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(11)]
        public string MaLopMonHoc { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(11)]
        public string MaThoiKhoaBieu { get; set; }

        public int? TietBatDau { get; set; }

        public int? TietKetThuc { get; set; }

        [StringLength(50)]
        public string PhongHoc { get; set; }

        [Required]
        [StringLength(11)]
        public string MaGiangVien { get; set; }

        public virtual GIANGVIEN GIANGVIEN { get; set; }

        public virtual HOCKI HOCKI { get; set; }

        public virtual LOPMONHOC LOPMONHOC { get; set; }
    }
}

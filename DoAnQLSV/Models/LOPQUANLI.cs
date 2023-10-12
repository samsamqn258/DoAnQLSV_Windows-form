namespace DoAnQLSV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOPQUANLI")]
    public partial class LOPQUANLI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOPQUANLI()
        {
            SINHVIENs = new HashSet<SINHVIEN>();
        }

        [Key]
        [StringLength(11)]
        public string MaLopNienChe { get; set; }

        [Required]
        [StringLength(11)]
        public string MaKhoa { get; set; }

        [StringLength(255)]
        public string TenLopNienChe { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        public int? SoLuongSinhVien { get; set; }

        public virtual KHOA KHOA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIEN> SINHVIENs { get; set; }
    }
}

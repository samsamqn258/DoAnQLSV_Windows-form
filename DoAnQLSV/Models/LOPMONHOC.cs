namespace DoAnQLSV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOPMONHOC")]
    public partial class LOPMONHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOPMONHOC()
        {
            BANGDIEMs = new HashSet<BANGDIEM>();
            THOIKHOABIEUx = new HashSet<THOIKHOABIEU>();
        }

        [Key]
        [StringLength(11)]
        public string MaLopMonHoc { get; set; }

        [Required]
        [StringLength(11)]
        public string MaMonHoc { get; set; }

        [StringLength(255)]
        public string TenLopMonHoc { get; set; }

        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        [Required]
        [StringLength(11)]
        public string MaGiangVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANGDIEM> BANGDIEMs { get; set; }

        public virtual GIANGVIEN GIANGVIEN { get; set; }

        public virtual MONHOC MONHOC { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THOIKHOABIEU> THOIKHOABIEUx { get; set; }
    }
}

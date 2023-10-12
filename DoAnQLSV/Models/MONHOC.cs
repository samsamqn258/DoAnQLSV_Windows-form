namespace DoAnQLSV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONHOC")]
    public partial class MONHOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONHOC()
        {
            LOPMONHOCs = new HashSet<LOPMONHOC>();
        }

        [Key]
        [StringLength(11)]
        public string MaMonHoc { get; set; }

        [StringLength(255)]
        public string TenMonHoc { get; set; }

        public int? SoTinChi { get; set; }

        public int? SoTiet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOPMONHOC> LOPMONHOCs { get; set; }
    }
}

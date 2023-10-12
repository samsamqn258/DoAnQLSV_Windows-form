namespace DoAnQLSV.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHOA")]
    public partial class KHOA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHOA()
        {
            LOPQUANLIs = new HashSet<LOPQUANLI>();
        }

        [Key]
        [StringLength(11)]
        public string MaKhoa { get; set; }

        [StringLength(255)]
        public string TenKhoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOPQUANLI> LOPQUANLIs { get; set; }
    }
}

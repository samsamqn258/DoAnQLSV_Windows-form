using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAnQLSV.Models
{
    public partial class StudentModel : DbContext
    {
        public StudentModel()
            : base("name=StudentModel1")
        {
        }

        public virtual DbSet<BANGDIEM> BANGDIEMs { get; set; }
        public virtual DbSet<GIANGVIEN> GIANGVIENs { get; set; }
        public virtual DbSet<HOCKI> HOCKIs { get; set; }
        public virtual DbSet<KHOA> KHOAs { get; set; }
        public virtual DbSet<LOPMONHOC> LOPMONHOCs { get; set; }
        public virtual DbSet<LOPQUANLI> LOPQUANLIs { get; set; }
        public virtual DbSet<MONHOC> MONHOCs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THOIKHOABIEU> THOIKHOABIEUx { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANGDIEM>()
                .Property(e => e.MaSinhVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANGDIEM>()
                .Property(e => e.MaLopMonHoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BANGDIEM>()
                .Property(e => e.DanhGia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIANGVIEN>()
                .Property(e => e.MaGiangVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIANGVIEN>()
                .Property(e => e.SoDienThoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIANGVIEN>()
                .HasMany(e => e.LOPMONHOCs)
                .WithRequired(e => e.GIANGVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GIANGVIEN>()
                .HasMany(e => e.THOIKHOABIEUx)
                .WithRequired(e => e.GIANGVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCKI>()
                .Property(e => e.MaHocKi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCKI>()
                .HasMany(e => e.THOIKHOABIEUx)
                .WithRequired(e => e.HOCKI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHOA>()
                .Property(e => e.MaKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHOA>()
                .HasMany(e => e.LOPQUANLIs)
                .WithRequired(e => e.KHOA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOPMONHOC>()
                .Property(e => e.MaLopMonHoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPMONHOC>()
                .Property(e => e.MaMonHoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPMONHOC>()
                .Property(e => e.MaGiangVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPMONHOC>()
                .HasMany(e => e.BANGDIEMs)
                .WithRequired(e => e.LOPMONHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOPMONHOC>()
                .HasMany(e => e.THOIKHOABIEUx)
                .WithRequired(e => e.LOPMONHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOPQUANLI>()
                .Property(e => e.MaLopNienChe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPQUANLI>()
                .Property(e => e.MaKhoa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPQUANLI>()
                .HasMany(e => e.SINHVIENs)
                .WithRequired(e => e.LOPQUANLI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONHOC>()
                .Property(e => e.MaMonHoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MONHOC>()
                .HasMany(e => e.LOPMONHOCs)
                .WithRequired(e => e.MONHOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MaNguoiDung)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MaGiangVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MaSinhVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.TaiKhoan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NGUOIDUNG>()
                .Property(e => e.MatKhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MaSinhVien)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MaLopNienChe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.BANGDIEMs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THOIKHOABIEU>()
                .Property(e => e.MaHocKi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THOIKHOABIEU>()
                .Property(e => e.MaLopMonHoc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THOIKHOABIEU>()
                .Property(e => e.MaThoiKhoaBieu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THOIKHOABIEU>()
                .Property(e => e.MaGiangVien)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}

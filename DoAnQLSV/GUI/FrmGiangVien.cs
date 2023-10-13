using DoAnQLSV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLSV.GUI
{
    public partial class FrmGiangVien : Form
    {
        // để truyền mã giảng viên từ form đăng nhập
        private string Ma;
        public FrmGiangVien()
        {
            InitializeComponent();
        }
        public FrmGiangVien(string s) : this()
        {
            Ma = s;
        }

        private void FrmGiangVien_Load(object sender, EventArgs e)
        {
            StudentModel studentModel = new StudentModel();
            List<GIANGVIEN> gIANGVIENs = studentModel.GIANGVIENs.ToList();
            List<SINHVIEN> sINHVIENs = studentModel.SINHVIENs.ToList();
            List<LOPMONHOC> lOPMONHOCs = studentModel.LOPMONHOCs.ToList();

            KhoaTextBox();
            //HienThiGiangVien(gIANGVIENs);

            // HienThiGiangVien(gIANGVIENs);
        }
        private void KhoaTextBox()
        {
            txtMaSo.Enabled = false;
            txtHoTen.Enabled = false;
            txtNgaySinh.Enabled = false;
            txtGioiTinh.Enabled = false;
            txtChucVu.Enabled = false;
            txtSDT.Enabled = false;
        }
        private void HienThiGiangVien()
        {
            GIANGVIEN gv;
            StudentModel student = new StudentModel();
            gv = student.GIANGVIENs.FirstOrDefault(p => String.Compare(p.MaGiangVien,Ma, StringComparison.Ordinal) == 0);
            if(gv != null)
            {
                txtMaSo.Text = gv.MaGiangVien.ToString();
                txtHoTen.Text = gv.TenGiangVien.ToString();
                txtNgaySinh.Text = gv.NgaySinh.ToString();
                txtGioiTinh.Text = gv.GioiTinh.ToString();
                txtSDT.Text = gv.SoDienThoai.ToString();
                txtChucVu.Text = gv.ChucVu.ToString();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }
    }
}

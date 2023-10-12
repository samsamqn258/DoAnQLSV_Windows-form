using DoAnQLSV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQLSV.GUI
{
    public partial class FrmDangNhap : Form
    {
        // biến mã này để lấy mã của đối tượng
        public string Ma;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        // kiểm tra các kí tự đặc biệt để lại để dùng cho lúc đăng kí tài khoản ở frmquantri
        private bool CheckSpecialCharacters(string input)
        {
            Regex regex = new Regex("[!@#$%^&*()_+~{}|:\"<>?\\[\\]]");
            return regex.IsMatch(input);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
          
            // so sánh chữ hoa và chữ thường
          

            if(txtMatKhau.Text == "" || txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                
                string TaiKhoan = txtTaiKhoan.Text.Trim();
                string MatKhau = txtMatKhau.Text.Trim();

                StudentModel studentmodel = new StudentModel();
                NGUOIDUNG nguoidung;

                nguoidung = studentmodel.NGUOIDUNGs.FirstOrDefault(p => String.Compare(p.TaiKhoan, TaiKhoan, StringComparison.Ordinal) == 0 && String.Compare(p.MatKhau, MatKhau, StringComparison.Ordinal) == 0);
               
                // tồn tại người dùng giả sử như người dùng đó là sinh viên
                if (nguoidung != null)
                {
                    SINHVIEN sinhvien;
                    sinhvien = studentmodel.SINHVIENs.FirstOrDefault(p => p.MaSinhVien == nguoidung.MaSinhVien);
                    // if lần nữa để kiểm tra xem người dùng là đối tượng nào
                    // nếu sinh viên đó tồn tại, tức là sinh viên khác null thì chuyển vào form sinh viên
                    if(sinhvien != null)
                    {
                        
                        Ma = nguoidung.MaSinhVien.Trim();
                        FrmSinhVien frmSinhVien = new FrmSinhVien(Ma);
                        frmSinhVien.ShowDialog();

                    }
                    // sinh viên bằng null tức đó là giảng viên
                    else if (sinhvien == null)
                    {
                        GIANGVIEN giangvien;
                        giangvien = studentmodel.GIANGVIENs.FirstOrDefault(p => p.MaGiangVien == nguoidung.MaGiangVien);

                        Ma = nguoidung.MaGiangVien.Trim();
                        FrmGiangVien frmGiangVien = new FrmGiangVien(Ma);
                        frmGiangVien.ShowDialog();
                    }
                }
                // ngược lại với truongf hợp người dùng != null, thì không tồn tại tài khoản, báo sai tk hoặc mk
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                }
            }
        }

        private void bthThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }
    }
}

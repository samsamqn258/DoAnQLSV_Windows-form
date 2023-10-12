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
    }
}

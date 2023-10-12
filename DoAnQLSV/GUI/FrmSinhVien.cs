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
    public partial class FrmSinhVien : Form
    {
        // để truyền mã sinh viên từ form đăng nhập
        private string Ma;
        public FrmSinhVien()
        {
            InitializeComponent();
        }
        // kế thừa mã sinh viên từ frm đăng nhập
        public FrmSinhVien(string s) : this()
        {
            Ma = s;
        }
    }
}

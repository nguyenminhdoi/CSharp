using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLyThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTheloai_Click(object sender, EventArgs e)
        {
            Form f = new F_TheLoaiSach();
            f.Show();
        }

        private void btnBandoc_Click(object sender, EventArgs e)
        {
            Form f = new F_CapNhatBanDoc();
            f.Show();
        }
    }
}

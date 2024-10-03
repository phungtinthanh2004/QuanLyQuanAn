using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Frm_TrangChu : Form
    {
        public Frm_TrangChu()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime thoiGianHienTai = DateTime.Now;
            string dinhDangThoiGian = thoiGianHienTai.ToString("HH:mm:ss");
            lbl_ThoiGian.Text = dinhDangThoiGian;
        }
    }
}

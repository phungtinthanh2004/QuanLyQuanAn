﻿using System;
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
    public partial class frm_DanhMuc : Form
    {
        public frm_DanhMuc()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pib_HinhAnhDanhMuc.ImageLocation = opf_HinhAnhDanhMuc.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opf_HinhAnhDanhMuc.ShowDialog();
        }
    }
}

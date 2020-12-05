﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLXM
{
    public partial class rp_thongkexebanchay : Form
    {
        public rp_thongkexebanchay()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();

        private void rp_thongkexebanchay_Load(object sender, EventArgs e)
        {
            thongkexebanchaynhat tk = new thongkexebanchaynhat();
            crystalReportViewer1.ReportSource = tk;
        }

        private void btTrove_Click(object sender, EventArgs e)
        {
            MenuNV fr = new MenuNV();
            fr.Show();
            this.Hide();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

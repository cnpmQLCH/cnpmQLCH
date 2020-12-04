using System;
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
    public partial class rp_thongkexeton : Form
    {
        public rp_thongkexeton()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();
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

        private void rp_thongkexeton_Load(object sender, EventArgs e)
        {
            thongkexetonkho tk = new thongkexetonkho();
            crystalReportViewer1.ReportSource = tk;
        }
    }
}

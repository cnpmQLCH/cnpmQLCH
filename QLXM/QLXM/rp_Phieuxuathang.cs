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
    public partial class rp_Phieuxuathang : Form
    {
        public rp_Phieuxuathang()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();
        private void rp_Phieuxuathang_Load(object sender, EventArgs e)
        {
            Phieuxuathang px = new Phieuxuathang();
            px.SetParameterValue("MaHDX", Chitiethoadonxuat.MAHDX);
            crystalReportViewer1.ReportSource = px;
        }

        private void btTrove_Click(object sender, EventArgs e)
        {
            Chitiethoadonxuat fr = new Chitiethoadonxuat();
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

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
    public partial class rp_phieunhaphang : Form
    {
        public rp_phieunhaphang()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();
        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rp_phieunhaphang_Load(object sender, EventArgs e)
        {
            Phieunhaphang pn = new Phieunhaphang();
            pn.SetParameterValue("MaHDN", Chitiethoadonnhap.MAHDN);
            crystalReportViewer1.ReportSource = pn;
        }

        private void btTrove_Click(object sender, EventArgs e)
        {
            Chitiethoadonnhap fr = new Chitiethoadonnhap();
            fr.Show();
            this.Hide();
        }
    }
}

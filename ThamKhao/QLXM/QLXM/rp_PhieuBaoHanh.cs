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
    public partial class rp_PhieuBaoHanh : Form
    {
        public rp_PhieuBaoHanh()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();
        private void rp_PhieuBaoHanh_Load(object sender, EventArgs e)
        {
            PhieuBaoHanh px = new PhieuBaoHanh();
            px.SetParameterValue("mapbh", Capnhatphieubaohanh.MaPhieuBH);
            cry_phieubh.ReportSource = px;
        }

        private void btTrove_Click(object sender, EventArgs e)
        {
            Capnhatphieubaohanh fr = new Capnhatphieubaohanh();
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

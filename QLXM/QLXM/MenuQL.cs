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
    public partial class MenuQL : Form
    {
        public MenuQL()
        {
            InitializeComponent();
        }
        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap fr = new Dangnhap();
            fr.Show();
            this.Hide();
        }

        private void tìmKiếmNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimkiemTTNV fr = new TimkiemTTNV();
            fr.Show();
            this.Hide();
        }

        private void cậpNhậtThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapnhatTTNV fr = new CapnhatTTNV();
            fr.Show();
            this.Hide();
        }

        private void cậpNhậtThôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapnhatNCC fr = new CapnhatNCC();
            fr.Show();
            this.Hide();
        }

        private void cậpNhậtThôngTinXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapnhatXe fr = new CapnhatXe();
            fr.Show();
            this.Hide();
        }
    }
}

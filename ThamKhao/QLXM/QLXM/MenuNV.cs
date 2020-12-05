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
    public partial class MenuNV : Form
    {
        public MenuNV()
        {
            InitializeComponent();
        }

        private void cậpNhậtThôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CapnhatthongtinKH fr = new CapnhatthongtinKH();
            fr.Show();
            this.Hide();
        }

        private void tìmKiếmXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimkiemXe fr = new TimkiemXe();
            fr.Show();
            this.Hide();
        }

        private void cậpNhậtHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhaphang fr = new Nhaphang();
            fr.Show();
            this.Hide();
        }

        private void cậpNhậtHóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xuathang fr = new Xuathang();
            fr.Show();
            this.Hide();
        }

        private void bảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Capnhatphieubaohanh fr = new Capnhatphieubaohanh();
            fr.Show();
            this.Hide();
        }

        private void đĂNGXUẤTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dangnhap fr = new Dangnhap();
            fr.Show();
            this.Hide();
        }

        private void thốngKêXeBánChạyNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rp_thongkexebanchay fr = new rp_thongkexebanchay();
            fr.Show();
            this.Hide();
        }

        private void thốngKêXeTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rp_thongkexeton fr = new rp_thongkexeton();
            fr.Show();
            this.Hide();
        }

        private void tìmKiếmKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimkiemTTKH fr = new TimkiemTTKH();
            fr.Show();
            this.Hide();
        }
    }
}

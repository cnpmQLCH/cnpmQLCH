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
    public partial class TimkiemTTKH : Form
    {
        public TimkiemTTKH()
        {
            InitializeComponent();
        }

        QLXMEntities qlxm = new QLXMEntities();
        private void TimkiemTTKH_Load(object sender, EventArgs e)
        {
            dgvTTKH.DataSource = qlxm.KhachHangs.ToList();
            dgvTTKH.Columns[5].Visible = false;
            dgvTTKH.Columns[6].Visible = false;
            dgvTTKH.Columns[7].Visible = false;
        }
        private void btTim_Click(object sender, EventArgs e)
        {
            if (rdMakh.Checked)
            {
                string s = Microsoft.VisualBasic.Interaction.InputBox("Nhập mã Khách Hàng cần tìm");
                var qr = from d in qlxm.KhachHangs
                         where d.MaKH.Contains(s)
                         select d;
                if (qr.Count() == 0)
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                else
                    dgvTTKH.DataSource = qr.ToList();

            }
            else if (rdTenkh.Checked)
            {
                string s = Microsoft.VisualBasic.Interaction.InputBox("Nhập Tên Khách Hàng cần tìm");
                var qr = from d in qlxm.KhachHangs
                         where d.TenKH.Contains(s)
                         select d;

                if (qr.Count() == 0)
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                else
                    dgvTTKH.DataSource = qr.ToList();
            }
        }

        private void btHienhet_Click(object sender, EventArgs e)
        {
            dgvTTKH.DataSource = qlxm.KhachHangs.ToList();
 
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

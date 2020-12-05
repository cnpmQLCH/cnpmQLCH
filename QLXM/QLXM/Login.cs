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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        QLXMEntities qlxm = new QLXMEntities();
        private void btdangnhap_Click(object sender, EventArgs e)
        {
            if (txttk.Text == "" && txtmk.Text != "")
            {
                MessageBox.Show("Bạn chưa điền thông tin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtmk.Text == "" && txttk.Text != "")
            {
                MessageBox.Show("Bạn chưa điền mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txttk.Text == "" && txtmk.Text == "")
            {
                MessageBox.Show("Chưa điền tài khoản & mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtmk.Text != "" && txttk.Text != "")
            {

                MessageBox.Show("Đăng nhập thành công", "Thông báo");
                Menu fr = new Menu();
                fr.Show();
                this.Hide();
            }
               
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rdnvien_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            else if(txttk.Text == "" && txtmk.Text == "")
            {
                MessageBox.Show("Chưa điền tài khoản & mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtmk.Text != "" && txttk.Text != "")
            {
                if (rdquanli.Checked)
                {

                    var qr = from d in qlxm.Admins
                             where d.Usename == txttk.Text && d.Password == txtmk.Text
                             select d;
                    if (qr.Count() == 0)
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txttk.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        MenuQL fr = new MenuQL();
                        fr.Show();
                        this.Hide();
                    }
                }
                else if (rdnvien.Checked)
                {
                    var qr = from d in qlxm.NhanViens
                             where d.MaNV == txttk.Text && d.Pass == txtmk.Text
                             select d;
                    if (qr.Count() == 0)
                    {
                        MessageBox.Show("Tên đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txttk.Focus();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo");
                        MenuNV fr = new MenuNV();
                        fr.Show();
                        this.Hide();
                    }
                }
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
    }
}

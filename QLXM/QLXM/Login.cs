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
                int id;
                var ad = from d in qlxm.Admins
                         where d.Usename == txttk.Text && d.Password == txtmk.Text
                         select d;

                var nv = from d in qlxm.NhanViens
                         where d.MaNV == txttk.Text && d.Pass == txtmk.Text
                         select d;

                if (ad.Count() == 0 && nv.Count()==0)
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttk.Focus();
                    return;
                }
                else if (ad.Count()!= 0 && nv.Count() == 0 ) //admin
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    id = 0;
                    Menu mn = new Menu(id);
                    mn.Show();
                    this.Hide();
                    
                }
                
                else if(nv.Count() != 0 && ad.Count() == 0) //nhan vien
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    id = 1;
                    Menu mn = new Menu(id);
                    mn.Show();
                    this.Hide();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

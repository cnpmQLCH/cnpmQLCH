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
    public partial class CapnhatNCC : Form
    {
        public CapnhatNCC()
        {
            InitializeComponent();
        }
        QLXMEntities qlxm = new QLXMEntities();
        private void LoadTTNCC()
        {
            dgvDSNCC.DataSource = qlxm.NCCs.ToList();
            dgvDSNCC.Columns[5].Visible = false;
            dgvDSNCC.Columns[6].Visible = false;
        }
        private void CapnhatNCC_Load(object sender, EventArgs e)
        {
            LoadTTNCC();
            vohieuhoa(false);
        }
        private void reset()
        {
            txtMancc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
        }
        private void vohieuhoa(bool kt)
        {
            txtMancc.Enabled = kt;
            txttenncc.Enabled = kt;
            txtdiachi.Enabled = kt;
            txtsdt.Enabled = kt;
            txtemail.Enabled = kt;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (btThem.Text == "Thêm")
            {
                vohieuhoa(true);
                txtMancc.Enabled = true;
                reset();
                txtMancc.Focus();
                btSua.Enabled = false;
                btXoa.Enabled = false;
                btThem.Text = "Lưu";
            }
            else
            {
                btThem.Text = "Thêm";
                if (txtMancc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMancc.Focus();
                    return;
                }
                if (txttenncc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenncc.Focus();
                    return;
                }
                if (txtdiachi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Địa chỉ nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdiachi.Focus();
                    return;
                }
                if (txtsdt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Số điện thoại nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsdt.Focus();
                    return;
                }
                if (txtemail.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Email nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtemail.Focus();
                    return;
                }
                var qr = from d in qlxm.NCCs
                         where d.MaNCC == txtMancc.Text
                         select d;
                if (qr.Count() != 0)
                {
                    MessageBox.Show("Trùng mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    NCC c = new NCC();
                    c.MaNCC = txtMancc.Text;
                    c.TenNCC = txttenncc.Text;
                    c.Diachi = txtdiachi.Text;
                    c.SDT = txtsdt.Text;
                    c.Email = txtemail.Text;
                    qlxm.NCCs.Add(c);
                    qlxm.SaveChanges();
                    MessageBox.Show("Đã thêm thành công", "Thông báo");
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                    reset();
                    LoadTTNCC();
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (btSua.Text == "Sửa")
            {
                btSua.Text = "Lưu";
                vohieuhoa(true);
                txtMancc.Enabled = false;
            }
            else
            {
                if (txtMancc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMancc.Focus();
                    return;
                }
                if (txttenncc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Tên nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenncc.Focus();
                    return;
                }
                if (txtdiachi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Địa chỉ nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtdiachi.Focus();
                    return;
                }
                if (txtsdt.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Số điện thoại nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtsdt.Focus();
                    return;
                }
                if (txtemail.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập Email nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtemail.Focus();
                    return;
                }
                else
                {
                    NCC c = qlxm.NCCs.Single(s => s.MaNCC == txtMancc.Text);
                    c.MaNCC = txtMancc.Text;
                    c.TenNCC = txttenncc.Text;
                    c.Diachi = txtdiachi.Text;
                    c.SDT = txtsdt.Text;
                    c.Email = txtemail.Text;
                    qlxm.SaveChanges();
                    MessageBox.Show("Đã sửa thành công", "Thông báo");
                    reset();
                    LoadTTNCC();
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                for (int i = 0; i < dgvDSNCC.SelectedRows.Count; i++)
                {
                    string st = dgvDSNCC.SelectedRows[i].Cells[0].Value.ToString();
                    var qr = from d in qlxm.NCCs
                             where d.MaNCC == st
                             select d;
                    qlxm.NCCs.Remove(qr.FirstOrDefault());
                }
                qlxm.SaveChanges();
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadTTNCC();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btTrove_Click(object sender, EventArgs e)
        {
            MenuQL fr = new MenuQL();
            fr.Show();
            this.Hide();
        }

        private void dgvDSNCC_SelectionChanged(object sender, EventArgs e)
        {
            txtMancc.Enabled = false;
            if (btThem.Text == "Lưu")
            {
                MessageBox.Show("Đang ở chế độ thêm mới", "Thông báo", MessageBoxButtons.OK);
                txtMancc.Focus();
                return;
            }
            if (dgvDSNCC.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ diệu", "thông báo", MessageBoxButtons.OK);
                return;
            }
            txtMancc.Text = dgvDSNCC.CurrentRow.Cells[0].Value.ToString();
            txttenncc.Text = dgvDSNCC.CurrentRow.Cells[1].Value.ToString();
            txtdiachi.Text = dgvDSNCC.CurrentRow.Cells[2].Value.ToString();
            txtsdt.Text = dgvDSNCC.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = dgvDSNCC.CurrentRow.Cells[4].Value.ToString();
        }
    }
}

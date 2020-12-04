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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesing()
        {
            panelNVSubmenu.Visible = false;
            panelKHSubmenu.Visible = false;
            panelKhoSubmenu.Visible = false;

        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void hideSubMenu()
        {
            if (panelNVSubmenu.Visible == true)
            {
                panelNVSubmenu.Visible = false;
            }
            if (panelKHSubmenu.Visible == true)
            {
                panelKHSubmenu.Visible = false;
            }
            if (panelKhoSubmenu.Visible == true)
            {
                panelKhoSubmenu.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        #region Submenu
        #region Quan Ly Nhan Vien
        private void CRUDNV_Click(object sender, EventArgs e)
        {
            //....
            //Your code
            //....

            hideSubMenu();
        }

        private void PhanQuyen_Click(object sender, EventArgs e)
        {
            //....
            //Your code
            //....

            hideSubMenu();
        }
        #endregion

        #region Quan Ly Khach Hang
        private void CRUDKH_Click(object sender, EventArgs e)
        {
            openChildForm(new CapnhatthongtinKH());
            //....
            //Your code
            //....

            hideSubMenu();
        }

        private void CRUDHD_Click(object sender, EventArgs e)
        {
            //....
            //Your code
            //....

            hideSubMenu();
        }

        private void CRUDBC_Click(object sender, EventArgs e)
        {
            //....
            //Your code
            //....

            hideSubMenu();
        }
        #endregion

        #region Quan Ly Kho
        private void CRUDNCC_Click(object sender, EventArgs e)
        {
            //....
            //Your code
            //....

            hideSubMenu();
        }

        private void CRUDNhapXuat_Click(object sender, EventArgs e)
        {
            //....
            //Your code
            //....

            hideSubMenu();
        }

        private void CRUDSanPham_Click(object sender, EventArgs e)
        {
            //....
            //Your code
            //....

            hideSubMenu();
        }

        private void CRUDBC_Kho_Click(object sender, EventArgs e)
        {

            //....
            //Your code
            //....

            hideSubMenu();
        }
        #endregion
        #endregion

        #region Button Menu
        private void QLNV_Click(object sender, EventArgs e)
        {
            showSubMenu(panelNVSubmenu);
        }

        private void btQLKH_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKHSubmenu);
            
        }

        private void QLKho_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKhoSubmenu);
        }

        #endregion
        private void btExit_Click(object sender, EventArgs e)
        {
            
        }




        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dangnhap fr = new Dangnhap();
                fr.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
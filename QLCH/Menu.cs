using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Đăng_nhập
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

        private void hideSubMenu()
        {
            if(panelNVSubmenu.Visible == true)
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
            if(subMenu.Visible == false)
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
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                LoginForm login = new LoginForm();
                login.Show();
            }
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
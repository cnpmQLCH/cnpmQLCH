using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_Đăng_nhập
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private string getID(string username, string pass)
        {
            string id = "";
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Nhanvien WHERE MA_NV ='" + username + "' AND PASSWORD='" + pass + "'", con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            id = dr["MA_NV"].ToString();
                        }
                    }
                    con.Close();
                }
                return id;
            }
        }

        private int getPermission(string id_user)
        {
            int id_per = 0;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Nhanvien WHERE MA_NV = '" + id_user +"'", con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt != null)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            id_per = (int)dr["QUYEN"];
                        }
                    }
                    con.Close();
                }
            }
            return id_per;
        }


        private void Lb_QuenMatkhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Liên hệ Admin để tạo lại!");
        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            
        }

        private void Txtb_Taikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        public static string ID_USER = "";
        public static int ID_PER = 0;
        private void Btn_Dangnhap_Click(object sender, EventArgs e)
        {
            ID_USER = getID(Txtb_Taikhoan.Text, TxtbMatkhau.Text);
            if (ID_USER != "")
            {
                ID_PER = getPermission(Txtb_Taikhoan.Text);
                if (ID_PER == 0)
                {
                    Menu menu = new Menu();
                    menu.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Phân quyền là: " + ID_PER);
                }
            }
            else
            {
                MessageBox.Show("Tài khoảng hoặc mật khẩu không đúng !");
            }
            
        }

        
    }
}

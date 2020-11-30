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
        public static string ID_USER = "";
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-F18L6VH\SQLEXPRESS;Integrated Security = True");

        private string getID(string ma_nv, string matkhau)
        {
            string id = "";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Nhanvien WHERE MA_NV ='" + ma_nv + "' and PASSWORD='" + matkhau + "'", con);
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
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi xảy ra khi truy vấn dữ liệu hoặc kết nối với server thất bại !");
            }
            finally
            {
                con.Close();
            }
            return id;
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

        private void Btn_Dangnhap_Click(object sender, EventArgs e)
        {
            ID_USER = getID(ma_nv.Text, matkhau.Text);
            if (ID_USER != "")
            {
                MessageBox.Show("Đăng nhập với id: " + ID_USER);
            }
            else
            {
                MessageBox.Show("Tài khoảng và mật khẩu không đúng !");
            }
        }
    }
}

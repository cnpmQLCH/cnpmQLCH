namespace Form_Đăng_nhập
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Txtb_Taikhoan = new System.Windows.Forms.TextBox();
            this.TxtbMatkhau = new System.Windows.Forms.TextBox();
            this.Btn_Thoat = new System.Windows.Forms.Button();
            this.Btn_Dangnhap = new System.Windows.Forms.Button();
            this.Lb_QuenMatkhau = new System.Windows.Forms.LinkLabel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtb_Taikhoan
            // 
            this.Txtb_Taikhoan.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Txtb_Taikhoan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Txtb_Taikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtb_Taikhoan.Location = new System.Drawing.Point(117, 88);
            this.Txtb_Taikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.Txtb_Taikhoan.Name = "Txtb_Taikhoan";
            this.Txtb_Taikhoan.Size = new System.Drawing.Size(197, 23);
            this.Txtb_Taikhoan.TabIndex = 2;
            this.Txtb_Taikhoan.TextChanged += new System.EventHandler(this.Txtb_Taikhoan_TextChanged);
            // 
            // TxtbMatkhau
            // 
            this.TxtbMatkhau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtbMatkhau.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtbMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtbMatkhau.Location = new System.Drawing.Point(117, 129);
            this.TxtbMatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.TxtbMatkhau.Name = "TxtbMatkhau";
            this.TxtbMatkhau.Size = new System.Drawing.Size(197, 23);
            this.TxtbMatkhau.TabIndex = 3;
            this.TxtbMatkhau.TabStop = false;
            this.TxtbMatkhau.UseSystemPasswordChar = true;
            // 
            // Btn_Thoat
            // 
            this.Btn_Thoat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Thoat.AutoSize = true;
            this.Btn_Thoat.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Btn_Thoat.FlatAppearance.BorderSize = 0;
            this.Btn_Thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.Btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Thoat.ForeColor = System.Drawing.Color.Red;
            this.Btn_Thoat.Location = new System.Drawing.Point(234, 165);
            this.Btn_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Thoat.Name = "Btn_Thoat";
            this.Btn_Thoat.Size = new System.Drawing.Size(79, 27);
            this.Btn_Thoat.TabIndex = 5;
            this.Btn_Thoat.Text = "Thoát";
            this.Btn_Thoat.UseVisualStyleBackColor = false;
            this.Btn_Thoat.Click += new System.EventHandler(this.Btn_Thoat_Click);
            // 
            // Btn_Dangnhap
            // 
            this.Btn_Dangnhap.AutoSize = true;
            this.Btn_Dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Dangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Dangnhap.FlatAppearance.BorderSize = 0;
            this.Btn_Dangnhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.Btn_Dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dangnhap.Location = new System.Drawing.Point(88, 165);
            this.Btn_Dangnhap.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Dangnhap.Name = "Btn_Dangnhap";
            this.Btn_Dangnhap.Size = new System.Drawing.Size(88, 27);
            this.Btn_Dangnhap.TabIndex = 7;
            this.Btn_Dangnhap.Text = "Đăng nhập";
            this.Btn_Dangnhap.UseVisualStyleBackColor = false;
            this.Btn_Dangnhap.Click += new System.EventHandler(this.Btn_Dangnhap_Click);
            // 
            // Lb_QuenMatkhau
            // 
            this.Lb_QuenMatkhau.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lb_QuenMatkhau.AutoSize = true;
            this.Lb_QuenMatkhau.BackColor = System.Drawing.Color.Transparent;
            this.Lb_QuenMatkhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lb_QuenMatkhau.Location = new System.Drawing.Point(149, 201);
            this.Lb_QuenMatkhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lb_QuenMatkhau.Name = "Lb_QuenMatkhau";
            this.Lb_QuenMatkhau.Size = new System.Drawing.Size(89, 13);
            this.Lb_QuenMatkhau.TabIndex = 6;
            this.Lb_QuenMatkhau.TabStop = true;
            this.Lb_QuenMatkhau.Text = "Quên mật khẩu ?";
            this.Lb_QuenMatkhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lb_QuenMatkhau_LinkClicked);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.BackgroundImage = global::Form_Đăng_nhập.Properties.Resources.red_honda_logo_motorcycle_brands_png_10;
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 58;
            this.iconPictureBox1.Location = new System.Drawing.Point(154, 10);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(88, 58);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.BackgroundImage = global::Form_Đăng_nhập.Properties.Resources._1200px_User_font_awesome_svg;
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 22;
            this.iconPictureBox2.Location = new System.Drawing.Point(88, 88);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(29, 22);
            this.iconPictureBox2.TabIndex = 10;
            this.iconPictureBox2.TabStop = false;
            this.iconPictureBox2.Click += new System.EventHandler(this.iconPictureBox2_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.BackgroundImage = global::Form_Đăng_nhập.Properties.Resources.lock_password_protect_safety_security_icon_1320086045132546966;
            this.iconPictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 22;
            this.iconPictureBox3.Location = new System.Drawing.Point(88, 129);
            this.iconPictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(29, 22);
            this.iconPictureBox3.TabIndex = 11;
            this.iconPictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.Btn_Dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Form_Đăng_nhập.Properties.Resources.fhEwl;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Btn_Thoat;
            this.ClientSize = new System.Drawing.Size(410, 237);
            this.ControlBox = false;
            this.Controls.Add(this.iconPictureBox3);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.Btn_Thoat);
            this.Controls.Add(this.Btn_Dangnhap);
            this.Controls.Add(this.Txtb_Taikhoan);
            this.Controls.Add(this.Lb_QuenMatkhau);
            this.Controls.Add(this.TxtbMatkhau);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng xe máy";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txtb_Taikhoan;
        private System.Windows.Forms.TextBox TxtbMatkhau;
        private System.Windows.Forms.Button Btn_Thoat;
        private System.Windows.Forms.Button Btn_Dangnhap;
        private System.Windows.Forms.LinkLabel Lb_QuenMatkhau;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}


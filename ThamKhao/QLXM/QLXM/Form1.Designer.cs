namespace QLXM
{
    partial class Dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dangnhap));
            this.label1 = new System.Windows.Forms.Label();
            this.rdquanli = new System.Windows.Forms.RadioButton();
            this.rdnvien = new System.Windows.Forms.RadioButton();
            this.txttk = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.btthoat = new System.Windows.Forms.Button();
            this.btdangnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // rdquanli
            // 
            this.rdquanli.AutoSize = true;
            this.rdquanli.Location = new System.Drawing.Point(165, 303);
            this.rdquanli.Name = "rdquanli";
            this.rdquanli.Size = new System.Drawing.Size(74, 23);
            this.rdquanli.TabIndex = 3;
            this.rdquanli.TabStop = true;
            this.rdquanli.Text = "Quản lý";
            this.rdquanli.UseVisualStyleBackColor = true;
            // 
            // rdnvien
            // 
            this.rdnvien.AutoSize = true;
            this.rdnvien.Location = new System.Drawing.Point(403, 303);
            this.rdnvien.Name = "rdnvien";
            this.rdnvien.Size = new System.Drawing.Size(88, 23);
            this.rdnvien.TabIndex = 4;
            this.rdnvien.TabStop = true;
            this.rdnvien.Text = "Nhân viên";
            this.rdnvien.UseVisualStyleBackColor = true;
            this.rdnvien.CheckedChanged += new System.EventHandler(this.rdnvien_CheckedChanged);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(165, 155);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(326, 26);
            this.txttk.TabIndex = 7;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(165, 230);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(326, 26);
            this.txtmk.TabIndex = 8;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // btthoat
            // 
            this.btthoat.Image = global::QLXM.Properties.Resources.iconfinder_exit_3226;
            this.btthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthoat.Location = new System.Drawing.Point(403, 369);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(88, 30);
            this.btthoat.TabIndex = 6;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // btdangnhap
            // 
            this.btdangnhap.Image = global::QLXM.Properties.Resources.iconfinder_Next_27860;
            this.btdangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdangnhap.Location = new System.Drawing.Point(165, 369);
            this.btdangnhap.Name = "btdangnhap";
            this.btdangnhap.Size = new System.Drawing.Size(111, 30);
            this.btdangnhap.TabIndex = 5;
            this.btdangnhap.Text = "Đăng nhập";
            this.btdangnhap.UseVisualStyleBackColor = true;
            this.btdangnhap.Click += new System.EventHandler(this.btdangnhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::QLXM.Properties.Resources.iconfinder_lock_3239;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(33, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "    Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::QLXM.Properties.Resources.iconfinder_personal_3562__1_;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(33, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "    Tài khoản:";
            // 
            // Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(615, 534);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btdangnhap);
            this.Controls.Add(this.rdnvien);
            this.Controls.Add(this.rdquanli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dangnhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdquanli;
        private System.Windows.Forms.RadioButton rdnvien;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.TextBox txtmk;
    }
}


﻿namespace QLXM
{
    partial class TimkiemTTNV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTTNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdTenNV = new System.Windows.Forms.RadioButton();
            this.rdManv = new System.Windows.Forms.RadioButton();
            this.btThoat = new System.Windows.Forms.Button();
            this.btHienhet = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTTNV);
            this.groupBox1.Location = new System.Drawing.Point(19, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 261);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Nhân viên";
            // 
            // dgvTTNV
            // 
            this.dgvTTNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvTTNV.Location = new System.Drawing.Point(6, 25);
            this.dgvTTNV.Name = "dgvTTNV";
            this.dgvTTNV.RowHeadersWidth = 51;
            this.dgvTTNV.Size = new System.Drawing.Size(934, 230);
            this.dgvTTNV.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Tên NV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GioiTinh";
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Ngaysinh";
            this.Column6.HeaderText = "Ngày Sinh";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Diachi";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "SĐT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ChucVu";
            this.Column7.HeaderText = "Chức Vụ";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CMND";
            this.Column8.HeaderText = "CMND";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Ngayvaolam";
            this.Column9.HeaderText = "Ngày vào làm";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Pass";
            this.Column10.HeaderText = "Password";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "TRA CỨU THÔNG TIN NHÂN VIÊN\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btThoat);
            this.groupBox2.Controls.Add(this.btHienhet);
            this.groupBox2.Controls.Add(this.btTim);
            this.groupBox2.Controls.Add(this.rdTenNV);
            this.groupBox2.Controls.Add(this.rdManv);
            this.groupBox2.Location = new System.Drawing.Point(19, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(940, 155);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tìm kiếm";
            // 
            // rdTenNV
            // 
            this.rdTenNV.AutoSize = true;
            this.rdTenNV.Location = new System.Drawing.Point(56, 97);
            this.rdTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.rdTenNV.Name = "rdTenNV";
            this.rdTenNV.Size = new System.Drawing.Size(148, 26);
            this.rdTenNV.TabIndex = 1;
            this.rdTenNV.TabStop = true;
            this.rdTenNV.Text = "Tên Nhân Viên";
            this.rdTenNV.UseVisualStyleBackColor = true;
            // 
            // rdManv
            // 
            this.rdManv.AutoSize = true;
            this.rdManv.Location = new System.Drawing.Point(56, 42);
            this.rdManv.Margin = new System.Windows.Forms.Padding(4);
            this.rdManv.Name = "rdManv";
            this.rdManv.Size = new System.Drawing.Size(144, 26);
            this.rdManv.TabIndex = 0;
            this.rdManv.TabStop = true;
            this.rdManv.Text = "Mã Nhân Viên";
            this.rdManv.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Image = global::QLXM.Properties.Resources.back3;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(590, 67);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(156, 37);
            this.btThoat.TabIndex = 7;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btHienhet
            // 
            this.btHienhet.Image = global::QLXM.Properties.Resources.show1;
            this.btHienhet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHienhet.Location = new System.Drawing.Point(399, 67);
            this.btHienhet.Margin = new System.Windows.Forms.Padding(4);
            this.btHienhet.Name = "btHienhet";
            this.btHienhet.Size = new System.Drawing.Size(156, 37);
            this.btHienhet.TabIndex = 5;
            this.btHienhet.Text = "Hiện tất cả";
            this.btHienhet.UseVisualStyleBackColor = true;
            this.btHienhet.Click += new System.EventHandler(this.btHienhet_Click);
            // 
            // btTim
            // 
            this.btTim.Image = global::QLXM.Properties.Resources.loupe;
            this.btTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTim.Location = new System.Drawing.Point(257, 67);
            this.btTim.Margin = new System.Windows.Forms.Padding(4);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(100, 37);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // TimkiemTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(977, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimkiemTTNV";
            this.Text = "TimkiemTTNV";
            this.Load += new System.EventHandler(this.TimkiemTTNV_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTTNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btHienhet;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.RadioButton rdTenNV;
        private System.Windows.Forms.RadioButton rdManv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Button btThoat;
    }
}
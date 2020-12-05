namespace QLXM
{
    partial class CapnhatTTNV
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
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNgayvl = new System.Windows.Forms.DateTimePicker();
            this.txtNs = new System.Windows.Forms.DateTimePicker();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtCv = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtgt = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNV
            // 
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNV.Location = new System.Drawing.Point(0, 0);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.RowHeadersWidth = 51;
            this.dgvNV.Size = new System.Drawing.Size(1020, 259);
            this.dgvNV.TabIndex = 0;
            this.dgvNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNV_CellContentClick);
            this.dgvNV.Click += new System.EventHandler(this.dgvNV_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Ngaysinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Diachi";
            this.Column5.HeaderText = "Địa chỉ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "SĐT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ChucVu";
            this.Column7.HeaderText = "Chức vụ";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 259);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btThoat);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 305);
            this.panel2.TabIndex = 16;
            // 
            // btThem
            // 
            this.btThem.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThem.Image = global::QLXM.Properties.Resources.plus2;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(710, 24);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(206, 47);
            this.btThem.TabIndex = 21;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // btSua
            // 
            this.btSua.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSua.Image = global::QLXM.Properties.Resources.edit_button;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(710, 94);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(206, 47);
            this.btSua.TabIndex = 22;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btXoa.Image = global::QLXM.Properties.Resources.trash1;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(710, 170);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(206, 47);
            this.btXoa.TabIndex = 23;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btThoat.Image = global::QLXM.Properties.Resources.back1;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(710, 238);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(206, 47);
            this.btThoat.TabIndex = 24;
            this.btThoat.Text = "Quay lại";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtNgayvl);
            this.groupBox1.Controls.Add(this.txtNs);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtCv);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.txtdc);
            this.groupBox1.Controls.Add(this.txtgt);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtManv);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.MaximumSize = new System.Drawing.Size(689, 281);
            this.groupBox1.MinimumSize = new System.Drawing.Size(592, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 281);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtNgayvl
            // 
            this.txtNgayvl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNgayvl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNgayvl.Location = new System.Drawing.Point(458, 209);
            this.txtNgayvl.Name = "txtNgayvl";
            this.txtNgayvl.Size = new System.Drawing.Size(200, 30);
            this.txtNgayvl.TabIndex = 13;
            // 
            // txtNs
            // 
            this.txtNs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNs.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNs.Location = new System.Drawing.Point(458, 133);
            this.txtNs.Name = "txtNs";
            this.txtNs.Size = new System.Drawing.Size(200, 30);
            this.txtNs.TabIndex = 12;
            // 
            // txtpass
            // 
            this.txtpass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtpass.Location = new System.Drawing.Point(458, 55);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(199, 30);
            this.txtpass.TabIndex = 11;
            // 
            // txtCMND
            // 
            this.txtCMND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCMND.Location = new System.Drawing.Point(458, 93);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(199, 30);
            this.txtCMND.TabIndex = 11;
            // 
            // txtCv
            // 
            this.txtCv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCv.Location = new System.Drawing.Point(105, 212);
            this.txtCv.Name = "txtCv";
            this.txtCv.Size = new System.Drawing.Size(204, 30);
            this.txtCv.TabIndex = 11;
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSdt.Location = new System.Drawing.Point(459, 173);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(199, 30);
            this.txtSdt.TabIndex = 11;
            // 
            // txtdc
            // 
            this.txtdc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdc.Location = new System.Drawing.Point(104, 176);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(204, 30);
            this.txtdc.TabIndex = 11;
            // 
            // txtgt
            // 
            this.txtgt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtgt.Location = new System.Drawing.Point(104, 140);
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(204, 30);
            this.txtgt.TabIndex = 11;
            // 
            // txthoten
            // 
            this.txthoten.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txthoten.Location = new System.Drawing.Point(104, 98);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(204, 30);
            this.txthoten.TabIndex = 11;
            // 
            // txtManv
            // 
            this.txtManv.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtManv.Location = new System.Drawing.Point(104, 59);
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(204, 30);
            this.txtManv.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(358, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Password:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(326, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 22);
            this.label10.TabIndex = 9;
            this.label10.Text = "Ngày vào làm:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(352, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 22);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số CMND:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(331, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(357, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày sinh:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(15, 221);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Chức vụ:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ tên:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(22, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(9, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính:";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = global::QLXM.Properties.Resources.loupe3;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(933, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 120);
            this.button1.TabIndex = 25;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CapnhatTTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1020, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CapnhatTTNV";
            this.Text = "CapnhatTTNV";
            this.Load += new System.EventHandler(this.CapnhatTTNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtNgayvl;
        private System.Windows.Forms.DateTimePicker txtNs;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtCv;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtgt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button button1;
    }
}
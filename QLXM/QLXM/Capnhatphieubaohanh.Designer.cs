namespace QLXM
{
    partial class Capnhatphieubaohanh
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
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvphieuxuat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtngaymua = new System.Windows.Forms.DateTimePicker();
            this.dgvbh = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.txttgbh = new System.Windows.Forms.TextBox();
            this.txtmaxe = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.txtmaphieubh = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuxuat)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbh)).BeginInit();
            this.SuspendLayout();
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btThem.Image = global::QLXM.Properties.Resources.plus1;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(868, 135);
            this.btThem.MaximumSize = new System.Drawing.Size(175, 50);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(175, 50);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btSua.Image = global::QLXM.Properties.Resources.edit_button1;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(868, 200);
            this.btSua.MaximumSize = new System.Drawing.Size(175, 50);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(175, 50);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoa.Image = global::QLXM.Properties.Resources.trash;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(868, 266);
            this.btXoa.MaximumSize = new System.Drawing.Size(175, 50);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(175, 50);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Image = global::QLXM.Properties.Resources.back;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(868, 329);
            this.btThoat.MaximumSize = new System.Drawing.Size(175, 50);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(175, 50);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Quay lại";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.MaximumSize = new System.Drawing.Size(687, 206);
            this.panel1.MinimumSize = new System.Drawing.Size(687, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 206);
            this.panel1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvphieuxuat);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(687, 206);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn mua hàng";
            // 
            // dgvphieuxuat
            // 
            this.dgvphieuxuat.AllowUserToAddRows = false;
            this.dgvphieuxuat.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvphieuxuat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvphieuxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieuxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvphieuxuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvphieuxuat.GridColor = System.Drawing.Color.Silver;
            this.dgvphieuxuat.Location = new System.Drawing.Point(3, 26);
            this.dgvphieuxuat.Name = "dgvphieuxuat";
            this.dgvphieuxuat.RowHeadersWidth = 51;
            this.dgvphieuxuat.Size = new System.Drawing.Size(681, 177);
            this.dgvphieuxuat.TabIndex = 0;
            this.dgvphieuxuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvphieuxuat_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHDX";
            this.Column1.HeaderText = "MaHDX";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaXe";
            this.Column2.HeaderText = "Mã Xe";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNV";
            this.Column3.HeaderText = "Mã NV";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaKH";
            this.Column4.HeaderText = "Mã KH";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayXuat";
            this.Column5.HeaderText = "Ngày Xuất";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(14, 224);
            this.panel2.MaximumSize = new System.Drawing.Size(809, 314);
            this.panel2.MinimumSize = new System.Drawing.Size(684, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 314);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtngaymua);
            this.groupBox1.Controls.Add(this.dgvbh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.txttgbh);
            this.groupBox1.Controls.Add(this.txtmaxe);
            this.groupBox1.Controls.Add(this.txtmakh);
            this.groupBox1.Controls.Add(this.txtmaphieubh);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MinimumSize = new System.Drawing.Size(684, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bảo hành";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtngaymua
            // 
            this.txtngaymua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaymua.Location = new System.Drawing.Point(440, 126);
            this.txtngaymua.Name = "txtngaymua";
            this.txtngaymua.Size = new System.Drawing.Size(159, 30);
            this.txtngaymua.TabIndex = 8;
            // 
            // dgvbh
            // 
            this.dgvbh.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvbh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvbh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvbh.GridColor = System.Drawing.Color.Silver;
            this.dgvbh.Location = new System.Drawing.Point(3, 171);
            this.dgvbh.Name = "dgvbh";
            this.dgvbh.RowHeadersWidth = 51;
            this.dgvbh.Size = new System.Drawing.Size(803, 140);
            this.dgvbh.TabIndex = 7;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaPhieuBH";
            this.Column6.HeaderText = "Mã Phiếu BH";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaKH";
            this.Column7.HeaderText = "Mã KH";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaNV";
            this.Column8.HeaderText = "Mã NV";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaXe";
            this.Column9.HeaderText = "Mã Xe";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TGBH";
            this.Column10.HeaderText = "Thời Gian BH";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "NgayMua";
            this.Column11.HeaderText = "Ngày Mua";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(331, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Mua:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(331, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "TGBH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(331, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Xe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(29, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã KH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phiếu BH:";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(143, 121);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(159, 30);
            this.txtmanv.TabIndex = 0;
            // 
            // txttgbh
            // 
            this.txttgbh.Location = new System.Drawing.Point(440, 80);
            this.txttgbh.Name = "txttgbh";
            this.txttgbh.Size = new System.Drawing.Size(159, 30);
            this.txttgbh.TabIndex = 0;
            // 
            // txtmaxe
            // 
            this.txtmaxe.Location = new System.Drawing.Point(440, 39);
            this.txtmaxe.Name = "txtmaxe";
            this.txtmaxe.Size = new System.Drawing.Size(159, 30);
            this.txtmaxe.TabIndex = 0;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(143, 80);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(159, 30);
            this.txtmakh.TabIndex = 0;
            // 
            // txtmaphieubh
            // 
            this.txtmaphieubh.Location = new System.Drawing.Point(143, 39);
            this.txtmaphieubh.Name = "txtmaphieubh";
            this.txtmaphieubh.Size = new System.Drawing.Size(159, 30);
            this.txtmaphieubh.TabIndex = 0;
            // 
            // Capnhatphieubaohanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1070, 550);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Capnhatphieubaohanh";
            this.Text = "Capnhatphieubaohanh";
            this.Load += new System.EventHandler(this.Capnhatphieubaohanh_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuxuat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvphieuxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtngaymua;
        private System.Windows.Forms.DataGridView dgvbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txttgbh;
        private System.Windows.Forms.TextBox txtmaxe;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.TextBox txtmaphieubh;
    }
}
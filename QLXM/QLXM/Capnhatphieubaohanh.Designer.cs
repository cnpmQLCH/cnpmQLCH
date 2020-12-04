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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvphieuxuat = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btTrove = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btinphieu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbh)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuxuat)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin phiếu bảo hành";
            // 
            // txtngaymua
            // 
            this.txtngaymua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaymua.Location = new System.Drawing.Point(419, 126);
            this.txtngaymua.Name = "txtngaymua";
            this.txtngaymua.Size = new System.Drawing.Size(159, 26);
            this.txtngaymua.TabIndex = 8;
            // 
            // dgvbh
            // 
            this.dgvbh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgvbh.Location = new System.Drawing.Point(6, 209);
            this.dgvbh.Name = "dgvbh";
            this.dgvbh.Size = new System.Drawing.Size(645, 177);
            this.dgvbh.TabIndex = 7;
            this.dgvbh.Click += new System.EventHandler(this.dgvbh_Click);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "MaPhieuBH";
            this.Column6.HeaderText = "Mã Phiếu BH";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaKH";
            this.Column7.HeaderText = "Mã KH";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaNV";
            this.Column8.HeaderText = "Mã NV";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MaXe";
            this.Column9.HeaderText = "Mã Xe";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TGBH";
            this.Column10.HeaderText = "Thời Gian BH";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "NgayMua";
            this.Column11.HeaderText = "Ngày Mua";
            this.Column11.Name = "Column11";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(331, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Mua:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "TGBH:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Xe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã KH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phiếu BH:";
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(143, 121);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(159, 26);
            this.txtmanv.TabIndex = 0;
            // 
            // txttgbh
            // 
            this.txttgbh.Location = new System.Drawing.Point(419, 80);
            this.txttgbh.Name = "txttgbh";
            this.txttgbh.Size = new System.Drawing.Size(159, 26);
            this.txttgbh.TabIndex = 0;
            // 
            // txtmaxe
            // 
            this.txtmaxe.Location = new System.Drawing.Point(419, 39);
            this.txtmaxe.Name = "txtmaxe";
            this.txtmaxe.Size = new System.Drawing.Size(159, 26);
            this.txtmaxe.TabIndex = 0;
            // 
            // txtmakh
            // 
            this.txtmakh.Location = new System.Drawing.Point(143, 80);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(159, 26);
            this.txtmakh.TabIndex = 0;
            // 
            // txtmaphieubh
            // 
            this.txtmaphieubh.Location = new System.Drawing.Point(143, 39);
            this.txtmaphieubh.Name = "txtmaphieubh";
            this.txtmaphieubh.Size = new System.Drawing.Size(159, 26);
            this.txtmaphieubh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "CẬP NHẬT PHIẾU BẢO HÀNH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvphieuxuat);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 198);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phiếu xuất hàng";
            // 
            // dgvphieuxuat
            // 
            this.dgvphieuxuat.AllowUserToAddRows = false;
            this.dgvphieuxuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvphieuxuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvphieuxuat.Location = new System.Drawing.Point(18, 18);
            this.dgvphieuxuat.Name = "dgvphieuxuat";
            this.dgvphieuxuat.Size = new System.Drawing.Size(546, 163);
            this.dgvphieuxuat.TabIndex = 0;
            this.dgvphieuxuat.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHDX";
            this.Column1.HeaderText = "MaHDX";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaXe";
            this.Column2.HeaderText = "Mã Xe";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaNV";
            this.Column3.HeaderText = "Mã NV";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaKH";
            this.Column4.HeaderText = "Mã KH";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayXuat";
            this.Column5.HeaderText = "Ngày Xuất";
            this.Column5.Name = "Column5";
            // 
            // btTrove
            // 
            this.btTrove.Image = global::QLXM.Properties.Resources.iconfinder_Undo_27885;
            this.btTrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTrove.Location = new System.Drawing.Point(737, 160);
            this.btTrove.Name = "btTrove";
            this.btTrove.Size = new System.Drawing.Size(164, 27);
            this.btTrove.TabIndex = 3;
            this.btTrove.Text = "Trở về";
            this.btTrove.UseVisualStyleBackColor = true;
            this.btTrove.Click += new System.EventHandler(this.btTrove_Click);
            // 
            // btThem
            // 
            this.btThem.Image = global::QLXM.Properties.Resources.iconfinder_add_101239;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(737, 224);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(164, 27);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Image = global::QLXM.Properties.Resources.iconfinder_edit_3218;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(737, 289);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(164, 27);
            this.btSua.TabIndex = 3;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = global::QLXM.Properties.Resources.iconfinder_Remove_27874;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(737, 355);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(164, 27);
            this.btXoa.TabIndex = 3;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Image = global::QLXM.Properties.Resources.iconfinder_exit_3226;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(737, 418);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(164, 27);
            this.btThoat.TabIndex = 3;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btinphieu
            // 
            this.btinphieu.Image = global::QLXM.Properties.Resources.iconfinder_print_printer_1500;
            this.btinphieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btinphieu.Location = new System.Drawing.Point(737, 484);
            this.btinphieu.Name = "btinphieu";
            this.btinphieu.Size = new System.Drawing.Size(164, 27);
            this.btinphieu.TabIndex = 3;
            this.btinphieu.Text = "In Phiếu Bảo Hành";
            this.btinphieu.UseVisualStyleBackColor = true;
            this.btinphieu.Click += new System.EventHandler(this.btinphieu_Click);
            // 
            // Capnhatphieubaohanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(947, 686);
            this.Controls.Add(this.btinphieu);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTrove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Capnhatphieubaohanh";
            this.Text = "Capnhatphieubaohanh";
            this.Load += new System.EventHandler(this.Capnhatphieubaohanh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbh)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvphieuxuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaphieubh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvphieuxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DateTimePicker txtngaymua;
        private System.Windows.Forms.DataGridView dgvbh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.TextBox txttgbh;
        private System.Windows.Forms.TextBox txtmaxe;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Button btTrove;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btinphieu;
    }
}
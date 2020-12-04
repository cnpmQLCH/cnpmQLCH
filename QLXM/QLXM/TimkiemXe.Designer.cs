namespace QLXM
{
    partial class TimkiemXe
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
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            this.txt_mancc = new System.Windows.Forms.TextBox();
            this.txt_tenxe = new System.Windows.Forms.TextBox();
            this.cb_tt = new System.Windows.Forms.CheckBox();
            this.cb_mancc = new System.Windows.Forms.CheckBox();
            this.cb_tenxe = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ht = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttrove = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.btHienhet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ht)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Controls.Add(this.bttrove);
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.btHienhet);
            this.groupBox1.Controls.Add(this.txt_tinhtrang);
            this.groupBox1.Controls.Add(this.txt_mancc);
            this.groupBox1.Controls.Add(this.txt_tenxe);
            this.groupBox1.Controls.Add(this.cb_tt);
            this.groupBox1.Controls.Add(this.cb_mancc);
            this.groupBox1.Controls.Add(this.cb_tenxe);
            this.groupBox1.Location = new System.Drawing.Point(21, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiêu chí tìm kiếm";
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Location = new System.Drawing.Point(162, 154);
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(165, 26);
            this.txt_tinhtrang.TabIndex = 3;
            // 
            // txt_mancc
            // 
            this.txt_mancc.Location = new System.Drawing.Point(162, 95);
            this.txt_mancc.Name = "txt_mancc";
            this.txt_mancc.Size = new System.Drawing.Size(165, 26);
            this.txt_mancc.TabIndex = 3;
            // 
            // txt_tenxe
            // 
            this.txt_tenxe.Location = new System.Drawing.Point(162, 39);
            this.txt_tenxe.Name = "txt_tenxe";
            this.txt_tenxe.Size = new System.Drawing.Size(165, 26);
            this.txt_tenxe.TabIndex = 3;
            // 
            // cb_tt
            // 
            this.cb_tt.AutoSize = true;
            this.cb_tt.Location = new System.Drawing.Point(32, 157);
            this.cb_tt.Name = "cb_tt";
            this.cb_tt.Size = new System.Drawing.Size(88, 23);
            this.cb_tt.TabIndex = 2;
            this.cb_tt.Text = "Tình trạng";
            this.cb_tt.UseVisualStyleBackColor = true;
            this.cb_tt.CheckedChanged += new System.EventHandler(this.cb_tt_CheckedChanged);
            // 
            // cb_mancc
            // 
            this.cb_mancc.AutoSize = true;
            this.cb_mancc.Location = new System.Drawing.Point(32, 98);
            this.cb_mancc.Name = "cb_mancc";
            this.cb_mancc.Size = new System.Drawing.Size(87, 23);
            this.cb_mancc.TabIndex = 1;
            this.cb_mancc.Text = "Mã NCC";
            this.cb_mancc.UseVisualStyleBackColor = true;
            this.cb_mancc.CheckedChanged += new System.EventHandler(this.cb_mancc_CheckedChanged);
            // 
            // cb_tenxe
            // 
            this.cb_tenxe.AutoSize = true;
            this.cb_tenxe.Location = new System.Drawing.Point(32, 39);
            this.cb_tenxe.Name = "cb_tenxe";
            this.cb_tenxe.Size = new System.Drawing.Size(69, 23);
            this.cb_tenxe.TabIndex = 0;
            this.cb_tenxe.Text = "Tên xe";
            this.cb_tenxe.UseVisualStyleBackColor = true;
            this.cb_tenxe.CheckedChanged += new System.EventHandler(this.cb_tenxe_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRA CỨU THÔNG TIN XE";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ht);
            this.groupBox2.Location = new System.Drawing.Point(21, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 201);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Xe";
            // 
            // dgv_ht
            // 
            this.dgv_ht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ht.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgv_ht.Location = new System.Drawing.Point(15, 25);
            this.dgv_ht.Name = "dgv_ht";
            this.dgv_ht.Size = new System.Drawing.Size(680, 170);
            this.dgv_ht.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaXe";
            this.Column1.HeaderText = "Mã Xe";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenXe";
            this.Column2.HeaderText = "Tên Xe";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Maloaixe";
            this.Column3.HeaderText = "Mã loại xe";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaNCC";
            this.Column4.HeaderText = "Mã NCC";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GiaNhap";
            this.Column5.HeaderText = "Giá Nhập";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "GiaBan";
            this.Column6.HeaderText = "Giá Bán";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SoLuong";
            this.Column7.HeaderText = "Số Lượng";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "SoKhung";
            this.Column8.HeaderText = "Số Khung";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "SoMay";
            this.Column9.HeaderText = "Số Máy";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Mau";
            this.Column10.HeaderText = "Màu";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Dungtich";
            this.Column11.HeaderText = "Dung Tích";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "TinhTrang";
            this.Column12.HeaderText = "Tình Trạng";
            this.Column12.Name = "Column12";
            // 
            // bttrove
            // 
            this.bttrove.Image = global::QLXM.Properties.Resources.iconfinder_Undo_27885;
            this.bttrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttrove.Location = new System.Drawing.Point(571, 71);
            this.bttrove.Name = "bttrove";
            this.bttrove.Size = new System.Drawing.Size(102, 29);
            this.bttrove.TabIndex = 17;
            this.bttrove.Text = "Trở về";
            this.bttrove.UseVisualStyleBackColor = true;
            this.bttrove.Click += new System.EventHandler(this.bttrove_Click);
            // 
            // btThoat
            // 
            this.btThoat.Image = global::QLXM.Properties.Resources.iconfinder_exit_3226;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(571, 131);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(102, 27);
            this.btThoat.TabIndex = 4;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTim
            // 
            this.btTim.Image = global::QLXM.Properties.Resources.search__1_;
            this.btTim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTim.Location = new System.Drawing.Point(436, 72);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(102, 28);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btHienhet
            // 
            this.btHienhet.Image = global::QLXM.Properties.Resources.iconfinder_Preview_27868;
            this.btHienhet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHienhet.Location = new System.Drawing.Point(436, 130);
            this.btHienhet.Name = "btHienhet";
            this.btHienhet.Size = new System.Drawing.Size(102, 28);
            this.btHienhet.TabIndex = 4;
            this.btHienhet.Text = "Hiện hết";
            this.btHienhet.UseVisualStyleBackColor = true;
            this.btHienhet.Click += new System.EventHandler(this.btHienhet_Click);
            // 
            // TimkiemXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(745, 520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimkiemXe";
            this.Text = "TimkiemXe";
            this.Load += new System.EventHandler(this.TimkiemXe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ht)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_tt;
        private System.Windows.Forms.CheckBox cb_mancc;
        private System.Windows.Forms.CheckBox cb_tenxe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btHienhet;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txt_tinhtrang;
        private System.Windows.Forms.TextBox txt_mancc;
        private System.Windows.Forms.TextBox txt_tenxe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_ht;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button bttrove;
    }
}
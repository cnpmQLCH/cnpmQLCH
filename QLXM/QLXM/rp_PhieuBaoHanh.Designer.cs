namespace QLXM
{
    partial class rp_PhieuBaoHanh
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
            this.cry_phieubh = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btTrove = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cry_phieubh
            // 
            this.cry_phieubh.ActiveViewIndex = -1;
            this.cry_phieubh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cry_phieubh.Cursor = System.Windows.Forms.Cursors.Default;
            this.cry_phieubh.Location = new System.Drawing.Point(-1, 2);
            this.cry_phieubh.Name = "cry_phieubh";
            this.cry_phieubh.Size = new System.Drawing.Size(837, 597);
            this.cry_phieubh.TabIndex = 0;
            this.cry_phieubh.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btTrove
            // 
            this.btTrove.Image = global::QLXM.Properties.Resources.iconfinder_Undo_27885;
            this.btTrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTrove.Location = new System.Drawing.Point(12, 617);
            this.btTrove.Name = "btTrove";
            this.btTrove.Size = new System.Drawing.Size(99, 29);
            this.btTrove.TabIndex = 1;
            this.btTrove.Text = "Trở về";
            this.btTrove.UseVisualStyleBackColor = true;
            this.btTrove.Click += new System.EventHandler(this.btTrove_Click);
            // 
            // btThoat
            // 
            this.btThoat.Image = global::QLXM.Properties.Resources.iconfinder_exit_3226;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(725, 617);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(99, 29);
            this.btThoat.TabIndex = 1;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // rp_PhieuBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(836, 658);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTrove);
            this.Controls.Add(this.cry_phieubh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rp_PhieuBaoHanh";
            this.Text = "rp_PhieuBaoHanh";
            this.Load += new System.EventHandler(this.rp_PhieuBaoHanh_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cry_phieubh;
        private System.Windows.Forms.Button btTrove;
        private System.Windows.Forms.Button btThoat;
    }
}
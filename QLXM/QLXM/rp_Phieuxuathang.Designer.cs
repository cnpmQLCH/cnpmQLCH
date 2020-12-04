namespace QLXM
{
    partial class rp_Phieuxuathang
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTrove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(805, 686);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btThoat
            // 
            this.btThoat.Image = global::QLXM.Properties.Resources.iconfinder_exit_3226;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(695, 692);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(99, 29);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTrove
            // 
            this.btTrove.Image = global::QLXM.Properties.Resources.iconfinder_Undo_27885;
            this.btTrove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTrove.Location = new System.Drawing.Point(12, 692);
            this.btTrove.Name = "btTrove";
            this.btTrove.Size = new System.Drawing.Size(99, 29);
            this.btTrove.TabIndex = 3;
            this.btTrove.Text = "Trở về";
            this.btTrove.UseVisualStyleBackColor = true;
            this.btTrove.Click += new System.EventHandler(this.btTrove_Click);
            // 
            // rp_Phieuxuathang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 733);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTrove);
            this.Controls.Add(this.crystalReportViewer1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "rp_Phieuxuathang";
            this.Text = "rp_Phieuxuathang";
            this.Load += new System.EventHandler(this.rp_Phieuxuathang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTrove;
    }
}
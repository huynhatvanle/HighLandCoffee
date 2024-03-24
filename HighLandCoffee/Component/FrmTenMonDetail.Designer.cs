namespace HighLandCoffee.Component
{
    partial class FrmTenMonDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbhuy = new Label();
            txtgiaDetail = new TextBox();
            txttenmonDetail = new TextBox();
            label1 = new Label();
            ptbMon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbMon).BeginInit();
            SuspendLayout();
            // 
            // lbhuy
            // 
            lbhuy.AutoSize = true;
            lbhuy.Cursor = Cursors.Hand;
            lbhuy.ForeColor = Color.FromArgb(192, 0, 0);
            lbhuy.Location = new Point(263, 157);
            lbhuy.Name = "lbhuy";
            lbhuy.Size = new Size(57, 20);
            lbhuy.TabIndex = 9;
            lbhuy.Text = "Hủy bỏ";
            lbhuy.Click += lbhuy_Click;
            // 
            // txtgiaDetail
            // 
            txtgiaDetail.Location = new Point(173, 90);
            txtgiaDetail.Name = "txtgiaDetail";
            txtgiaDetail.Size = new Size(125, 27);
            txtgiaDetail.TabIndex = 8;
            // 
            // txttenmonDetail
            // 
            txttenmonDetail.Location = new Point(173, 30);
            txttenmonDetail.Name = "txttenmonDetail";
            txttenmonDetail.Size = new Size(125, 27);
            txttenmonDetail.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(197, 18);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 6;
            // 
            // ptbMon
            // 
            ptbMon.Location = new Point(16, 18);
            ptbMon.Name = "ptbMon";
            ptbMon.Size = new Size(138, 130);
            ptbMon.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMon.TabIndex = 5;
            ptbMon.TabStop = false;
            // 
            // FrmTenMonDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbhuy);
            Controls.Add(txtgiaDetail);
            Controls.Add(txttenmonDetail);
            Controls.Add(label1);
            Controls.Add(ptbMon);
            Name = "FrmTenMonDetail";
            Size = new Size(336, 195);
            Load += FrmTenMonDetail_Load;
            ((System.ComponentModel.ISupportInitialize)ptbMon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbhuy;
        private TextBox txtgiaDetail;
        private TextBox txttenmonDetail;
        private Label label1;
        private PictureBox ptbMon;
    }
}

namespace HighLandCoffee.Component
{
    partial class FrmTenMon
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
            ptbTenmon = new PictureBox();
            lbtenmon = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbTenmon).BeginInit();
            SuspendLayout();
            // 
            // ptbTenmon
            // 
            ptbTenmon.Location = new Point(12, 13);
            ptbTenmon.Name = "ptbTenmon";
            ptbTenmon.Size = new Size(161, 156);
            ptbTenmon.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbTenmon.TabIndex = 4;
            ptbTenmon.TabStop = false;
            ptbTenmon.Click += pictureBox1_Click;
            ptbTenmon.MouseDoubleClick += ptbTenmon_MouseDoubleClick;
            // 
            // lbtenmon
            // 
            lbtenmon.AutoSize = true;
            lbtenmon.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbtenmon.Location = new Point(12, 182);
            lbtenmon.Name = "lbtenmon";
            lbtenmon.Size = new Size(79, 18);
            lbtenmon.TabIndex = 3;
            lbtenmon.Text = "Tên món";
            // 
            // FrmTenMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            Controls.Add(ptbTenmon);
            Controls.Add(lbtenmon);
            Cursor = Cursors.Hand;
            Name = "FrmTenMon";
            Size = new Size(182, 211);
            Load += FrmTenMon_Load;
            MouseClick += FrmTenMon_MouseClick;
            MouseDoubleClick += FrmTenMon_MouseDoubleClick;
            ((System.ComponentModel.ISupportInitialize)ptbTenmon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbTenmon;
        private Label lbtenmon;
    }
}

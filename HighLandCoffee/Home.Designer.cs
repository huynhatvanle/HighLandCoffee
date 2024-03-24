namespace HighLandCoffee
{
    partial class Home
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
            ptbDatmon = new PictureBox();
            ptbMenu = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnBack = new PictureBox();
            label3 = new Label();
            ptbHD = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbDatmon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbHD).BeginInit();
            SuspendLayout();
            // 
            // ptbDatmon
            // 
            ptbDatmon.BackgroundImage = Properties.Resources.background;
            ptbDatmon.Image = Properties.Resources.order;
            ptbDatmon.Location = new Point(157, 205);
            ptbDatmon.Name = "ptbDatmon";
            ptbDatmon.Size = new Size(166, 121);
            ptbDatmon.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbDatmon.TabIndex = 0;
            ptbDatmon.TabStop = false;
            ptbDatmon.Click += pictureBox1_Click;
            // 
            // ptbMenu
            // 
            ptbMenu.BackgroundImage = Properties.Resources.background;
            ptbMenu.Image = Properties.Resources.ql_menu;
            ptbMenu.Location = new Point(480, 205);
            ptbMenu.Name = "ptbMenu";
            ptbMenu.Size = new Size(176, 121);
            ptbMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbMenu.TabIndex = 3;
            ptbMenu.TabStop = false;
            ptbMenu.Click += ptbMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.background;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(65, 33, 33);
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.background;
            label1.Location = new Point(172, 329);
            label1.Name = "label1";
            label1.Size = new Size(132, 36);
            label1.TabIndex = 27;
            label1.Text = "Đặt món";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(65, 33, 33);
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Image = Properties.Resources.background;
            label2.Location = new Point(465, 329);
            label2.Name = "label2";
            label2.Size = new Size(210, 36);
            label2.TabIndex = 28;
            label2.Text = "Quản lý menu";
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = Properties.Resources.background;
            btnBack.Image = Properties.Resources.back1;
            btnBack.Location = new Point(18, 537);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 37);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 31;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(65, 33, 33);
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Image = Properties.Resources.background;
            label3.Location = new Point(800, 329);
            label3.Name = "label3";
            label3.Size = new Size(249, 36);
            label3.TabIndex = 29;
            label3.Text = "Quản lý hóa đơn";
            // 
            // ptbHD
            // 
            ptbHD.BackgroundImage = Properties.Resources.background;
            ptbHD.Image = Properties.Resources.money;
            ptbHD.Location = new Point(836, 205);
            ptbHD.Name = "ptbHD";
            ptbHD.Size = new Size(166, 121);
            ptbHD.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbHD.TabIndex = 2;
            ptbHD.TabStop = false;
            ptbHD.Click += ptbHD_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1123, 586);
            ControlBox = false;
            Controls.Add(btnBack);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ptbMenu);
            Controls.Add(ptbHD);
            Controls.Add(ptbDatmon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)ptbDatmon).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbHD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbDatmon;
        private PictureBox ptbMenu;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private PictureBox btnBack;
        private Label label3;
        private PictureBox ptbHD;
    }
}
namespace HighLandCoffee
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txttendn = new TextBox();
            btnDn = new Button();
            btnThoat = new Button();
            txtpass = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = Properties.Resources.background;
            pictureBox1.Image = Properties.Resources.logo;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(190, 149, 91);
            label1.Image = Properties.Resources.background;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // txttendn
            // 
            txttendn.BackColor = Color.FromArgb(224, 224, 224);
            resources.ApplyResources(txttendn, "txttendn");
            txttendn.ForeColor = Color.Gray;
            txttendn.Name = "txttendn";
            // 
            // btnDn
            // 
            btnDn.BackColor = Color.FromArgb(190, 149, 91);
            btnDn.BackgroundImage = Properties.Resources.backgroundbtn;
            resources.ApplyResources(btnDn, "btnDn");
            btnDn.ForeColor = Color.White;
            btnDn.Name = "btnDn";
            btnDn.UseVisualStyleBackColor = false;
            btnDn.Click += btnDn_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(190, 149, 91);
            btnThoat.BackgroundImage = Properties.Resources.backgroundbtn;
            resources.ApplyResources(btnThoat, "btnThoat");
            btnThoat.ForeColor = Color.White;
            btnThoat.Name = "btnThoat";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // txtpass
            // 
            txtpass.BackColor = Color.FromArgb(224, 224, 224);
            resources.ApplyResources(txtpass, "txtpass");
            txtpass.ForeColor = Color.Gray;
            txtpass.Name = "txtpass";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(190, 149, 91);
            label2.Image = Properties.Resources.background;
            label2.Name = "label2";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.backgroundbtn;
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.backgroundbtn;
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(190, 149, 91);
            BackgroundImage = Properties.Resources.background;
            CancelButton = btnThoat;
            ControlBox = false;
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(txtpass);
            Controls.Add(label2);
            Controls.Add(btnThoat);
            Controls.Add(btnDn);
            Controls.Add(txttendn);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            TransparencyKey = Color.IndianRed;
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txttendn;
        private Button btnDn;
        private Button btnThoat;
        private TextBox txtpass;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
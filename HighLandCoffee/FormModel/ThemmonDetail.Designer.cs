namespace HighLandCoffee.FormModelDetail
{
    partial class ThemmonDetail
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
            lbDetail = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ptbAnhmon = new PictureBox();
            btnDongy = new Button();
            button2 = new Button();
            panel1 = new Panel();
            txttendetail = new TextBox();
            txtgiadetail = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            cbbloai = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)ptbAnhmon).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lbDetail
            // 
            lbDetail.AutoSize = true;
            lbDetail.BackColor = Color.Firebrick;
            lbDetail.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetail.ForeColor = Color.White;
            lbDetail.Location = new Point(109, 18);
            lbDetail.Name = "lbDetail";
            lbDetail.Size = new Size(236, 29);
            lbDetail.TabIndex = 0;
            lbDetail.Text = "THÊM THÔNG TIN";
            lbDetail.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 86);
            label2.Name = "label2";
            label2.Size = new Size(74, 18);
            label2.TabIndex = 1;
            label2.Text = "Tên món";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 194);
            label3.Name = "label3";
            label3.Size = new Size(80, 18);
            label3.TabIndex = 2;
            label3.Text = "Giá thành";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(18, 240);
            label4.Name = "label4";
            label4.Size = new Size(74, 18);
            label4.TabIndex = 3;
            label4.Text = "Hình ảnh";
            // 
            // ptbAnhmon
            // 
            ptbAnhmon.ErrorImage = null;
            ptbAnhmon.Location = new Point(126, 251);
            ptbAnhmon.Name = "ptbAnhmon";
            ptbAnhmon.Size = new Size(117, 136);
            ptbAnhmon.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAnhmon.TabIndex = 4;
            ptbAnhmon.TabStop = false;
            ptbAnhmon.Click += ptbAnhmon_Click;
            // 
            // btnDongy
            // 
            btnDongy.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDongy.ForeColor = Color.White;
            btnDongy.Image = Properties.Resources.backgroundbtn;
            btnDongy.Location = new Point(69, 420);
            btnDongy.Name = "btnDongy";
            btnDongy.Size = new Size(108, 39);
            btnDongy.TabIndex = 5;
            btnDongy.Text = "Đồng ý ";
            btnDongy.UseVisualStyleBackColor = true;
            btnDongy.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.backgroundbtn;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.backgroundbtn1;
            button2.Location = new Point(209, 420);
            button2.Name = "button2";
            button2.Size = new Size(108, 39);
            button2.TabIndex = 6;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbDetail);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 63);
            panel1.TabIndex = 7;
            // 
            // txttendetail
            // 
            txttendetail.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttendetail.Location = new Point(112, 82);
            txttendetail.Multiline = true;
            txttendetail.Name = "txttendetail";
            txttendetail.Size = new Size(333, 34);
            txttendetail.TabIndex = 8;
            txttendetail.TextChanged += textBox1_TextChanged;
            // 
            // txtgiadetail
            // 
            txtgiadetail.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtgiadetail.Location = new Point(109, 190);
            txtgiadetail.Multiline = true;
            txtgiadetail.Name = "txtgiadetail";
            txtgiadetail.Size = new Size(336, 34);
            txtgiadetail.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = Properties.Resources.backgroundbtn1;
            pictureBox3.Location = new Point(243, 251);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 138);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.backgroundbtn;
            pictureBox2.Location = new Point(126, 388);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 10);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 149);
            label1.Name = "label1";
            label1.Size = new Size(40, 18);
            label1.TabIndex = 29;
            label1.Text = "Loại";
            // 
            // cbbloai
            // 
            cbbloai.FormattingEnabled = true;
            cbbloai.Location = new Point(110, 139);
            cbbloai.Name = "cbbloai";
            cbbloai.Size = new Size(336, 28);
            cbbloai.TabIndex = 30;
            // 
            // ThemmonDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(458, 487);
            Controls.Add(cbbloai);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(txtgiadetail);
            Controls.Add(txttendetail);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(btnDongy);
            Controls.Add(ptbAnhmon);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "ThemmonDetail";
            Text = "ThemmonDetail";
            Load += ThemmonDetail_Load;
            ((System.ComponentModel.ISupportInitialize)ptbAnhmon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbDetail;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox ptbAnhmon;
        private Button btnDongy;
        private Button button2;
        private Panel panel1;
        private TextBox txttendetail;
        private TextBox txtgiadetail;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label1;
        private ComboBox cbbloai;
    }
}
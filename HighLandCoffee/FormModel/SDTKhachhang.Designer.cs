namespace HighLandCoffee.FormModel
{
    partial class SDTKhachhang
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
            panel1 = new Panel();
            label1 = new Label();
            txtSdt = new TextBox();
            btnHuy = new Button();
            btndongy = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 65);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 81);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 9;
            label1.Text = "Nhập số điện thoại";
            // 
            // txtSdt
            // 
            txtSdt.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSdt.Location = new Point(33, 114);
            txtSdt.Multiline = true;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(460, 34);
            txtSdt.TabIndex = 10;
            txtSdt.TextChanged += textBox1_TextChanged;
            // 
            // btnHuy
            // 
            btnHuy.BackgroundImage = Properties.Resources.backgroundbtn;
            btnHuy.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuy.ForeColor = Color.White;
            btnHuy.Image = Properties.Resources.backgroundbtn1;
            btnHuy.Location = new Point(266, 215);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(108, 39);
            btnHuy.TabIndex = 12;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btndongy
            // 
            btndongy.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btndongy.ForeColor = Color.White;
            btndongy.Image = Properties.Resources.backgroundbtn;
            btndongy.Location = new Point(116, 215);
            btndongy.Name = "btndongy";
            btndongy.Size = new Size(108, 39);
            btndongy.TabIndex = 11;
            btndongy.Text = "Đồng ý ";
            btndongy.UseVisualStyleBackColor = true;
            btndongy.Click += button1_Click;
            // 
            // SDTKhachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(537, 280);
            ControlBox = false;
            Controls.Add(btnHuy);
            Controls.Add(btndongy);
            Controls.Add(txtSdt);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "SDTKhachhang";
            Text = "SDTKhachhang";
            Load += SDTKhachhang_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtSdt;
        private Button btnHuy;
        private Button btndongy;
    }
}
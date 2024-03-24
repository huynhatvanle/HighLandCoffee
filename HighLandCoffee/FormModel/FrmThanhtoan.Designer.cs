namespace HighLandCoffee.FormModel
{
    partial class FrmThanhtoan
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
            panel3 = new Panel();
            lbDetail = new Label();
            txttenkhachhang = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label1 = new Label();
            btnThanhtoan = new Button();
            txtsotienthanhtoan = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txttenkhachhang);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 330);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Firebrick;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lbDetail);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(483, 71);
            panel3.TabIndex = 9;
            // 
            // lbDetail
            // 
            lbDetail.AutoSize = true;
            lbDetail.BackColor = Color.Firebrick;
            lbDetail.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetail.ForeColor = Color.White;
            lbDetail.Location = new Point(55, 18);
            lbDetail.Name = "lbDetail";
            lbDetail.Size = new Size(379, 32);
            lbDetail.TabIndex = 1;
            lbDetail.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txttenkhachhang
            // 
            txttenkhachhang.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttenkhachhang.Location = new Point(159, 107);
            txttenkhachhang.Multiline = true;
            txttenkhachhang.Name = "txttenkhachhang";
            txttenkhachhang.Size = new Size(319, 34);
            txttenkhachhang.TabIndex = 3;
            txttenkhachhang.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên khách hàng";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnThanhtoan);
            panel2.Controls.Add(txtsotienthanhtoan);
            panel2.Location = new Point(492, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 330);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Firebrick;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label1);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(376, 71);
            panel4.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(94, 15);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 1;
            label1.Text = "THANH TOÁN";
            label1.Click += label1_Click;
            // 
            // btnThanhtoan
            // 
            btnThanhtoan.BackgroundImage = Properties.Resources.backgroundbtn;
            btnThanhtoan.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhtoan.ForeColor = Color.White;
            btnThanhtoan.Location = new Point(67, 257);
            btnThanhtoan.Name = "btnThanhtoan";
            btnThanhtoan.Size = new Size(237, 53);
            btnThanhtoan.TabIndex = 3;
            btnThanhtoan.Text = "THANH TOÁN";
            btnThanhtoan.UseVisualStyleBackColor = true;
            btnThanhtoan.Click += btnThanhtoan_Click;
            // 
            // txtsotienthanhtoan
            // 
            txtsotienthanhtoan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtsotienthanhtoan.Location = new Point(28, 100);
            txtsotienthanhtoan.Multiline = true;
            txtsotienthanhtoan.Name = "txtsotienthanhtoan";
            txtsotienthanhtoan.Size = new Size(325, 34);
            txtsotienthanhtoan.TabIndex = 2;
            // 
            // FrmThanhtoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 332);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmThanhtoan";
            Text = "FrmThanhtoan";
            Load += FrmThanhtoan_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txttenkhachhang;
        private Label label2;
        private TextBox txtsotienthanhtoan;
        private Button btnThanhtoan;
        private Panel panel3;
        private Label lbDetail;
        private Panel panel4;
        private Label label1;
    }
}
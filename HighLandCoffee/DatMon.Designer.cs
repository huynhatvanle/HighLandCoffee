namespace HighLandCoffee
{
    partial class DatMon
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            flowmenu = new FlowLayoutPanel();
            txttimkiem = new TextBox();
            panel3 = new Panel();
            btnkhac = new Button();
            pictureBox5 = new PictureBox();
            btncaphe = new Button();
            pictureBox4 = new PictureBox();
            btndoan = new Button();
            pictureBox3 = new PictureBox();
            btnthucuong = new Button();
            pictureBox2 = new PictureBox();
            btnall = new Button();
            pictureBox1 = new PictureBox();
            monanDTOBindingSource3 = new BindingSource(components);
            panel2 = new Panel();
            billFlowPanel = new FlowLayoutPanel();
            txtTongtien = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnThanhToan = new Button();
            monanDTOBindingSource = new BindingSource(components);
            monanDTOBindingSource1 = new BindingSource(components);
            monanDTOBindingSource2 = new BindingSource(components);
            btnBack = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(flowmenu);
            panel1.Controls.Add(txttimkiem);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(18, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 542);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // flowmenu
            // 
            flowmenu.AutoScroll = true;
            flowmenu.Location = new Point(169, 80);
            flowmenu.Name = "flowmenu";
            flowmenu.Size = new Size(592, 421);
            flowmenu.TabIndex = 2;
            flowmenu.Paint += flowmenu_Paint;
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txttimkiem.Location = new Point(199, 11);
            txttimkiem.Multiline = true;
            txttimkiem.Name = "txttimkiem";
            txttimkiem.PlaceholderText = "Tìm kiếm...";
            txttimkiem.Size = new Size(501, 39);
            txttimkiem.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.bgrpink1;
            panel3.Controls.Add(btnkhac);
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(btncaphe);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(btndoan);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(btnthucuong);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(btnall);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(163, 542);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // btnkhac
            // 
            btnkhac.BackgroundImage = Properties.Resources.bgrpink;
            btnkhac.Cursor = Cursors.Hand;
            btnkhac.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnkhac.ForeColor = Color.White;
            btnkhac.Location = new Point(54, 318);
            btnkhac.Name = "btnkhac";
            btnkhac.Size = new Size(100, 74);
            btnkhac.TabIndex = 9;
            btnkhac.Text = "Khác";
            btnkhac.TextAlign = ContentAlignment.MiddleLeft;
            btnkhac.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.bgrpink;
            pictureBox5.ErrorImage = null;
            pictureBox5.Image = Properties.Resources.different;
            pictureBox5.Location = new Point(0, 318);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(54, 74);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // btncaphe
            // 
            btncaphe.BackgroundImage = Properties.Resources.bgrpink;
            btncaphe.Cursor = Cursors.Hand;
            btncaphe.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btncaphe.ForeColor = Color.White;
            btncaphe.Location = new Point(54, 238);
            btncaphe.Name = "btncaphe";
            btncaphe.Size = new Size(100, 74);
            btncaphe.TabIndex = 7;
            btncaphe.Text = "Cà phê";
            btncaphe.TextAlign = ContentAlignment.MiddleLeft;
            btncaphe.UseVisualStyleBackColor = true;
            btncaphe.Click += btncaphe_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.bgrpink;
            pictureBox4.ErrorImage = null;
            pictureBox4.Image = Properties.Resources.cafe;
            pictureBox4.Location = new Point(0, 238);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 74);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // btndoan
            // 
            btndoan.BackgroundImage = Properties.Resources.bgrpink;
            btndoan.Cursor = Cursors.Hand;
            btndoan.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btndoan.ForeColor = Color.White;
            btndoan.Location = new Point(54, 160);
            btndoan.Name = "btndoan";
            btndoan.Size = new Size(100, 74);
            btndoan.TabIndex = 5;
            btndoan.Text = "Đồ ăn";
            btndoan.TextAlign = ContentAlignment.MiddleLeft;
            btndoan.UseVisualStyleBackColor = true;
            btndoan.Click += btndoan_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.bgrpink;
            pictureBox3.ErrorImage = null;
            pictureBox3.Image = Properties.Resources.food;
            pictureBox3.Location = new Point(0, 160);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(54, 74);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnthucuong
            // 
            btnthucuong.BackgroundImage = Properties.Resources.bgrpink;
            btnthucuong.Cursor = Cursors.Hand;
            btnthucuong.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnthucuong.ForeColor = Color.White;
            btnthucuong.Location = new Point(54, 80);
            btnthucuong.Name = "btnthucuong";
            btnthucuong.Size = new Size(100, 74);
            btnthucuong.TabIndex = 3;
            btnthucuong.Text = "Thức uống";
            btnthucuong.TextAlign = ContentAlignment.MiddleLeft;
            btnthucuong.UseVisualStyleBackColor = true;
            btnthucuong.Click += btnthucuong_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.bgrpink;
            pictureBox2.ErrorImage = null;
            pictureBox2.Image = Properties.Resources.drink;
            pictureBox2.Location = new Point(0, 80);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnall
            // 
            btnall.BackgroundImage = Properties.Resources.bgrpink;
            btnall.Cursor = Cursors.Hand;
            btnall.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnall.ForeColor = Color.White;
            btnall.Location = new Point(54, 0);
            btnall.Name = "btnall";
            btnall.Size = new Size(100, 74);
            btnall.TabIndex = 1;
            btnall.Text = "Tất cả";
            btnall.TextAlign = ContentAlignment.MiddleLeft;
            btnall.UseVisualStyleBackColor = true;
            btnall.Click += btnall_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bgrpink;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = Properties.Resources.all;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // monanDTOBindingSource3
            // 
            monanDTOBindingSource3.DataSource = typeof(DTO.MonanDTO);
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(billFlowPanel);
            panel2.Controls.Add(txtTongtien);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnThanhToan);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(788, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(410, 542);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint_1;
            // 
            // billFlowPanel
            // 
            billFlowPanel.AutoScroll = true;
            billFlowPanel.Location = new Point(6, 80);
            billFlowPanel.Name = "billFlowPanel";
            billFlowPanel.Size = new Size(404, 332);
            billFlowPanel.TabIndex = 5;
            // 
            // txtTongtien
            // 
            txtTongtien.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtTongtien.Location = new Point(145, 427);
            txtTongtien.Name = "txtTongtien";
            txtTongtien.Size = new Size(219, 34);
            txtTongtien.TabIndex = 4;
            txtTongtien.Text = "0";
            txtTongtien.TextChanged += txtTongtien_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 0);
            label2.Location = new Point(18, 427);
            label2.Name = "label2";
            label2.Size = new Size(131, 29);
            label2.TabIndex = 3;
            label2.Text = "Tổng tiền:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(54, 14);
            label1.Name = "label1";
            label1.Size = new Size(325, 29);
            label1.TabIndex = 1;
            label1.Text = "DANH SÁCH MÓN ORDER";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackgroundImage = Properties.Resources.backgroundbtn;
            btnThanhToan.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThanhToan.Location = new Point(85, 470);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(241, 59);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "THANH TOÁN";
            btnThanhToan.UseVisualStyleBackColor = true;
            btnThanhToan.Click += button1_Click;
            // 
            // monanDTOBindingSource
            // 
            monanDTOBindingSource.DataSource = typeof(DTO.MonanDTO);
            // 
            // monanDTOBindingSource1
            // 
            monanDTOBindingSource1.DataSource = typeof(DTO.MonanDTO);
            // 
            // monanDTOBindingSource2
            // 
            monanDTOBindingSource2.DataSource = typeof(DTO.MonanDTO);
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = Properties.Resources.background;
            btnBack.Image = Properties.Resources.back1;
            btnBack.Location = new Point(7, 575);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 37);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 32;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // DatMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1201, 619);
            ControlBox = false;
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DatMon";
            Text = "DatMon";
            Load += DatMon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btnthucuong;
        private PictureBox pictureBox2;
        private Button btnall;
        private Button btnkhac;
        private PictureBox pictureBox5;
        private Button btncaphe;
        private PictureBox pictureBox4;
        private Button btndoan;
        private PictureBox pictureBox3;
        private Label label1;
        private Button btnThanhToan;
        private BindingSource monanDTOBindingSource;
        private BindingSource monanDTOBindingSource1;
        private BindingSource monanDTOBindingSource2;
        private BindingSource monanDTOBindingSource3;
        private Label label2;
        private PictureBox btnBack;
        private FlowLayoutPanel flowmenu;
        private TextBox txtTongtien;
        private TextBox txttimkiem;
        private FlowLayoutPanel billFlowPanel;
    }
}
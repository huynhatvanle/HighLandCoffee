namespace HighLandCoffee
{
    partial class HoaDon
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
            monanDTOBindingSource = new BindingSource(components);
            loaiDTOBindingSource1 = new BindingSource(components);
            GridHoadon = new DataGridView();
            mahdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            makhDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ngaymuaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoadonDTOBindingSource = new BindingSource(components);
            btnBack = new PictureBox();
            loaiDTOBindingSource = new BindingSource(components);
            btnXoaHD = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnXem = new Button();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaiDTOBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridHoadon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hoadonDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaiDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // monanDTOBindingSource
            // 
            monanDTOBindingSource.DataSource = typeof(DTO.MonanDTO);
            // 
            // loaiDTOBindingSource1
            // 
            loaiDTOBindingSource1.DataSource = typeof(DTO.LoaiDTO);
            // 
            // GridHoadon
            // 
            GridHoadon.AutoGenerateColumns = false;
            GridHoadon.BackgroundColor = Color.White;
            GridHoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridHoadon.Columns.AddRange(new DataGridViewColumn[] { mahdDataGridViewTextBoxColumn, makhDataGridViewTextBoxColumn, ngaymuaDataGridViewTextBoxColumn });
            GridHoadon.DataSource = hoadonDTOBindingSource;
            GridHoadon.Location = new Point(0, 0);
            GridHoadon.Name = "GridHoadon";
            GridHoadon.RowHeadersWidth = 51;
            GridHoadon.RowTemplate.Height = 40;
            GridHoadon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridHoadon.Size = new Size(1146, 324);
            GridHoadon.TabIndex = 0;
            GridHoadon.CellContentClick += GridHoadon_CellContentClick;
            GridHoadon.CellMouseDoubleClick += GridHoadon_CellMouseDoubleClick;
            // 
            // mahdDataGridViewTextBoxColumn
            // 
            mahdDataGridViewTextBoxColumn.DataPropertyName = "Mahd";
            mahdDataGridViewTextBoxColumn.HeaderText = "Mahd";
            mahdDataGridViewTextBoxColumn.MinimumWidth = 6;
            mahdDataGridViewTextBoxColumn.Name = "mahdDataGridViewTextBoxColumn";
            mahdDataGridViewTextBoxColumn.Width = 388;
            // 
            // makhDataGridViewTextBoxColumn
            // 
            makhDataGridViewTextBoxColumn.DataPropertyName = "Makh";
            makhDataGridViewTextBoxColumn.HeaderText = "Makh";
            makhDataGridViewTextBoxColumn.MinimumWidth = 6;
            makhDataGridViewTextBoxColumn.Name = "makhDataGridViewTextBoxColumn";
            makhDataGridViewTextBoxColumn.Width = 388;
            // 
            // ngaymuaDataGridViewTextBoxColumn
            // 
            ngaymuaDataGridViewTextBoxColumn.DataPropertyName = "Ngaymua";
            ngaymuaDataGridViewTextBoxColumn.HeaderText = "Ngaymua";
            ngaymuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            ngaymuaDataGridViewTextBoxColumn.Name = "ngaymuaDataGridViewTextBoxColumn";
            ngaymuaDataGridViewTextBoxColumn.Width = 388;
            // 
            // hoadonDTOBindingSource
            // 
            hoadonDTOBindingSource.DataSource = typeof(DTO.HoadonDTO);
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = Properties.Resources.background;
            btnBack.Image = Properties.Resources.back1;
            btnBack.Location = new Point(29, 531);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 37);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 41;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // loaiDTOBindingSource
            // 
            loaiDTOBindingSource.DataSource = typeof(DTO.LoaiDTO);
            // 
            // btnXoaHD
            // 
            btnXoaHD.BackgroundImage = Properties.Resources.backgroundbtn;
            btnXoaHD.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaHD.ForeColor = Color.White;
            btnXoaHD.Location = new Point(956, 531);
            btnXoaHD.Name = "btnXoaHD";
            btnXoaHD.Size = new Size(208, 42);
            btnXoaHD.TabIndex = 36;
            btnXoaHD.Text = "XÓA HÓA ĐƠN";
            btnXoaHD.UseVisualStyleBackColor = true;
            btnXoaHD.Click += btnXoaHD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.background;
            label1.Location = new Point(174, 81);
            label1.Name = "label1";
            label1.Size = new Size(249, 29);
            label1.TabIndex = 35;
            label1.Text = "QUẢN LÝ HÓA ĐƠN";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.background;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(20, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(GridHoadon);
            panel1.Location = new Point(20, 171);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 327);
            panel1.TabIndex = 33;
            // 
            // btnXem
            // 
            btnXem.BackgroundImage = Properties.Resources.backgroundbtn;
            btnXem.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXem.ForeColor = Color.White;
            btnXem.Location = new Point(608, 531);
            btnXem.Name = "btnXem";
            btnXem.Size = new Size(324, 42);
            btnXem.TabIndex = 42;
            btnXem.Text = "XEM CHI TIẾT HÓA ĐƠN";
            btnXem.UseVisualStyleBackColor = true;
            btnXem.Click += btnXem_Click;
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1204, 604);
            ControlBox = false;
            Controls.Add(btnXem);
            Controls.Add(btnBack);
            Controls.Add(btnXoaHD);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "HoaDon";
            Text = "HoaDon";
            Load += HoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaiDTOBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridHoadon).EndInit();
            ((System.ComponentModel.ISupportInitialize)hoadonDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaiDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn ngaynhapDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenmonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mamonDataGridViewTextBoxColumn;
        private BindingSource monanDTOBindingSource;
        private BindingSource loaiDTOBindingSource1;
        private DataGridView GridHoadon;
        private DataGridView GridMonmenu;
        private DataGridViewTextBoxColumn anhDataGridViewTextBoxColumn;
        private PictureBox btnBack;
        private BindingSource loaiDTOBindingSource;
        private Button btnThemmenu;
        private Button btnSuamenu;
        private Button btnXoaHD;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private BindingSource hoadonDTOBindingSource;
        private DataGridViewTextBoxColumn mahdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn makhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ngaymuaDataGridViewTextBoxColumn;
        private Button btnXem;
    }
}
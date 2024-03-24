namespace HighLandCoffee
{
    partial class Menu
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
            GridMonmenu = new DataGridView();
            anhDataGridViewTextBoxColumn = new DataGridViewImageColumn();
            tenmonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monanDTOBindingSource1 = new BindingSource(components);
            monanDTOBindingSource = new BindingSource(components);
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnXoamenu = new Button();
            btnSuamenu = new Button();
            btnThemmenu = new Button();
            txttimkiem = new TextBox();
            loaiDTOBindingSource = new BindingSource(components);
            btnBack = new PictureBox();
            loaiDTOBindingSource1 = new BindingSource(components);
            cbbLoai = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridMonmenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaiDTOBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loaiDTOBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(GridMonmenu);
            panel1.Location = new Point(12, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(1164, 327);
            panel1.TabIndex = 0;
            // 
            // GridMonmenu
            // 
            GridMonmenu.AutoGenerateColumns = false;
            GridMonmenu.BackgroundColor = Color.White;
            GridMonmenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridMonmenu.Columns.AddRange(new DataGridViewColumn[] { anhDataGridViewTextBoxColumn, tenmonDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn });
            GridMonmenu.DataSource = monanDTOBindingSource1;
            GridMonmenu.Location = new Point(0, 0);
            GridMonmenu.Name = "GridMonmenu";
            GridMonmenu.RowHeadersWidth = 51;
            GridMonmenu.RowTemplate.Height = 50;
            GridMonmenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridMonmenu.Size = new Size(1164, 327);
            GridMonmenu.TabIndex = 0;
            GridMonmenu.CellContentClick += GridMonmenu_CellContentClick;
            // 
            // anhDataGridViewTextBoxColumn
            // 
            anhDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            anhDataGridViewTextBoxColumn.DataPropertyName = "Anh";
            anhDataGridViewTextBoxColumn.HeaderText = "Anh";
            anhDataGridViewTextBoxColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            anhDataGridViewTextBoxColumn.MinimumWidth = 6;
            anhDataGridViewTextBoxColumn.Name = "anhDataGridViewTextBoxColumn";
            anhDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            anhDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            anhDataGridViewTextBoxColumn.Width = 188;
            // 
            // tenmonDataGridViewTextBoxColumn
            // 
            tenmonDataGridViewTextBoxColumn.DataPropertyName = "Tenmon";
            tenmonDataGridViewTextBoxColumn.HeaderText = "Tenmon";
            tenmonDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenmonDataGridViewTextBoxColumn.Name = "tenmonDataGridViewTextBoxColumn";
            tenmonDataGridViewTextBoxColumn.Width = 488;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            giaDataGridViewTextBoxColumn.Width = 488;
            // 
            // monanDTOBindingSource1
            // 
            monanDTOBindingSource1.DataSource = typeof(DTO.MonanDTO);
            // 
            // monanDTOBindingSource
            // 
            monanDTOBindingSource.DataSource = typeof(DTO.MonanDTO);
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.background;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.background;
            label1.Location = new Point(166, 61);
            label1.Name = "label1";
            label1.Size = new Size(206, 29);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ MENU";
            // 
            // btnXoamenu
            // 
            btnXoamenu.BackgroundImage = Properties.Resources.backgroundbtn;
            btnXoamenu.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoamenu.ForeColor = Color.White;
            btnXoamenu.Location = new Point(779, 511);
            btnXoamenu.Name = "btnXoamenu";
            btnXoamenu.Size = new Size(178, 42);
            btnXoamenu.TabIndex = 3;
            btnXoamenu.Text = "XÓA MÓN";
            btnXoamenu.UseVisualStyleBackColor = true;
            btnXoamenu.Click += btnXoamenu_Click;
            // 
            // btnSuamenu
            // 
            btnSuamenu.BackgroundImage = Properties.Resources.backgroundbtn;
            btnSuamenu.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuamenu.ForeColor = Color.White;
            btnSuamenu.Location = new Point(963, 511);
            btnSuamenu.Name = "btnSuamenu";
            btnSuamenu.Size = new Size(178, 42);
            btnSuamenu.TabIndex = 4;
            btnSuamenu.Text = "SỬA MÓN";
            btnSuamenu.UseVisualStyleBackColor = true;
            btnSuamenu.Click += btnSuamenu_Click;
            // 
            // btnThemmenu
            // 
            btnThemmenu.BackgroundImage = Properties.Resources.backgroundbtn;
            btnThemmenu.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnThemmenu.ForeColor = Color.White;
            btnThemmenu.Location = new Point(595, 511);
            btnThemmenu.Name = "btnThemmenu";
            btnThemmenu.Size = new Size(178, 42);
            btnThemmenu.TabIndex = 5;
            btnThemmenu.Text = "THÊM MÓN";
            btnThemmenu.UseVisualStyleBackColor = true;
            btnThemmenu.Click += btnThemmenu_Click;
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txttimkiem.Location = new Point(631, 88);
            txttimkiem.Multiline = true;
            txttimkiem.Name = "txttimkiem";
            txttimkiem.PlaceholderText = "Tìm kiếm...";
            txttimkiem.Size = new Size(300, 39);
            txttimkiem.TabIndex = 6;
            txttimkiem.TextChanged += txttimkiem_TextChanged;
            txttimkiem.KeyPress += txttimkiem_KeyPress;
            // 
            // loaiDTOBindingSource
            // 
            loaiDTOBindingSource.DataSource = typeof(DTO.LoaiDTO);
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = Properties.Resources.background;
            btnBack.Image = Properties.Resources.back1;
            btnBack.Location = new Point(21, 511);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(65, 37);
            btnBack.SizeMode = PictureBoxSizeMode.Zoom;
            btnBack.TabIndex = 32;
            btnBack.TabStop = false;
            btnBack.Click += btnBack_Click;
            // 
            // loaiDTOBindingSource1
            // 
            loaiDTOBindingSource1.DataSource = typeof(DTO.LoaiDTO);
            // 
            // cbbLoai
            // 
            cbbLoai.FormattingEnabled = true;
            cbbLoai.Location = new Point(948, 95);
            cbbLoai.Name = "cbbLoai";
            cbbLoai.Size = new Size(228, 28);
            cbbLoai.TabIndex = 33;
            cbbLoai.SelectedIndexChanged += cbbLoai_SelectedIndexChanged_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1188, 565);
            ControlBox = false;
            Controls.Add(cbbLoai);
            Controls.Add(btnBack);
            Controls.Add(txttimkiem);
            Controls.Add(btnThemmenu);
            Controls.Add(btnSuamenu);
            Controls.Add(btnXoamenu);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridMonmenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)monanDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaiDTOBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)loaiDTOBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnXoamenu;
        private Button btnSuamenu;
        private Button btnThemmenu;
        private TextBox txttimkiem;
        private BindingSource loaiDTOBindingSource;
        private PictureBox btnBack;
        private DataGridView GridMonmenu;
        private BindingSource monanDTOBindingSource;
        private BindingSource loaiDTOBindingSource1;
        private ComboBox cbbLoai;
        private BindingSource monanDTOBindingSource1;
        private DataGridViewImageColumn anhDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenmonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
    }
}
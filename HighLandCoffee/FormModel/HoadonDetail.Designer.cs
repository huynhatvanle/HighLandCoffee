namespace HighLandCoffee.FormModel
{
    partial class HoadonDetail
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
            lbDetail = new Label();
            Gridchitiet = new DataGridView();
            machitietDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            soluongDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            giaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tenmonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            chitietHDDTOBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Gridchitiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chitietHDDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lbDetail);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(944, 66);
            panel1.TabIndex = 13;
            // 
            // lbDetail
            // 
            lbDetail.AutoSize = true;
            lbDetail.BackColor = Color.Firebrick;
            lbDetail.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbDetail.ForeColor = Color.White;
            lbDetail.Location = new Point(333, 14);
            lbDetail.Name = "lbDetail";
            lbDetail.Size = new Size(246, 29);
            lbDetail.TabIndex = 1;
            lbDetail.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // Gridchitiet
            // 
            Gridchitiet.AutoGenerateColumns = false;
            Gridchitiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Gridchitiet.Columns.AddRange(new DataGridViewColumn[] { machitietDataGridViewTextBoxColumn, soluongDataGridViewTextBoxColumn, giaDataGridViewTextBoxColumn, tenmonDataGridViewTextBoxColumn });
            Gridchitiet.DataSource = chitietHDDTOBindingSource;
            Gridchitiet.Location = new Point(1, 66);
            Gridchitiet.Name = "Gridchitiet";
            Gridchitiet.RowHeadersWidth = 51;
            Gridchitiet.RowTemplate.Height = 29;
            Gridchitiet.Size = new Size(944, 292);
            Gridchitiet.TabIndex = 18;
            // 
            // machitietDataGridViewTextBoxColumn
            // 
            machitietDataGridViewTextBoxColumn.DataPropertyName = "Machitiet";
            machitietDataGridViewTextBoxColumn.HeaderText = "Machitiet";
            machitietDataGridViewTextBoxColumn.MinimumWidth = 6;
            machitietDataGridViewTextBoxColumn.Name = "machitietDataGridViewTextBoxColumn";
            machitietDataGridViewTextBoxColumn.Width = 263;
            // 
            // soluongDataGridViewTextBoxColumn
            // 
            soluongDataGridViewTextBoxColumn.DataPropertyName = "Soluong";
            soluongDataGridViewTextBoxColumn.HeaderText = "Soluong";
            soluongDataGridViewTextBoxColumn.MinimumWidth = 6;
            soluongDataGridViewTextBoxColumn.Name = "soluongDataGridViewTextBoxColumn";
            soluongDataGridViewTextBoxColumn.Width = 263;
            // 
            // giaDataGridViewTextBoxColumn
            // 
            giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            giaDataGridViewTextBoxColumn.HeaderText = "Gia";
            giaDataGridViewTextBoxColumn.MinimumWidth = 6;
            giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            giaDataGridViewTextBoxColumn.Width = 263;
            // 
            // tenmonDataGridViewTextBoxColumn
            // 
            tenmonDataGridViewTextBoxColumn.DataPropertyName = "Tenmon";
            tenmonDataGridViewTextBoxColumn.HeaderText = "Tenmon";
            tenmonDataGridViewTextBoxColumn.MinimumWidth = 6;
            tenmonDataGridViewTextBoxColumn.Name = "tenmonDataGridViewTextBoxColumn";
            tenmonDataGridViewTextBoxColumn.Width = 263;
            // 
            // chitietHDDTOBindingSource
            // 
            chitietHDDTOBindingSource.DataSource = typeof(DTO.ChitietHDDTO);
            // 
            // HoadonDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(946, 426);
            ControlBox = false;
            Controls.Add(Gridchitiet);
            Controls.Add(panel1);
            Name = "HoadonDetail";
            Text = "HoadonDetail";
            Load += HoadonDetail_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Gridchitiet).EndInit();
            ((System.ComponentModel.ISupportInitialize)chitietHDDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label lbDetail;
        private DataGridView Gridchitiet;
        private BindingSource chitietHDDTOBindingSource;
        private DataGridViewTextBoxColumn machitietDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn soluongDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tenmonDataGridViewTextBoxColumn;
    }
}
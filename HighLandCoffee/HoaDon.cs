using HighLandCoffee.DTO;
using HighLandCoffee.FormModel;
using HighLandCoffee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HighLandCoffee
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            loadHoadon();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home home = new Home();
            home.Show();
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {

        }

        private void GridHoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void loadHoadon()
        {
            using (HighlandDB dB = new HighlandDB())
            {

                var ls = dB.Hoadons.OrderBy(e => e.Mahd).Select(e => new HoadonDTO
                {
                    Mahd = e.Mahd,
                    Ngaymua = e.Ngaymua,
                    Makh = e.Makh,
                }).ToList();
                DataTable dataTable = new DataTable();

                // Thêm các cột vào DataTable
                dataTable.Columns.Add("Mahd", typeof(string));
                dataTable.Columns.Add("Ngaymua", typeof(DateTime));
                dataTable.Columns.Add("Makh", typeof(string));
                // Thêm dữ liệu từ danh sách vào DataTable
                foreach (HoadonDTO hoadon in ls)
                {
                    DataRow row = dataTable.NewRow();
                    row["Mahd"] = hoadon.Mahd;
                    row["Ngaymua"] = hoadon.Ngaymua;
                    row["Makh"] = hoadon.Makh;

                    dataTable.Rows.Add(row);
                }
                GridHoadon.DataSource = dataTable;
            }
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {

        }

        private void GridHoadon_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            if (GridHoadon.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = GridHoadon.SelectedRows[0];
                DataTable dataTable = (DataTable)GridHoadon.DataSource;
                int mahd = Convert.ToInt32(dataTable.Rows[row.Index]["Mahd"]);
                using HighlandDB db = new HighlandDB();
                var ls = db.Hoadons.Where(t => t.Mahd == mahd).FirstOrDefault();
                if (ls != null)
                {
                    db.Hoadons.Remove(ls);
                    db.SaveChanges();
                    loadHoadon();
                }

            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {

            if (GridHoadon.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = GridHoadon.SelectedRows[0];
                DataTable dataTable = (DataTable)GridHoadon.DataSource;
                int mahd = Convert.ToInt32(dataTable.Rows[row.Index]["Mahd"]);
                using HighlandDB db = new HighlandDB();
                var ls = db.Hoadons.Where(t => t.Mahd == mahd).FirstOrDefault();
                if (ls != null)
                {
                    HoadonDetail cthd = new HoadonDetail(mahd);

                    cthd.Show();

                }

            }
        }
    }
}

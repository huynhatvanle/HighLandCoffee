using HighLandCoffee.DTO;
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

namespace HighLandCoffee.FormModel
{
    public partial class HoadonDetail : Form
    {
        int mahd;
        public HoadonDetail()
        {
            InitializeComponent();
            loadHoadonDetail();
        }
        public HoadonDetail(int mahd)
        {
            InitializeComponent();
            this.mahd = mahd;
            loadHoadonDetail();

        }

        void loadHoadonDetail()
        {
            using (HighlandDB dB = new HighlandDB())
            {

                DataTable dataTable = new DataTable();
                // Thêm các cột vào DataTable
                dataTable.Columns.Add("Machitiet", typeof(int));
                dataTable.Columns.Add("Soluong", typeof(long));
                dataTable.Columns.Add("Gia", typeof(long));
                dataTable.Columns.Add("Tenmon", typeof(string));
                var ls = dB.ChitietHDs.Where(e => e.Mahd == mahd).Select(e => new ChitietHD
                {
                    Machitiet = e.Machitiet,
                    Soluongmua = e.Soluongmua,
                    Gia = e.Gia,
                    Mahd = e.Mahd,
                    Mamon = e.Mamon,

                }).ToList();
                // Thêm dữ liệu từ danh sách vào DataTable
                foreach (ChitietHD chitiet in ls)
                {
                    DataRow row = dataTable.NewRow();
                    row["Machitiet"] = chitiet.Machitiet;
                    row["Soluong"] = chitiet.Soluongmua;
                    row["Gia"] = chitiet.Gia;
                    var lsmonan = dB.Monans.OrderBy(e => e.Mamon == chitiet.Mamon).FirstOrDefault();
                    row["Tenmon"] = lsmonan.Tenmon;

                    dataTable.Rows.Add(row);
                }

                Gridchitiet.DataSource = dataTable;
                Gridchitiet.RowTemplate.Height = 50;

            }

        }
        private void HoadonDetail_Load(object sender, EventArgs e)
        {

        }
    }
}

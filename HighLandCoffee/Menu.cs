using HighLandCoffee.DTO;
using HighLandCoffee.FormModelDetail;
/*using HighLandCoffee.Migrations;*/
using HighLandCoffee.Models;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HighLandCoffee
{
    public partial class Menu : Form
    {
        MonanDTO monan;
        public Menu()
        {
            InitializeComponent();
            LoadLoai();
            new ThemmonDetail();

        }



        void LoadLoai()
        {
            using (HighlandDB db = new HighlandDB())
            {
                var ls = db.Loais.Select(e => new LoaiDTO
                {
                    Maloai = e.Maloai,
                    Tenloai = e.Tenloai,

                }).ToList();
                cbbLoai.DataSource = ls;
                cbbLoai.DisplayMember = "Tenloai";
                cbbLoai.ValueMember = "Maloai";

            }
        }
        public LoaiDTO selectedLoai
        {

            get
            {
                return cbbLoai.SelectedItem as LoaiDTO;

            }

        }
        private Image GetImageFromByteArray(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }
        void loadMonan()
        {

            using (HighlandDB dB = new HighlandDB())
            {

                var ls = dB.Monans.Where(t => t.Maloai == selectedLoai.Maloai).Select(t => new MonanDTO
                {
                    Mamon = t.Mamon,
                    Tenmon = t.Tenmon,
                    Gia = t.Gia,
                    Soluong = t.Soluong,
                    Anh = t.Anh,

                }).ToList();

                DataTable dataTable = new DataTable();

                // Thêm các cột vào DataTable
                dataTable.Columns.Add("Mamon", typeof(string));
                dataTable.Columns.Add("Tenmon", typeof(string));
                dataTable.Columns.Add("Gia", typeof(long));
                dataTable.Columns.Add("Soluong", typeof(long));
                dataTable.Columns.Add("Anh", typeof(Image));
                dataTable.Columns.Add("DuongdanAnh", typeof(string));

                // Thêm dữ liệu từ danh sách vào DataTable
                foreach (MonanDTO monan in ls)
                {
                    DataRow row = dataTable.NewRow();
                    row["Mamon"] = monan.Mamon;
                    row["Tenmon"] = monan.Tenmon;
                    row["Gia"] = monan.Gia;
                    row["Soluong"] = monan.Soluong;
                    byte[] imageBytes = File.ReadAllBytes(monan.Anh);
                    row["Anh"] = GetImageFromByteArray(imageBytes);
                    row["DuongdanAnh"] = monan.Anh;
                    dataTable.Rows.Add(row);
                }

                GridMonmenu.DataSource = dataTable;
                GridMonmenu.RowTemplate.Height = 50;

            }


        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }



        private void cbbLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            loadMonan();
        }

        private void GridMonmenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public MonanDTO SelectedMonan
        {
            get
            {
                return monanDTOBindingSource1.Current as MonanDTO;
            }
        }
        public LoaiDTO selectedType
        {

            get
            {
                return cbbLoai.SelectedItem as LoaiDTO;

            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home home = new Home();
            home.Show();
        }

        private void btnThemmenu_Click(object sender, EventArgs e)
        {
            var f = new ThemmonDetail();
            if (f.ShowDialog() == DialogResult.OK)
            {
                loadMonan();
            }
        }

        private void txttimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var keyword = txttimkiem.Text.ToLower();
                using (HighlandDB db = new HighlandDB())
                {
                    //tim kiem khong phan biet hoa thuong
                    var ls = db.Monans.Where(t => t.Tenmon.ToLower().Contains(keyword) || t.Maloai.ToLower().Contains(keyword))
                        .Select(t => new Monan
                        {
                            Mamon = t.Mamon,
                            Tenmon = t.Tenmon,
                            Anh = t.Anh,
                            Gia = t.Gia,
                            Soluong = t.Soluong,
                            Maloai = t.Maloai

                        }).ToList();
                    monanDTOBindingSource1.DataSource = null;
                    monanDTOBindingSource1.DataSource = ls;

                }
            }
        }


        private void btnSuamenu_Click(object sender, EventArgs e)
        {
            int mamon = 0;
            string tenmon = "";
            long gia = 0;
            long soluong = 0;
            string anh = "";
            string maloai = "";
            // Kiểm tra xem có dòng nào được chọn không
            if (GridMonmenu.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = GridMonmenu.SelectedRows[0];
                DataTable dataTable = (DataTable)GridMonmenu.DataSource;
                tenmon = dataTable.Rows[row.Index]["Tenmon"].ToString();

                // Lấy giá trị từ các ô trong dòng
                gia = Convert.ToInt64(dataTable.Rows[row.Index]["Gia"]);
                anh = dataTable.Rows[row.Index]["Duongdananh"].ToString();

            }

            MonanDTO monan = new MonanDTO()
            {
                Mamon = mamon,
                Tenmon = tenmon,
                Soluong = soluong,
                Gia = gia,
                Anh = anh,
                Maloai = cbbLoai.SelectedItem.ToString()
            };


            var f = new ThemmonDetail(monan);
            if (f.ShowDialog() == DialogResult.OK)
            {
                loadMonan();
            }
        }

        private void btnXoamenu_Click(object sender, EventArgs e)
        {
            if (GridMonmenu.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow row = GridMonmenu.SelectedRows[0];
                DataTable dataTable = (DataTable)GridMonmenu.DataSource;
                string tenmon = dataTable.Rows[row.Index]["Tenmon"].ToString();
                using HighlandDB db = new HighlandDB();
                var ls = db.Monans.Where(t => t.Tenmon == tenmon).FirstOrDefault();
                if (ls != null)
                {
                    db.Monans.Remove(ls);
                    db.SaveChanges();
                    loadMonan();
                }

            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

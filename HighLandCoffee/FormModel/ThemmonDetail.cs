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

namespace HighLandCoffee.FormModelDetail
{
    public partial class ThemmonDetail : Form
    {
        //MonanDTO monan;
        int mamon;
        int temp = 0;
        public ThemmonDetail()
        {
            InitializeComponent();
            LoadLoai();
        }
        public ThemmonDetail(MonanDTO monan)
        {

            InitializeComponent();
            LoadLoai();

            lbDetail.Text = " CẬP NHẬT THÔNG TIN";
            txttendetail.Text = monan.Tenmon;
            cbbloai.SelectedValue = monan.Maloai;
            txtgiadetail.Text = monan.Gia.ToString();
            // Lấy đường dẫn đến tập tin ảnh
            Image image = Image.FromFile(monan.Anh);

            // Gán hình ảnh cho PictureBox
            ptbAnhmon.Image = image;

            using (HighlandDB db = new HighlandDB())
            {
                var ls = db.Monans.Where(t => t.Tenmon == txttendetail.Text).FirstOrDefault();

                mamon = ls.Mamon;
            }
            temp = 1;
        }
        private Image GetImageFromByteArray(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
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
                cbbloai.DataSource = ls;
                cbbloai.DisplayMember = "Tenloai";
                cbbloai.ValueMember = "Maloai";

            }
        }
        private void ThemmonDetail_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loai = cbbloai.SelectedItem as LoaiDTO;

            if (temp != 0)
            {
                using (HighlandDB db = new HighlandDB())
                {
                    var ls = db.Monans.Where(t => t.Mamon == mamon).FirstOrDefault();
                    ls.Tenmon = txttendetail.Text;
                    ls.Gia = Int32.Parse(txtgiadetail.Text);
                    ls.Maloai = loai.Maloai;
                    ls.Anh = ptbAnhmon.ImageLocation;
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                //vả newhoadon = new Hoadon

                //thêm mới
                var newmonan = new Monan
                {
                    Tenmon = txttendetail.Text,
                    Soluong = 10,
                    Gia = Int32.Parse(txtgiadetail.Text),
                    Maloai = loai.Maloai,
                    Anh = ptbAnhmon.ImageLocation
                };
                using (HighlandDB db = new HighlandDB())
                {
                    db.Monans.Add(newmonan);
                    db.SaveChanges();
                    DialogResult = DialogResult.OK;
                }
            }




        }

        private void ptbAnhmon_Click(object sender, EventArgs e)
        {
            var opendialog = new OpenFileDialog
            {
                Title = " chon anh mon an",
                Filter = "File anh | *.png;*.jpg;*jpeg"
            };
            if (opendialog.ShowDialog() == DialogResult.OK)
            {
                var fileanh = opendialog.FileName;
                ptbAnhmon.ImageLocation = fileanh;
            }
        }
    }
}

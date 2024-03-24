using HighLandCoffee.Component;
using HighLandCoffee.DTO;
using HighLandCoffee.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Formats.Tar;
using Font = iTextSharp.text.Font;

namespace HighLandCoffee.FormModel
{
    public partial class FrmThanhtoan : Form
    {
        string txtTenKH;
        TextBox txtTongtien;
        public FlowLayoutPanel billPanel;
        public FrmThanhtoan()
        {
            InitializeComponent();
        }
        public FrmThanhtoan(string txtTenKH, FlowLayoutPanel billPanel, TextBox txtTongtien)
        {
            InitializeComponent();
            this.txtTenKH = txtTenKH;
            this.billPanel = billPanel;
            this.txtTongtien = txtTongtien;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmThanhtoan_Load_1(object sender, EventArgs e)
        {
            if (txtTenKH == "")
            {
                txttenkhachhang.Text = "Khách vãng lai";

            }
            else
            {
                txttenkhachhang.Text = txtTenKH;
            }

            txtsotienthanhtoan.Text = txtTongtien.Text;
        }
        public void InHoaDon(string tenKhachHang, TextBox txtTongtien, FlowLayoutPanel billPanel)
        {
            // Tạo tài liệu PDF
            Document document = new Document();
            string duongDanFile = @"D:\Thi .net\HoaDon.pdf";
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(duongDanFile, FileMode.Create));
            document.Open();

            // Tạo font cho tiêu đề và nội dung
            Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            Font contentFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);

            // Thêm tiêu đề hóa đơns
            Paragraph title = new Paragraph("HOA DON", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // Thêm thông tin khách hàng
            document.Add(new Paragraph("TEN KHACH HANG: " + tenKhachHang, contentFont));


            // Thêm dòng ngăn cách
            document.Add(new Paragraph("----------------------------------------------"));

            // Tạo bảng với 4 cột
            PdfPTable table = new PdfPTable(4);

            // Đặt độ rộng cố định cho các cột
            float[] columnWidths = { 2f, 6f, 3f, 4f };
            table.SetWidths(columnWidths);

            // Đặt tiêu đề danh sách món ăn
            string[] headers = { "STT", "Ten mon", "So luong", "Don gia" };
            foreach (string header in headers)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(header, contentFont));
                table.AddCell(headerCell);
            }



            // Thêm danh sách món ăn (ví dụ)
            int stt = 1;
            foreach (Control control in billPanel.Controls)
            {
                if (control is FrmTenMonDetail frmTenMonDetail)
                {
                    // Thêm dữ liệu vào từng cột
                    table.AddCell(stt.ToString());
                    table.AddCell(frmTenMonDetail.monan.Tenmon.ToString());
                    table.AddCell("1");
                    table.AddCell(frmTenMonDetail.monan.Gia.ToString());

                    stt++;
                }
            }
            table.HorizontalAlignment = Element.ALIGN_LEFT;
            // Thêm bảng vào tài liệu
            document.Add(table);


            // Thêm dòng ngăn cách
            document.Add(new Paragraph("----------------------------------------------"));

            // Thêm tổng tiền
            document.Add(new Paragraph("Tong tien: " + txtTongtien.Text + " đ", contentFont));

            // Thêm dòng ngăn cách
            document.Add(new Paragraph("----------------------------------------------"));

            // Thêm lời cảm ơn
            document.Add(new Paragraph("Cam on vi da den!", contentFont));

            // Đóng tài liệu
            document.Close();
        }
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {

            int makh;
            using HighlandDB db = new HighlandDB();
            var ls = db.Khachhangs.Where(t => t.Tenkh == txttenkhachhang.Text).ToList().FirstOrDefault();
            if (ls != null)
            {
                makh = ls.Makh;

            }
            else
            {
                makh = 0;
            }

            var newhoadon = new Hoadon
            {
                Ngaymua = DateTime.Now,
                Makh = makh

            };
            db.Hoadons.Add(newhoadon);
            db.SaveChanges();

            foreach (Control control in billPanel.Controls)
            {
                if (control is FrmTenMonDetail frmTenMonDetail)
                {
                    var chitietHD = new ChitietHD()
                    {
                        Soluongmua = 1,
                        Gia = frmTenMonDetail.monan.Gia,
                        Mahd = newhoadon.Mahd,
                        Mamon = frmTenMonDetail.monan.Mamon


                    };
                    db.ChitietHDs.Add(chitietHD);
                    db.SaveChanges();

                }
            }
            InHoaDon(txtTenKH, txtTongtien, billPanel);
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            DatMon datmon = new DatMon();
            datmon.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

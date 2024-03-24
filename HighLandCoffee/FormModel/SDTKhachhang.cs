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
    public partial class SDTKhachhang : Form
    {
        string txtTenKH = "";
        TextBox txtTongtien;
        public FlowLayoutPanel billPanel;
        public SDTKhachhang()
        {
            InitializeComponent();
        }
        public SDTKhachhang(FlowLayoutPanel billPanel, TextBox txtTongtien)
        {
            InitializeComponent();
            this.billPanel = billPanel;
            this.txtTongtien = txtTongtien;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SDTKhachhang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using HighlandDB db = new HighlandDB();
            var ls = db.Khachhangs.Where(t => t.SoDT == txtSdt.Text).ToList().FirstOrDefault();
            if (ls != null)
            {
                string tenKH = ls.Tenkh;
                FrmThanhtoan thanhtoan = new FrmThanhtoan(tenKH, billPanel, txtTongtien);
                thanhtoan.Show();
                this.Hide();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

            FrmThanhtoan thanhtoan = new FrmThanhtoan(txtTenKH, billPanel, txtTongtien);
            thanhtoan.Show();
            this.Hide();
        }
    }
}

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

namespace HighLandCoffee.Component
{
    public partial class FrmTenMon : UserControl
    {
        MonanDTO FB;
        TextBox txtTongtien;
        public FlowLayoutPanel billPanel;

        public FrmTenMon()
        {
            InitializeComponent();
        }
        public FrmTenMon(MonanDTO FB, FlowLayoutPanel billPanel, TextBox txtTongtien)
        {
            InitializeComponent();
            this.FB = FB;
            this.billPanel = billPanel;
            this.txtTongtien = txtTongtien;
        }

        private void FrmTenMon_Load(object sender, EventArgs e)
        {
            if (this.FB != null)
            {
                string name = FB.Tenmon;

                lbtenmon.Text = name;
                byte[] imageBytes = File.ReadAllBytes(FB.Anh);
                Image image = GetImageFromByteArray(imageBytes);
                ptbTenmon.Image = image;
            }
        }
        private Image GetImageFromByteArray(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmTenMon_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void FrmTenMon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

        }

        private void ptbTenmon_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có thêm món này vào hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    FrmTenMonDetail frmTenmonDetail = new FrmTenMonDetail(this.FB, billPanel, txtTongtien);
                    if(frmTenmonDetail != null)
                    {
                        billPanel.Controls.Add(frmTenmonDetail);

                        long price = Int64.Parse(txtTongtien.Text) + FB.Gia;
                        txtTongtien.Text = price.ToString();
                    }
                    break;

                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
    }
}

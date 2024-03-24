using HighLandCoffee.DTO;
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
    public partial class FrmTenMonDetail : UserControl
    {
        public MonanDTO monan;
        public TextBox txtTongtien;
        public FlowLayoutPanel billPanel;
        public FrmTenMonDetail()
        {
            InitializeComponent();
        }
        public FrmTenMonDetail(MonanDTO monan, FlowLayoutPanel billPanel, TextBox txtTongtien)
        {
            InitializeComponent();
            this.monan = monan;
            this.billPanel = billPanel;
            this.txtTongtien = txtTongtien;

        }
        private Image GetImageFromByteArray(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                return Image.FromStream(memoryStream);
            }
        }
        private void FrmTenMonDetail_Load(object sender, EventArgs e)
        {

            txttenmonDetail.Text = monan.Tenmon;
            txtgiaDetail.Text = monan.Gia.ToString();
            byte[] imageBytes = File.ReadAllBytes(monan.Anh);
            Image image = GetImageFromByteArray(imageBytes);
            ptbMon.Image = image;
        }

        private void lbhuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món này ra khỏi hóa đơn không?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (result)
            {
                case DialogResult.Yes:
                    foreach (FrmTenMonDetail control in billPanel.Controls.OfType<FrmTenMonDetail>())
                    {
                        if (control.monan != null && control.monan.Mamon.Equals(this.monan.Mamon))
                        {
                            long updatedPrice = Int32.Parse(txtTongtien.Text) - control.monan.Gia;
                            txtTongtien.Text = updatedPrice.ToString();
                            billPanel.Controls.Remove(control);
                            control.Dispose();
                        }
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

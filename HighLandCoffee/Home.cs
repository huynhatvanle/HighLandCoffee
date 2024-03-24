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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HighLandCoffee
{
    public partial class Home : Form
    {
        private HighlandDB db;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DatMon datmon = new DatMon();
            this.Hide();
            datmon.Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();

        }

        private void ptbMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
            /* menu.FormClosed += (s, rs) =>
             {
                 this.Show();
             };*/


        }

        private void ptbHD_Click(object sender, EventArgs e)
        {
            HoaDon hoadon = new HoaDon();
            this.Hide();
            hoadon.Show();
        }

    }  
}

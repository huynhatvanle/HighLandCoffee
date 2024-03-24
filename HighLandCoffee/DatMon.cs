using HighLandCoffee.Component;
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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace HighLandCoffee
{
    public partial class DatMon : Form
    {
        public Panel bill_Panel;
        public MonanDTO monan;
        public DatMon()
        {
            InitializeComponent();

        }

        public DatMon(Panel bill_Panel)
        {
            InitializeComponent();
            txtTongtien.Text = "0";
            this.bill_Panel = bill_Panel;
        }

        public List<MonanDTO> getDrink()
        {
            List<MonanDTO> monans = new List<MonanDTO>();

            using (var db = new HighlandDB())
            {

                var ls = db.Monans.Where(t => t.Maloai == "Drink").Select(t => new MonanDTO
                {
                    Mamon = t.Mamon,
                    Tenmon = t.Tenmon,
                    Gia = t.Gia,
                    Soluong = t.Soluong,
                    Anh = t.Anh,

                }).ToList();
                return ls;

            }
        }
        public List<MonanDTO> getFood()
        {
            List<MonanDTO> monans = new List<MonanDTO>();

            using (var db = new HighlandDB())
            {

                var ls = db.Monans.Where(t => t.Maloai == "Food").Select(t => new MonanDTO
                {
                    Mamon = t.Mamon,
                    Tenmon = t.Tenmon,
                    Gia = t.Gia,
                    Soluong = t.Soluong,
                    Anh = t.Anh,

                }).ToList();
                return ls;
            }
        }
        public List<MonanDTO> getCoffee()
        {
            List<MonanDTO> monans = new List<MonanDTO>();

            using (var db = new HighlandDB())
            {

                var ls = db.Monans.Where(t => t.Maloai == "Coffee").Select(t => new MonanDTO
                {
                    Mamon = t.Mamon,
                    Tenmon = t.Tenmon,
                    Gia = t.Gia,
                    Soluong = t.Soluong,
                    Anh = t.Anh,

                }).ToList();

                return ls;

            }
        }
        public void loadBills()
        {

            billFlowPanel.Controls.Clear();
            if (bill_Panel != null)
            {
                foreach (Control control in bill_Panel.Controls)
                {
                    billFlowPanel.Controls.Add(control);
                }
            }
        }
        public List<MonanDTO> getAll()
        {
            List<MonanDTO> monans = new List<MonanDTO>();

            using (var db = new HighlandDB())
            {

                var ls = db.Monans.Select(t => new MonanDTO
                {
                    Mamon = t.Mamon,
                    Tenmon = t.Tenmon,
                    Gia = t.Gia,
                    Soluong = t.Soluong,
                    Anh = t.Anh,

                }).ToList();

                return ls;

            }
        }
        private void loadAll()
        {
            // Get all coffees from db
            List<MonanDTO> FBS = getAll();
            /*flp_type.Controls.Clear();*/


            foreach (MonanDTO FB in FBS)
            {
                FrmTenMon widget = new FrmTenMon(FB, billFlowPanel, txtTongtien);
                flowmenu.Controls.Add(widget);
            }
        }
        private void loadCoffee()
        {
            // Get all coffees from db
            List<MonanDTO> coffees = getCoffee();
            /*flp_type.Controls.Clear();*/


            foreach (MonanDTO coffee in coffees)
            {
                FrmTenMon widget = new FrmTenMon(coffee, billFlowPanel, txtTongtien);
                flowmenu.Controls.Add(widget);
            }
        }
        private void loadDrink()
        {
            // Get all coffees from db
            List<MonanDTO> drinks = getDrink();
            /*flp_type.Controls.Clear();*/


            foreach (MonanDTO drink in drinks)
            {
                FrmTenMon widget = new FrmTenMon(drink, billFlowPanel, txtTongtien);
                flowmenu.Controls.Add(widget);
            }
        }
        private void loadFood()
        {
            // Get all coffees from db
            List<MonanDTO> foods = getFood();
            /*flp_type.Controls.Clear();*/


            foreach (MonanDTO food in foods)
            {
                FrmTenMon widget = new FrmTenMon(food, billFlowPanel, txtTongtien);
                flowmenu.Controls.Add(widget);
            }
        }
        private void DatMon_Load(object sender, EventArgs e)
        {
            flowmenu.Controls.Clear();
            loadAll();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbTongtien_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            Home home = new Home();
            home.Show();
        }
        //NÚT THANH TOÁN 
        private void button1_Click(object sender, EventArgs e)
        {
            SDTKhachhang sdt = new SDTKhachhang(billFlowPanel, txtTongtien);
            this.Hide();
            sdt.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncaphe_Click(object sender, EventArgs e)
        {
            flowmenu.Controls.Clear();
            loadCoffee();
        }

        private void btnthucuong_Click(object sender, EventArgs e)
        {
            flowmenu.Controls.Clear();
            loadDrink();
        }

        private void btndoan_Click(object sender, EventArgs e)
        {
            flowmenu.Controls.Clear();
            loadFood();
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            flowmenu.Controls.Clear();
            loadAll();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}

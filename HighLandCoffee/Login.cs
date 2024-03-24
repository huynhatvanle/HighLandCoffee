using HighLandCoffee.Models;

namespace HighLandCoffee
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnDn_Click(object sender, EventArgs e)
        {
            string TenDN = txttendn.Text;
            string pass = txtpass.Text;
            using (var db = new HighlandDB())
            {
                Dangnhap obj = db.Dangnhaps.Where(e => (e.Tendn == TenDN && e.Pass == pass)).FirstOrDefault();
                if (obj != null)
                {
                    Home home = new Home();
                    this.Hide();
                    home.Show();

                }
                else
                {
                    MessageBox.Show(
                        "Đăng nhập sai.", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}

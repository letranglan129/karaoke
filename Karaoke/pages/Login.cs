using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Karaoke.DB;
using Karaoke.App;

namespace Karaoke.pages
{
    public partial class Login : Form
    {
        private AppDB db = new AppDB();
        public Login()
        {
            InitializeComponent();
            Shown += Login_Shown;
            Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var loginQuery = db.Users.Where(x => x.Username == txtUsername.Text && x.Password == txtPassword.Text);

            if (loginQuery.Count() > 0)
            {
                this.Hide();
                User loginUser = loginQuery.First();
                UserStorage.LoginUser = loginUser;
                Main mainDialog = new Main();
                mainDialog.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại!!!");
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}

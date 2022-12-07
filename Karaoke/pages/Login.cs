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
using BC = BCrypt.Net.BCrypt;

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
            var loginUser = db.Users.First(x => x.Username == txtUsername.Text);

            if (loginUser == null || !BC.Verify(txtPassword.Text, loginUser.Password))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác. Vui lòng kiểm tra lại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
                UserStorage.LoginUser = loginUser;
                Main mainDialog = new Main();
                mainDialog.ShowDialog();
                this.Close();
            }
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }
    }
}

using Karaoke.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke.Constanst;
using Karaoke.App;

namespace Karaoke.Components
{
    public partial class UserInfo : Form
    {

        private AppDB db = new AppDB();

        public UserInfo()
        {
            InitializeComponent();

            this.nameValue.Text = UserStorage.LoginUser.Fullname;
            this.userNameValue.Text = UserStorage.LoginUser.Username;
            this.userTypeValue.Text = UserStorage.LoginUser.UserType;
            this.phoneNumberValue.Text = UserStorage.LoginUser.PhoneNumber;
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordFrm changePasswordFrm = new ChangePasswordFrm();
            changePasswordFrm.ShowDialog();
        }

        private void changeLogout_Click(object sender, EventArgs e)
        {
            UserStorage.LoginUser = null;
            MessageBox.Show("Đăng xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Restart();
        }
    }
}

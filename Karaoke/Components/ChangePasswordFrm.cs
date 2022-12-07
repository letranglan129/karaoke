using Karaoke.App;
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
using BC = BCrypt.Net.BCrypt;

namespace Karaoke.Components
{
    public partial class ChangePasswordFrm : Form
    {
        private AppDB db = new AppDB();
        public ChangePasswordFrm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(passwordTextBox.Text.Length >=6 || newPasswordTextBox.Text.Length >= 6 || reNewPasswordTextBox.Text.Length >= 6)
            {
                if (!BC.Verify(passwordTextBox.Text, UserStorage.LoginUser.Password))
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác. Vui lòng kiểm tra lại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (newPasswordTextBox.Text != reNewPasswordTextBox.Text)
                {
                    MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu mới không trùng khớp. Vui lòng kiểm tra lại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User user = db.Users.First(x => x.Username == UserStorage.LoginUser.Username);
                user.Password = BC.HashPassword(newPasswordTextBox.Text);
                db.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } 
            else
            {
                MessageBox.Show("Mật khẩu tối thiểu 6 kí tự. Vui lòng kiểm tra lại!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}

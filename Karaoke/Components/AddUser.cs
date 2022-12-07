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
    public partial class AddUser : Form
    {
        private AppDB db = new AppDB();
        List<string> listErr;
        string type;
        User user;
        public AddUser(string type, User user)
        {
            InitializeComponent();
            this.type = type;
            this.user = user;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            fullnameTextBox.Text = user.Fullname!= null ? user.Fullname : "";
            usernameTextBox.Text = user.Username != null ? user.Username : "";
            phoneNumberTextBox.Value = user.PhoneNumber != null ? decimal.Parse(user.PhoneNumber) : 0;

            if(type == "EDIT")
            {
            this.usernameTextBox.Enabled = false;
            int index = userTypeTextBox.Items.IndexOf(user.UserType);
                userTypeTextBox.SelectedIndex = index;
            }
        }

        private bool validateForm()
        {
            listErr = new List<string>();

            validateTextBox(fullnameTextBox.Text, "Tên nhân viên");
            validateTextBox(usernameTextBox.Text, "Tên đăng nhập");
            validateTextBox(passwordTextBox.Text, "Mật khẩu");
            validateTextBox(phoneNumberTextBox.Value.ToString(), "Số điện thoại");
            validateTextBox(userTypeTextBox.Text, "Quyền");

            if(passwordTextBox.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải lớn hơn 6 kí tự!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (listErr.Count == 0)
                return false;
            return true;
        }

        private void validateTextBox(string valueCheck, string name)
        {
            if(valueCheck == "")
            {
                listErr.Add(name);
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            bool isError = validateForm();
            if(isError == false)
            {
                try
                {
                    switch (type)
                    {
                        case "ADD":
                            {
                                addUserHandle();
                                break;
                            }
                        case "EDIT":
                            {
                                editUserHandle();
                                break;
                            }
                        default:
                            break;
                    }
                    this.Close();
                }
                catch (Exception)
                { 
                    MessageBox.Show("Thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                
            }
            else
            {
                string result = String.Join(", ", listErr.ToArray()) + " không được để trống!!!";
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addUserHandle()
        {
            bool isExist = db.Users.Any(x => x.Username == usernameTextBox.Text);

            if (isExist == true)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            User user = new User();
            user.Fullname = fullnameTextBox.Text;
            user.Username = usernameTextBox.Text;
            user.Password = BC.HashPassword(passwordTextBox.Text);
            user.PhoneNumber = "0" + phoneNumberTextBox.Value.ToString();
            user.UserType = userTypeTextBox.Text;
            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editUserHandle()
        {
            User editUser = db.Users.First(x => x.PersonId == user.PersonId);

            editUser.Fullname = fullnameTextBox.Text;
            editUser.Username = usernameTextBox.Text;
            editUser.Password = BC.HashPassword(passwordTextBox.Text);
            editUser.PhoneNumber = "0" + phoneNumberTextBox.Value.ToString();
            editUser.UserType = userTypeTextBox.Text;
            db.SaveChanges();
            MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

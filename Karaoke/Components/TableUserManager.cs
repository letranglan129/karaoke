using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke.DB;
using Karaoke.App;
using System.Data.Entity;

namespace Karaoke.Components
{
    public partial class TableUserManager : Form
    {
        private AppDB db = new AppDB();
        
        private int lastIndex = -1;
        private Sort sort;
        private AddUser addUser;

        public TableUserManager()
        {
            InitializeComponent();
            list.AutoGenerateColumns = false;
            list.DataSource = getUsers();
            sort = new Sort(list.Columns[1].DataPropertyName, "ASC");
        }

        private void listRoom_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nameColumn = list.Columns[e.ColumnIndex].DataPropertyName;
            sort.Type = "DESC";
            string select = "SELECT * FROM [USER] ORDER BY " + nameColumn + " " + sort.Type;

            if (lastIndex != -1)
                list.Columns[lastIndex].HeaderText = list.Columns[lastIndex].HeaderText.Remove(list.Columns[lastIndex].HeaderText.Length - 1, 1);

            lastIndex = e.ColumnIndex;

            list.Columns[e.ColumnIndex].HeaderText += sort.Type == "ASC" ? "↑" : "↓";
            list.DataSource = db.Users.SqlQuery(select).Select(x => new { x.PersonId, x.Username, x.Fullname, x.PhoneNumber, x.UserType }).ToList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = list.SelectedRows[0].Cells;
            int personId = int.Parse(cells["PersonId"].Value.ToString());
            User user = db.Users.First(x => x.PersonId == personId);
            addUser = new AddUser("EDIT", user);
            addUser.FormClosed += editForm_FormClose;
            addUser.ShowDialog();
        }

        private void editForm_FormClose(object sender, FormClosedEventArgs e)
        {
            db = new AppDB();
            list.DataSource = getUsers();
            this.statusDropdown.SelectedIndex = 0;
            addUser.FormClosed -= editForm_FormClose;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult resultMessage = MessageBox.Show("Chắc chắn xóa nhân viên này???", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == resultMessage)
            {
                List<long> ids = new List<long>();

                for (int i = 0; i < list.SelectedRows.Count; i++)
                {
                    ids.Add(long.Parse(list.SelectedRows[i].Cells["PersonId"].Value.ToString()));
                }

                db.Users.RemoveRange(db.Users.Where(x => ids.Contains(x.PersonId)));
                db.SaveChanges();

                list.DataSource = getUsers();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            addUser = new AddUser("ADD", user);
            addUser.FormClosed += editForm_FormClose;
            addUser.ShowDialog();
        }

        private void statusDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.statusDropdown.Text == "Tất cả")
            {
                list.DataSource = getUsers();
            }
            else
            {
                list.DataSource = db.Users.Where(y => y.UserType == this.statusDropdown.Text).Select(x => new { x.PersonId, x.Username, x.Fullname, x.PhoneNumber, x.UserType }).ToList();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (this.searchBox.Text.Trim() != "")
            {
                list.DataSource = db.Users.Where(x => x.Fullname.ToLower().Contains(this.searchBox.Text.ToLower()) || x.Username.ToLower().Contains(this.searchBox.Text.ToLower())).Select(x => new { x.PersonId, x.Username, x.Fullname, x.PhoneNumber, x.UserType }).ToList();
            }
            else
            {
                list.DataSource = getUsers();
            }
        }

        public BindingSource getUsers()
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = db.Users.OrderBy(x => x.PersonId).Select(x => new { x.PersonId, x.Username, x.Fullname, x.PhoneNumber, x.UserType}).ToList();
            return bds;
        }
    }
}

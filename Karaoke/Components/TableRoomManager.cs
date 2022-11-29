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
    public partial class TableRoomManager : Form
    {
        private AppDB db = new AppDB();
        
        private int lastIndex = -1;
        private Sort sort;
        private Edit edit;

        public TableRoomManager()
        {
            InitializeComponent();
            listRoom.AutoGenerateColumns = false;
            listRoom.DataSource = getRooms();
            sort = new Sort(listRoom.Columns[1].DataPropertyName, "ASC");
        }

        private void listRoom_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nameColumn = listRoom.Columns[e.ColumnIndex].DataPropertyName;
            sort.Type = "DESC";
            string select = "SELECT * FROM ROOM ORDER BY " + nameColumn + " " + sort.Type;

            if (lastIndex != -1)
                listRoom.Columns[lastIndex].HeaderText = listRoom.Columns[lastIndex].HeaderText.Remove(listRoom.Columns[lastIndex].HeaderText.Length - 1, 1);

            lastIndex = e.ColumnIndex;

            listRoom.Columns[e.ColumnIndex].HeaderText += sort.Type == "ASC" ? "↑" : "↓";
            listRoom.DataSource = db.Rooms.SqlQuery(select).Select(x => new { x.Code, x.Name, x.Status, x.Price }).ToList();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = listRoom.SelectedRows[0].Cells;
            edit = new Edit("EDIT_ROOM", cells["Code"].Value.ToString(), cells["NameRoom"].Value.ToString(), Convert.ToInt32(cells["Price"].Value), cells["Status"].Value.ToString());
            edit.FormClosed += editForm_FormClose;
            edit.ShowDialog();
        }

        private void editForm_FormClose(object sender, FormClosedEventArgs e)
        {
            listRoom.DataSource = getRooms();
            this.statusDropdown.SelectedIndex = 0;
            edit.FormClosed -= editForm_FormClose;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult resultMessage = MessageBox.Show("Chắc chắn xóa phòng này???", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == resultMessage)
            {
                List<long> ids = new List<long>();

                for (int i = 0; i < listRoom.SelectedRows.Count; i++)
                {
                    ids.Add(long.Parse(listRoom.SelectedRows[i].Cells["Code"].Value.ToString()));
                }

                db.Rooms.RemoveRange(db.Rooms.Where(x => ids.Contains(x.Code)));
                db.SaveChanges();

                listRoom.DataSource = getRooms();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            edit = new Edit("ADD_ROOM");
            edit.FormClosed += editForm_FormClose;
            edit.ShowDialog();
        }

        private void statusDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.statusDropdown.Text == "Tất cả")
            {
                listRoom.DataSource = getRooms();
            }
            else
            {
                listRoom.DataSource = db.Rooms.Where(y => y.Status == this.statusDropdown.Text).Select(x => new { x.Code, x.Name, x.Status, x.Price }).ToList();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (this.searchBox.Text.Trim() != "")
            {
                listRoom.DataSource = db.Rooms.Where(x => x.Name.ToLower().Contains(this.searchBox.Text.ToLower())).Select(x => new { x.Code, x.Name, x.Status, x.Price }).ToList();
            }
            else
            {
                listRoom.DataSource = getRooms();
            }
        }

        public BindingSource getRooms()
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = db.Rooms.OrderBy(x => x.Code).Select(x => new { x.Code, x.Name, x.Status, x.Price }).ToList();
            return bds;
        }

    }
}

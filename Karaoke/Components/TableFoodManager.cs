using Karaoke.App;
using Karaoke.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.Components
{
    public partial class TableFoodManager : Form
    {

        private AppDB db = new AppDB();
        private int lastIndex = -1;
        private Sort sort;
        private Edit edit;
        public TableFoodManager()
        {
            InitializeComponent();

            list.AutoGenerateColumns = false;
            list.DataSource = getFoods();
            sort = new Sort(list.Columns[1].DataPropertyName, "ASC");
        }

        private void listRoom_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string nameColumn = list.Columns[e.ColumnIndex].DataPropertyName;
            sort.Type = "DESC";
            string select = "SELECT * FROM FOOD ORDER BY " + nameColumn + " " + sort.Type;

            if (lastIndex != -1)
                list.Columns[lastIndex].HeaderText = list.Columns[lastIndex].HeaderText.Remove(list.Columns[lastIndex].HeaderText.Length - 1, 1);

            lastIndex = e.ColumnIndex;

            list.Columns[e.ColumnIndex].HeaderText += sort.Type == "ASC" ? "↑" : "↓";
            list.DataSource = db.Foods.SqlQuery(select).Select(x => new { x.Id, x.Name, x.Type, x.Price }).ToList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult resultMessage = MessageBox.Show("Chắc chắn xóa phòng này???", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == resultMessage)
            {
                List<long> ids = new List<long>();

                for (int i = 0; i < list.SelectedRows.Count; i++)
                {
                    ids.Add(long.Parse(list.SelectedRows[i].Cells["Id"].Value.ToString()));
                }

                db.Foods.RemoveRange(db.Foods.Where(x => ids.Contains(x.Id)));
                db.SaveChanges();

                list.DataSource = getFoods();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = list.SelectedRows[0].Cells;
            edit = new Edit("EDIT_FOOD", cells["Id"].Value.ToString(), cells["NameFood"].Value.ToString(), Convert.ToInt32(cells["Price"].Value), cells["Type"].Value.ToString());
            edit.FormClosed += editForm_FormClose;
            edit.ShowDialog();
        }

        private void editForm_FormClose(object sender, FormClosedEventArgs e)
        {
            list.DataSource = getFoods();
            this.statusDropdown.SelectedIndex = 0;
            edit.FormClosed -= editForm_FormClose;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            edit = new Edit("ADD_FOOD");
            edit.FormClosed += editForm_FormClose;
            edit.ShowDialog();
        }

        private void statusDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.statusDropdown.Text == "Tất cả")
            {
                list.DataSource = getFoods();
            }
            else
            {
                list.DataSource = db.Foods.Where(y => y.Type == this.statusDropdown.Text).Select(x => new { x.Id, x.Name, x.Type, x.Price }).ToList();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (this.searchBox.Text.Trim() != "")
            {
                list.DataSource = db.Foods.Where(x => x.Name.ToLower().Contains(this.searchBox.Text.ToLower())).Select(x => new { x.Id, x.Name, x.Type, x.Price }).ToList();
            }
            else
            {
                list.DataSource = getFoods();
            }
        }

        public BindingSource getFoods()
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = db.Foods.OrderBy(x => x.Id).Select(x => new { x.Id, x.Name, x.Type, x.Price }).ToList();
            return bds;
        }
    }
}

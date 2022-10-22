using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke.App;
using Karaoke.DB;

namespace Karaoke.Components
{
    public partial class TableOrderManager : Form
    {
        private AppDB db = new AppDB();
        private int lastIndex = -1;
        private Sort sort;
        private Edit edit;
        private string searchType;
        private string filterType;
        public TableOrderManager()
        {
            InitializeComponent();
            list.AutoGenerateColumns = false;
            list.DataSource = getOrders();
            sort = new Sort(list.Columns[1].DataPropertyName, "ASC");
            searchType = this.seachTypeBox.Text;
            filterType = this.statusDropdown.Text;
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

                db.Orders.RemoveRange(db.Orders.Where(x => ids.Contains(x.Id)));
                db.SaveChanges();

                list.DataSource = getOrders();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection cells = list.SelectedRows[0].Cells;
            edit = new Edit("EDIT_ORDER", cells["Id"].Value.ToString(), cells["NameFood"].Value.ToString(), Convert.ToInt32(cells["Price"].Value), cells["Type"].Value.ToString());
            edit.FormClosed += editForm_FormClose;
            edit.Show();
        }

        private void editForm_FormClose(object sender, FormClosedEventArgs e)
        {
            list.DataSource = db.Foods.Select(x => new { x.Id, x.Name, x.Type, x.Price }).ToList();
            edit.FormClosed -= editForm_FormClose;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            edit = new Edit("ADD_ORDER");
            edit.FormClosed += editForm_FormClose;
            edit.Show();
        }

        private void statusDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.statusDropdown.Text == "Tất cả")
            {
                list.DataSource = getOrders();
            }
            else
            {
                list.DataSource = db.Orders.Join
                            (
                            db.Rooms,
                            order => order.RoomCode,
                            room => room.Code,
                            (order, room) => new
                            {
                                order.Id,
                                order.StartDateTime,
                                order.EndDateTime,
                                order.PhoneNumber,
                                order.Status,
                                order.RoomPrice,
                                order.PersonID,
                                order.CustomerName,
                                room.Name
                            }
                            )
                            .Join
                            (
                            db.Users,
                            order => order.PersonID,
                            user => user.PersonId,
                            (order, user) => new
                            {
                                order.Id,
                                order.StartDateTime,
                                order.EndDateTime,
                                order.PhoneNumber,
                                order.Status,
                                order.RoomPrice,
                                user.Fullname,
                                order.CustomerName,
                                order.Name
                            }
                            ).Where(order => order.Status.Contains(statusDropdown.Text)).ToList();
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (this.searchBox.Text.Trim() != "")
            {
                switch (this.searchType)
                {
                    case "Tên":
                        {
                            list.DataSource = db.Orders.Join
                            (
                            db.Rooms,
                            order => order.RoomCode,
                            room => room.Code,
                            (order, room) => new
                            {
                                order.Id,
                                order.StartDateTime,
                                order.EndDateTime,
                                order.PhoneNumber,
                                order.Status,
                                order.RoomPrice,
                                order.PersonID,
                                order.CustomerName,
                                room.Name
                            }
                            )
                            .Join
                            (
                            db.Users,
                            order => order.PersonID,
                            user => user.PersonId,
                            (order, user) => new
                            {
                                order.Id,
                                order.StartDateTime,
                                order.EndDateTime,
                                order.PhoneNumber,
                                order.Status,
                                order.RoomPrice,
                                user.Fullname,
                                order.CustomerName,
                                order.Name
                            }
                            )
                            .Where(x => x.CustomerName.ToLower().Contains(this.searchBox.Text.ToLower())).ToList();
                            break;
                        }
                    case "Phòng":
                        {
                            list.DataSource = db.Orders.Join
                            (
                            db.Rooms,
                            order => order.RoomCode,
                            room => room.Code,
                            (order, room) => new
                            {
                                order.Id,
                                order.StartDateTime,
                                order.EndDateTime,
                                order.PhoneNumber,
                                order.Status,
                                order.RoomPrice,
                                order.PersonID,
                                order.CustomerName,
                                room.Name
                            }
                            )
                            .Join
                            (
                            db.Users,
                            order => order.PersonID,
                            user => user.PersonId,
                            (order, user) => new
                            {
                                order.Id,
                                order.StartDateTime,
                                order.EndDateTime,
                                order.PhoneNumber,
                                order.Status,
                                order.RoomPrice,
                                user.Fullname,
                                order.CustomerName,
                                order.Name
                            }
                            )
                            .Where(x => x.Name.ToLower().Contains(this.searchBox.Text.ToLower())).ToList();
                            break;
                        }
                    case "Số điện thoại":
                        {
                            list.DataSource = db.Orders.Join
                            (
                            db.Rooms,
                            order => order.RoomCode,
                            room => room.Code,
                            (order, room) => new
                            {
                                order.Id,
                                order.StartDateTime,
                                order.EndDateTime,
                                order.PhoneNumber,
                                order.Status,
                                order.RoomPrice,
                                order.PersonID,
                                order.CustomerName,
                                room.Name
                            }
                            )
                            .Join
                            (
                            db.Users,
                            order => order.PersonID,
                            user => user.PersonId,
                            (order, user) => new
                            {
                                order.Id,
                                order.StartDateTime,
                                order.EndDateTime,
                                order.PhoneNumber,
                                order.Status,
                                order.RoomPrice,
                                user.Fullname,
                                order.CustomerName,
                                order.Name
                            }
                            )
                            .Where(x => x.PhoneNumber.ToLower().Contains(this.searchBox.Text.ToLower())).ToList();
                            break;
                        }

                    default:
                        break;
                }
            }
            else
            {
                list.DataSource = getOrders();
            }
        }

        public BindingSource getOrders()
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = db.Orders.Join
                (
                db.Rooms,
                order => order.RoomCode,
                room => room.Code,
                (order, room) => new
                {
                    order.Id,
                    order.StartDateTime,
                    order.EndDateTime,
                    order.PhoneNumber,
                    order.Status,
                    order.RoomPrice,
                    order.PersonID,
                    order.CustomerName,
                    room.Name
                }
                )
                .Join
                (
                db.Users,
                order => order.PersonID,
                user => user.PersonId,
                (order, user) => new
                {
                    order.Id,
                    order.StartDateTime,
                    order.EndDateTime,
                    order.PhoneNumber,
                    order.Status,
                    order.RoomPrice,
                    user.Fullname,
                    order.CustomerName,
                    order.Name
                }
                ).ToList();
            return bds;
        }

        private void seachTypeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.searchType = this.seachTypeBox.Text;
        }
    }
}

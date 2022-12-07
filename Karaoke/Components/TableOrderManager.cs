using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;
using Karaoke.App;
using Karaoke.DB;

namespace Karaoke.Components
{
    public partial class TableOrderManager : Form
    {
        private AppDB db = new AppDB();
        private int lastIndex = -1;
        private Sort sort;
        private EditOrder edit;
        private string searchType;
        private string filterType;
        private AddOrderFood addOrderFoodFrm;
        public TableOrderManager()
        {
            InitializeComponent();
            list.AutoGenerateColumns = false;
            list.DataSource = getOrders();
            list.Rows[0].Selected = true;
            sort = new Sort(list.Columns[1].DataPropertyName, "ASC");
            searchType = this.seachTypeBox.Text;
            filterType = this.statusDropdown.Text;
            DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(0, 0);
            list_CellContentClick(new { }, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
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
                    list.Rows[0].Selected = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCellCollection cells = list.SelectedRows[0].Cells;
                edit = new EditOrder("EDIT_ORDER",
                    cells["Id"].Value.ToString(),
                    cells["CustomerName"].Value.ToString(),
                    cells["PhoneNumber"].Value.ToString(),
                    cells["RoomName"].Value.ToString(),
                    cells["PriceRoom"].Value.ToString(),
                    Convert.ToDateTime(cells["StartDateTime"].Value.ToString()),
                    Convert.ToDateTime(cells["EndDateTime"].Value.ToString()),
                    cells["Status"].Value.ToString()
                    );
                edit.FormClosed += editForm_FormClose;
                edit.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editForm_FormClose(object sender, FormClosedEventArgs e)
        {
            try
            {
                list.DataSource = getOrders();
                this.statusDropdown.SelectedIndex = 0;
                edit.FormClosed -= editForm_FormClose;
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                edit = new EditOrder("ADD_ORDER",
                   "",
                   "",
                   "",
                   "",
                   "",
                   DateTime.Now,
                   DateTime.Now,
                   ""
               );
                edit.FormClosed += editForm_FormClose;
                edit.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void statusDropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.statusDropdown.Text == "Tất cả")
                {
                    list.DataSource = getOrders();
                    list.Rows[0].Selected = true;
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
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            try
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
                    list.Rows[0].Selected = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public BindingSource getOrders()
        {
            BindingSource bds = new BindingSource();
            try
            {
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
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bds;
        }

        private void seachTypeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.searchType = this.seachTypeBox.Text;
        }

        private void addOrderFoodFrm_FormClose(object sender, FormClosedEventArgs e)
        {
            try
            {
                int orderId = int.Parse(list.SelectedCells[0].Value.ToString());
                BindingSource listOrderFood = new BindingSource() { DataSource = db.OrderFoods.Where(x => x.OrderId == orderId).Select(x => new { FoodId = x.FoodId, NameFood = x.Food.Name, FoodPrice = x.FoodPrice, QtyFood = x.FoodQuantily, Sum = x.FoodPrice * x.FoodQuantily }).ToList() };
                orderFoodView.DataSource = listOrderFood.DataSource; 
                if (orderFoodView.Rows.Count > 0)
                    orderFoodView.Rows[0].Selected = true;
                addOrderFoodFrm.FormClosed -= addOrderFoodFrm_FormClose;
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                addOrderFoodFrm = new AddOrderFood("ADD",list.SelectedCells[0].Value.ToString());
                addOrderFoodFrm.Text = "Thêm hóa đơn";
                addOrderFoodFrm.FormClosed += addOrderFoodFrm_FormClose;
                addOrderFoodFrm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int orderId = int.Parse(list.SelectedCells[0].Value.ToString());
                BindingSource listOrderFood = new BindingSource() { DataSource = db.OrderFoods.Where(x => x.OrderId == orderId).Select(x => new { FoodId = x.FoodId, NameFood = x.Food.Name, FoodPrice = x.FoodPrice, QtyFood = x.FoodQuantily, Sum = x.FoodPrice * x.FoodQuantily, x.Id }).ToList() };
                orderFoodView.DataSource = listOrderFood.DataSource;
                if(orderFoodView.Rows.Count > 0)
                    orderFoodView.Rows[0].Selected = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultMessage = MessageBox.Show("Chắc chắn xóa dữ liệu này???", "Xác nhận xóa", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == resultMessage)
                {
                    int idOrderFood = int.Parse(orderFoodView.SelectedRows[0].Cells["IdOrder"].Value.ToString());
                    OrderFood x = db.OrderFoods.First(o => o.Id == idOrderFood);
                    db.OrderFoods.Remove(x);
                    db.SaveChanges();

                    DataGridViewCellEventArgs evt = new DataGridViewCellEventArgs(0, 0);
                    list_CellContentClick(new { }, evt);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int idOrderFood = int.Parse(orderFoodView.SelectedRows[0].Cells["IdOrder"].Value.ToString());
                int foodId = int.Parse(orderFoodView.SelectedRows[0].Cells["FoodId"].Value.ToString());
                int amount = int.Parse(orderFoodView.SelectedRows[0].Cells["QtyFood"].Value.ToString());
                addOrderFoodFrm = new AddOrderFood("EDIT", list.SelectedCells[0].Value.ToString(), idOrderFood, foodId, amount);
                addOrderFoodFrm.Text = "Chỉnh sửa hóa đơn";
                addOrderFoodFrm.FormClosed += addOrderFoodFrm_FormClose;
                addOrderFoodFrm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void submitBillBtn_Click(object sender, EventArgs e)
        {

            DataGridViewCellCollection cells = list.SelectedRows[0].Cells;
            int id = (int)cells["Id"].Value;
            Bill bill = new Bill(id);
            bill.ShowDialog();
        }
    }
}

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
    public partial class EditOrder : Form
    {

        string id, customerName, phone, roomName, status, price, type;


        private void roomTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(roomTextBox.SelectedValue.ToString());

                double price;
                price = db.Rooms.First(x => x.Code == id).Price ?? 0;
                this.priceTextBox.Text = price.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "EDIT_ORDER":
                    {
                        edit();
                        break;
                    }
                case "ADD_ORDER":
                    {
                        add();
                        break;
                    }
                default:
                    break;
            }
            try
            {
                
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DateTime start, end;
        private AppDB db = new AppDB();

        public EditOrder(string type,string id, string customerName, string phone, string roomName,string price, DateTime start, DateTime end, string status)
        {
            InitializeComponent();
            this.id = id;
            this.customerName = customerName;
            this.phone = phone;
            this.roomName = roomName;
            this.start = start;
            this.end = end;
            this.price = price;
            this.status = status;
            this.type = type;
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            if(this.type == "ADD_ORDER")
            {

                this.idTextBox.Enabled = false;
                this.roomTextBox.DataSource = new BindingSource { DataSource = db.Rooms.ToList() };
                this.roomTextBox.ValueMember = "Code";
                this.roomTextBox.DisplayMember = "Name";
            }
            if(this.type == "EDIT_ORDER")
            {
                this.idTextBox.Text = id;
                this.nameTextBox.Text = customerName;
                this.phoneNumberTextBox.Text = phone;
                this.dateTimeStart.Value = start;
                this.dateTimeEnd.Value = end;
                int idx = this.statusComboBox.Items.IndexOf(status);
                this.statusComboBox.SelectedIndex = idx;
                this.roomTextBox.DataSource = new BindingSource { DataSource = db.Rooms.ToList() };
                this.roomTextBox.ValueMember = "Code";
                this.roomTextBox.DisplayMember = "Name";
                int idxRoom = db.Rooms.ToList().FindIndex(x => x.Name == roomName);
                this.roomTextBox.SelectedIndex = idxRoom;
                this.roomTextBox.Enabled = false;
                this.priceTextBox.Text = price;
            }
        }

        public void edit()
        {
            DialogResult rs = MessageBox.Show("Bạn chắn chắc lưu thay đổi này", "Lưu thay đổi", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK && validateForm())
            {
                int id = int.Parse(this.idTextBox.Text);
                string name = this.nameTextBox.Text;
                string phone = this.phoneNumberTextBox.Text;
                DateTime start = this.dateTimeStart.Value;
                DateTime end = this.dateTimeEnd.Value;
                string status = this.statusComboBox.Text;

                Order order = db.Orders.FirstOrDefault(x => x.Id == id);
                if (order != null)
                {
                    order.CustomerName = name;
                    order.PhoneNumber = phone;
                    order.StartDateTime = start;
                    order.EndDateTime = end;
                    order.Status = status;
                }
                db.SaveChanges();
            }
        }

        public void add()
        {
            DialogResult rs = MessageBox.Show("Bạn chắn chắc thêm dữ liệu này này", "Thêm dữ liệu", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (rs == DialogResult.OK && validateForm())
            {
                string name = this.nameTextBox.Text;
                string phone = this.phoneNumberTextBox.Text;
                DateTime start = this.dateTimeStart.Value;
                DateTime end = this.dateTimeEnd.Value;
                string status = this.statusComboBox.Text;


                int idRoom = int.Parse(roomTextBox.SelectedValue.ToString());

                Room room = db.Rooms.First(x => x.Code == idRoom);

                Order order = new Order
                {
                    CustomerName = name,
                    PhoneNumber = phone,
                    Status = status,
                    StartDateTime = start,
                    EndDateTime = end,
                    RoomCode = room.Code,
                    RoomPrice = room.Price,
                    PersonID = 1,
                };
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }

        public bool validateForm()
        {
            List<string> strError = new List<string>();
            if (this.nameTextBox.Text.Trim() == "")
            {
                strError.Add("Tên");
            }

            if (this.statusComboBox.Text.Trim() == "")
            {
                strError.Add("Trạng thái");
            }

            if (strError.Count > 0)
            {
                string result = String.Join(", ", strError.ToArray()) + " không được để trống!!!";
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }
    }
}
 
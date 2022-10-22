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

        string id, customerName, phone, roomName, status, price;

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.idTextBox.Text);
            string name = this.nameTextBox.Text;
            string phone = this.phoneNumberTextBox.Text;
            DateTime start  = this.dateTimeStart.Value;
            DateTime end = this.dateTimeEnd.Value;
            string status = this.statusComboBox.Text;

            Order order = db.Orders.FirstOrDefault(x => x.Id == id);
            if(order!= null)
            {
                order.CustomerName = name;
                order.PhoneNumber = phone;
                order.StartDateTime = start;
                order.EndDateTime = end;
                order.Status = status;
                db.SaveChanges();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        DateTime start, end;
        private AppDB db = new AppDB();

        public EditOrder(string id, string customerName, string phone, string roomName,string price, DateTime start, DateTime end, string status)
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
            Debug.WriteLine(start.ToString());
            Debug.WriteLine(end.ToString());
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {
            this.idTextBox.Text = id;
            this.nameTextBox.Text = customerName;
            this.phoneNumberTextBox.Text = phone;
            this.dateTimeStart.Value = start;
            this.dateTimeEnd.Value = end;
            int idx = this.statusComboBox.Items.IndexOf(status);
            this.statusComboBox.SelectedIndex = idx;
            this.roomTextBox.Text = roomName;
            this.priceTextBox.Text = price;
        }


    }
}
 
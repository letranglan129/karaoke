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

namespace Karaoke.Components
{
    public partial class AddOrderFood : Form
    {

        private AppDB db = new AppDB();
        private string type = "";
        private int orderFoodId = -1;
        private int maMon = -1;

        public AddOrderFood(string type,string orderId, int orderFoodId = -1, int maMon = -1, int soLuong = -1)
        {
            InitializeComponent();
            this.idTextBox.Text = orderId;
             BindingSource bds = new BindingSource();
            bds.DataSource = db.Foods.ToList();
            this.foodComboBox.DataSource = db.Foods.ToList();
            this.foodComboBox.DisplayMember = "Name";
            this.foodComboBox.ValueMember = "Id";
            this.foodComboBox.SelectedIndex = 0;
            int id = Convert.ToInt32(this.foodComboBox.SelectedValue.GetHashCode());
            this.priceTextBox.Text = db.Foods.First(x => x.Id == id).Price.ToString();
            this.type = type;
            this.orderFoodId = orderFoodId;
            this.maMon = maMon;

            if (orderFoodId != -1 && maMon != -1 && soLuong != -1 )
            {
               int i = db.Foods.ToList().FindIndex(x => x.Id == maMon);
                if(i != -1)
                {
                    foodComboBox.SelectedIndex = i;
                    this.qtyTextBox.Value = soLuong;
                    foodComboBox.Enabled = false;
                }
            }


            this.foodComboBox.DropDownStyle = ComboBoxStyle.DropDown;
            this.foodComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.foodComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void foodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.foodComboBox.SelectedValue.GetHashCode());
                this.priceTextBox.Text = db.Foods.First(x => x.Id == id).Price.ToString();
            }
            catch (Exception)
            {

            }
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "ADD":
                    {
                        add();
                        this.Close();
                        break;
                    }
                case "EDIT":
                    {
                        edit();
                        this.Close();
                        break;
                    }
                default:
                    break;
            }

        }

        private void add()
        {
            try
            {
                OrderFood of = new OrderFood();
                of.FoodId = Convert.ToInt32(this.foodComboBox.SelectedValue.GetHashCode());
                of.OrderId = int.Parse(this.idTextBox.Text);
                of.FoodPrice = double.Parse(this.priceTextBox.Text);
                of.FoodQuantily = int.Parse(this.qtyTextBox.Value.ToString());
                db.OrderFoods.Add(of);
                db.SaveChanges();
                MessageBox.Show("Thêm món vào hóa đơn thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Thêm món vào hóa đơn thất bại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edit()
        {
            OrderFood of = db.OrderFoods.First(x => x.Id == orderFoodId);
            if(of != null)
            {
                of.FoodQuantily = int.Parse(this.qtyTextBox.Value.ToString());
                db.SaveChanges();
            }
        }
    }
}

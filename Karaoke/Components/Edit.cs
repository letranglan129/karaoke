using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke.DB;

namespace Karaoke.Components
{
    public partial class Edit : Form
    {

        private AppDB db = new AppDB();
        string type;

        public Edit(string type, string id = "", string name="", int price=0, string status="")
        {
            InitializeComponent();

            this.type = type;
            this.idTextBox.Text = id;
            this.idTextBox.ReadOnly = true;
            this.nameTextBox.Text = name;
            this.priceTextBox.Value = price;
            this.idTextBox.Enabled = false;
            

            switch (type)
            {
                case "ADD_ROOM":
                    {
                        this.confirmButton.Text = "Thêm";
                        this.idTextBox.Text = getNewIdRoom();
                        break;
                    }
                case "EDIT_ROOM":
                    {
                        for (int i = 0; i < this.statusComboBox.Items.Count; i++)
                        {
                            if (this.statusComboBox.Items[i].ToString() == status)
                                this.statusComboBox.StartIndex = i;
                        }
                        break;
                    }
                case "EDIT_FOOD":
                    {
                        this.nameLabel.Text = "Tên thức ăn";
                        this.statusLabel.Text = "Loại";
                        this.statusComboBox.DataSource = new List<string> { "Nước giải khát", "Thức ăn" };
                        for (int i = 0; i < this.statusComboBox.Items.Count; i++)
                        {
                            if (this.statusComboBox.Items[i].ToString() == status)
                                this.statusComboBox.StartIndex = i;
                        }
                        break;
                    }
                case "ADD_FOOD":
                    {
                        this.confirmButton.Text = "Thêm";
                        this.nameLabel.Text = "Tên thức ăn";
                        this.statusLabel.Text = "Loại";
                        this.statusComboBox.DataSource = new List<string> { "Nước giải khát", "Thức ăn" };
                        this.statusComboBox.StartIndex = -1;
                        this.idTextBox.Text = getNewIdFood();
                        break;
                    }
                default:
                    break;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string getNewIdRoom()
        {
            var lastRoom = db.Rooms.OrderByDescending(x => x.Code).FirstOrDefault();
            long idNumber = lastRoom.Code + 1;
            return idNumber.ToString();
        }

        private string getNewIdFood()
        {
            var lastFood = db.Foods.OrderByDescending(x => x.Id).FirstOrDefault();
            long idNumber = lastFood.Id + 1;
            return idNumber.ToString();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "EDIT_ROOM":
                    {
                        DialogResult resultMessage = MessageBox.Show("Chắc chắn với sự thay đổi này???", "Xác nhận sửa đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (DialogResult.Yes == resultMessage && validateForm())
                        {
                            var result = db.Rooms.Find(Int64.Parse(this.idTextBox.Text));
                            result.Name = this.nameTextBox.Text;
                            result.Status = this.statusComboBox.Text;
                            result.Price = decimal.ToDouble(this.priceTextBox.Value);
                            db.SaveChanges();
                            this.Close();
                        }
                        break;
                    }
                case "ADD_ROOM":
                    {
                        DialogResult resultMessage = MessageBox.Show("Chắc chắn thêm phòng này???", "Xác nhận sửa đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (DialogResult.Yes == resultMessage && validateForm())
                        {
                            var newRoom = new Room
                            {
                                Name = this.nameTextBox.Text,
                                Price = decimal.ToInt32(this.priceTextBox.Value),
                                Status = this.statusComboBox.Text,
                            };

                            db.Entry(newRoom).State = EntityState.Added;
                            db.Rooms.Add(newRoom);
                            db.SaveChanges();
                            this.Close();
                        }
                        break;
                    }
                case "EDIT_FOOD":
                    {
                        DialogResult resultMessage = MessageBox.Show("Chắc chắn với sự thay đổi này???", "Xác nhận sửa đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (DialogResult.Yes == resultMessage && validateForm())
                        {
                            var result = db.Foods.Find(Int64.Parse(this.idTextBox.Text));
                            result.Name = this.nameTextBox.Text;
                            result.Type = this.statusComboBox.Text;
                            result.Price = decimal.ToDouble(this.priceTextBox.Value);
                            db.SaveChanges();
                            this.Close();
                        }
                        break;
                    }
                case "ADD_FOOD":
                    {
                        DialogResult resultMessage = MessageBox.Show("Chắc chắn thêm thức ăn này???", "Xác nhận sửa đổi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (DialogResult.Yes == resultMessage && validateForm())
                        {
                            var newFood = new Food
                            {
                                Name = this.nameTextBox.Text,
                                Price = decimal.ToInt32(this.priceTextBox.Value),
                                Type = this.statusComboBox.Text,
                            };

                            db.Entry(newFood).State = EntityState.Added;
                            db.Foods.Add(newFood);
                            db.SaveChanges();
                            this.Close();
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        public bool validateForm()
        {
            List<string> strError = new List<string>();
            if(this.nameTextBox.Text.Trim() == "")
            {
                strError.Add("Tên");
            }

            if (this.statusComboBox.Text.Trim() == "")
            {
                switch (type)
                {
                    case "EDIT_ROOM":
                    case "ADD_ROOM":
                        {
                            strError.Add("Trạng thái");
                            break;
                        }
                    case "EDIT_FOOD":
                    case "ADD_FOOD":
                        {
                            strError.Add("Loại");
                            break;
                        }
                    default:
                        break;
                }
            }

            if(strError.Count > 0)
            {
                string result = String.Join(", ", strError.ToArray()) + " không được để trống!!!";
                MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
            
        }

        
    }
}

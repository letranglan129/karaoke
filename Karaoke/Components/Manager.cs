using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke.DB;
using Karaoke.App;

namespace Karaoke.Components
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            foreach (TabPage item in this.tabControl.TabPages)
            {
                item.Controls.Clear();

                if (UserStorage.LoginUser.UserType != "Quản trị viên" && item.Text == "Quản lý nhân viên")
                {
                    this.tabControl.TabPages.Remove(item);
                }
            }
            createTableRoomManager();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            foreach (TabPage item in this.tabControl.TabPages)
            {
                item.Controls.Clear();

                if (UserStorage.LoginUser.UserType != "Quản trị viên" && item.Text == "Quản lý nhân viên")
                {
                    this.tabControl.TabPages.Remove(item);
                }
            }
            switch (e.TabPage.Text)
            {
                case "Quản lý phòng":
                    {
                        createTableRoomManager();
                        break;
                    }
                case "Quản lý thức ăn":
                    {
                        createTableFoodManager();
                        break;
                    }
                case "Quản lý hóa đơn":
                    {
                        createTableOrderManager();
                        break;
                    }
                case "Quản lý nhân viên":
                    {
                        createTableUserManager();
                        break;
                    }
                default:
                    break;
            }
        }

        public void createTableRoomManager()
        {
            TableRoomManager tableRoomManager = new TableRoomManager();
            tableRoomManager.TopLevel = false;
            tableRoomManager.Parent = this.roomTab;
            tableRoomManager.Show();
            tableRoomManager.Dock = DockStyle.Fill;
        }

        public void createTableFoodManager()
        {
            TableFoodManager tableFoodManager = new TableFoodManager();
            tableFoodManager.TopLevel = false;
            tableFoodManager.Parent = this.foodTab;
            tableFoodManager.Show();
            tableFoodManager.Dock = DockStyle.Fill;
        }
        public void createTableOrderManager()
        {
            TableOrderManager tableOrderManager = new TableOrderManager();
            tableOrderManager.TopLevel = false;
            tableOrderManager.Parent = this.orderTab;
            tableOrderManager.Show();
            tableOrderManager.Dock = DockStyle.Fill;
        }

        public void createTableUserManager()
        {
            TableUserManager table = new TableUserManager();
            table.TopLevel = false;
            table.Parent = this.userTab;
            table.Show();
            table.Dock = DockStyle.Fill;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke.Components;

namespace Karaoke.pages
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Home home = new Home();
            home.TopLevel = false;
            home.Parent = homeTabContainer;
            home.Show();
            home.Dock = DockStyle.Fill;
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            homeTabContainer.Controls.Clear();
            managerTabContainer.Controls.Clear(); 
            userManagerTabContainer.Controls.Clear();
            switch (e.TabPage.Text)
            {
                case "Trang chủ":
                    {
                        Home home = new Home();
                        home.TopLevel = false;
                        home.Parent = homeTabContainer;
                        home.Show();
                        home.Dock = DockStyle.Fill;
                        break;
                    }
                case "Quản lý":
                    {
                        Manager manager = new Manager();

                        manager.Update();
                        manager.TopLevel = false;
                        manager.Parent = managerTabContainer;
                        manager.Show();
                        manager.Dock = DockStyle.Fill;
                        break;
                    }
                case "Quản trị":
                    {
                        UserManager userManager = new UserManager();
                        userManager.TopLevel = false;
                        userManager.Parent = userManagerTabContainer;
                        userManager.Show();
                        userManager.Dock = DockStyle.Fill;

                        break;
                    }
                default:
                    break;
            }
        }
    }
}

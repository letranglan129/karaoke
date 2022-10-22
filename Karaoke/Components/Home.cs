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
using Karaoke.Constanst;

namespace Karaoke.Components
{
    public partial class Home : Form
    {

        private AppDB db = new AppDB();

        public Home()
        {
            InitializeComponent();

            styleHome();
            loadRoom();
            viewAnalyticRoom();
        }

        public Label createLabelEmpty()
        {
            Label labelEmpty = new Label();
            labelEmpty.Text = "Trống";
            labelEmpty.Width = this.homeContainer.Width;
            labelEmpty.Height = 80;
            labelEmpty.Font = new Font("Arial", 16);
            labelEmpty.TextAlign = ContentAlignment.MiddleCenter;
            labelEmpty.Margin = new Padding(0);
            labelEmpty.ForeColor = Color.White;
            return labelEmpty;
        }

        public void loadRoom()
        {
            if (db.Rooms.ToList().Count == 0)
            {
                Label labelEmpty = createLabelEmpty();
                this.homeContainer.Controls.Add(labelEmpty);
            }
            else
            {
                foreach (var room in db.Rooms.ToList())
                {
                    RoomUI roomUI = new RoomUI(room);
                    this.homeContainer.Controls.Add(roomUI);
                }
            }
        }

        public void viewAnalyticRoom()
        {
            List<RoomStatusProperty> list = RoomStatus.getListRoomStatus();
            int total = 0;


            RoomStatusButton totalButton = new RoomStatusButton("Tất cả", total, "#000000", filterRoom);
            totalButton.Width = this.viewRoomStatus.Width * 2 / 10;
            this.viewRoomStatus.Controls.Add(totalButton);

            list.ForEach(item =>
            {
                int quantity = db.Rooms.Count(x => x.Status == item.name);
                total += quantity;
                RoomStatusButton button = new RoomStatusButton(item.name, quantity, item.color, filterRoom);
                this.viewRoomStatus.Controls.Add(button);
                button.Width = this.viewRoomStatus.Width * 2 / 10;
            });

            totalButton.Quantity = total;
        }

        public string filterRoom(string name)
        {
            homeContainer.Controls.Clear();

            var roomFilter = name == "Tất cả"? db.Rooms.ToList() : db.Rooms.Where(x => x.Status == name).ToList();

            if (roomFilter.Count == 0)
            {
                Label labelEmpty = createLabelEmpty();
                homeContainer.Controls.Add(labelEmpty);
            }
            else
            {
                foreach (var room in roomFilter)
                {
                    RoomUI roomUI = new RoomUI(room);
                    homeContainer.Controls.Add(roomUI);
                }
            }

            this.tittle.Text = name;
            return name;
        }
    
        public void styleHome()
        {
            this.homeContainer.Height -= 80;
        }
    }
}

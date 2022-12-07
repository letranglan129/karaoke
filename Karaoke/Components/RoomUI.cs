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
using Karaoke.Library;

namespace Karaoke.Components
{
    public partial class RoomUI : UserControl
    {
        private Room room;
        private AppDB db = new AppDB();

        public RoomUI(Room room)
        {
            InitializeComponent();
            Room = room;
            styleRoom();
        }

        public Room Room { 
            get { return room; }
            set
            {
                switch(value.Status)
                {
                    case RoomStatus.EMPTY:
                        this.BackColor = ColorTranslator.FromHtml(RoomStatus.EMPTY_COLOR);
                        break;
                    case RoomStatus.USING:
                        this.BackColor = ColorTranslator.FromHtml(RoomStatus.USING_COLOR);
                        break;
                    case RoomStatus.DIRTY:
                        this.BackColor = ColorTranslator.FromHtml(RoomStatus.DIRTY_COLOR);
                        break;
                    case RoomStatus.CLEANING:
                        this.BackColor = ColorTranslator.FromHtml(RoomStatus.CLEANING_COLOR);
                        break;
                    case RoomStatus.REPAIRING:
                        this.BackColor = ColorTranslator.FromHtml(RoomStatus.REPAIRING_COLOR);
                        break;
                    case RoomStatus.BOOK:
                        this.BackColor = ColorTranslator.FromHtml(RoomStatus.BOOK_COLOR);
                        break;
                    default:
                        break;
                }

                room = value;
            }
        }

        private void styleRoom()
        {
            this.nameRoom.Width = this.Width;
            this.statusRoom.Width = this.Width;
            this.nameRoom.Text = Room.Name;
            this.statusRoom.Text = Room.Status;
            DateTime time = Convert.ToDateTime(Room.StartDateTime);
            this.price.Text = "Giá: " + Money.format(Room.Price ?? 0);
        }
    }
}

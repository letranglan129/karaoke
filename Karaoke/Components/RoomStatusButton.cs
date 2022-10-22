using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karaoke.DB;

namespace Karaoke.Components
{
    public partial class RoomStatusButton : UserControl
    {
        string name;
        int quantity = 0;
        string color;
        private Func<string, string> filterRoom;

        private AppDB db = new AppDB();

        public string NameRoom
        {
            get { return name; }
            set
            {
                this.button.Text = Quantity.ToString() + " " + value;
                name = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                this.button.Text = value.ToString() + " " + NameRoom;
                quantity = value;
            }
        }

        public string Color {
            get { return color; }
            set
            {
                this.lineButton.BackColor = ColorTranslator.FromHtml(value);
                color = value;
            }
        }

        public Func<string, string> FilterRoom 
        { 
            get { return filterRoom; } 
            set
            {
                filterRoom = value;
            }
        }

        public RoomStatusButton(string name, int quantity, string color, Func<string, string> filterRoom)
        {
            InitializeComponent();
            this.NameRoom = name;
            this.Quantity = quantity;
            this.Color = color;
            this.FilterRoom = filterRoom;
        }

        private void button_Click(object sender, EventArgs e)
        {
                this.FilterRoom(NameRoom);
        }
    }
}

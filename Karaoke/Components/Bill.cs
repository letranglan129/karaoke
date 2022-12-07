using Karaoke.DB;
using Karaoke.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Karaoke.Components
{
    public partial class Bill : Form
    {
        private AppDB db = new AppDB();
        Order order;
        double sumRoom = 0;
        double sumFood = 0;
        int height;

        public Bill(int OrderId)
        {
            InitializeComponent();
            order = db.Orders.First(x => x.Id == OrderId);
            height = this.Height;
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            this.dateBill.Text = DateTime.Now.ToString();
            this.customer.Text = order.CustomerName;
            this.customerPhone.Text = order.PhoneNumber;
            this.userBill.Text = order.User.Fullname;
            var index = RoomTable.Rows.Add();

            TimeSpan? usedTime = order.EndDateTime - order.StartDateTime;
            sumRoom = order.RoomPrice * (usedTime.Value.Hours + usedTime.Value.Minutes / 60.0) / 5000.0 ?? 0;
            sumRoom = Math.Round(sumRoom, 0) * 5000;

            RoomTable.Rows[index].Cells["Room"].Value = order.Room.Name;
            RoomTable.Rows[index].Cells["StartTime"].Value = order.StartDateTime?.ToString("MM/dd/yyyy H:mm");
            RoomTable.Rows[index].Cells["EndTime"].Value = order.EndDateTime?.ToString("MM/dd/yyyy H:mm"); ;
            RoomTable.Rows[index].Cells["UsedTime"].Value = usedTime?.ToString(@"hh\:mm");
            RoomTable.Rows[index].Cells["Price"].Value = order.RoomPrice;
            RoomTable.Rows[index].Cells["Total"].Value = sumRoom;

            try
            {
                var matHangs = db.OrderFoods.Where(x => x.OrderId == order.Id).Select(x => new { NameFood = x.Food.Name, FoodPrice = x.FoodPrice, QtyFood = x.FoodQuantily, Sum = x.FoodPrice * x.FoodQuantily}).ToList();
                sumFood = matHangs.Sum(x => x.Sum) ?? 0;
                BindingSource listOrderFood = new BindingSource() { DataSource = matHangs };
                this.FoodTable.DataSource = listOrderFood.DataSource;
                if (FoodTable.Rows.Count > 0)
                    FoodTable.Rows[0].Selected = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            sumFoodLabel.Text = Money.format(sumFood);
            sumRoomLabel.Text = Money.format(sumRoom);
            SumLabel.Text = Money.format(sumFood + sumRoom);
        }



        private void Print(Guna2Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            printPanel = pnl;
            getprintarea(pnl);
            printPreviewDialog.Document = printDocument;
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);
            printPreviewDialog.Height = Screen.PrimaryScreen.Bounds.Height;
            printPreviewDialog.Width = Screen.PrimaryScreen.Bounds.Width;
            printPreviewDialog.ShowDialog();

        }

        private Bitmap memoryImg;

        private void getprintarea(Guna2Panel pnl)
        {

            memoryImg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryImg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            Print(printPanel);
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg, (pagearea.Width) - (this.printPanel.Width), this.printPanel.Location.Y);
        }

        private void FoodTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var height = 40;
            foreach (DataGridViewRow dr in FoodTable.Rows)
            {
                height += dr.Height;
            }

            FoodTable.Height = height;
            wrapTotalPanel.Location = new Point(wrapTotalPanel.Location.X, FoodTable.Location.Y + FoodTable.Height);

            this.Height = this.height + height;
        }
    }
}

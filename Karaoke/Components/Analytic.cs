using Guna.UI2.WinForms;
using Karaoke.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke.Components
{
    public partial class Analytic : Form
    {
        private AppDB db = new AppDB();
        public Analytic()
        {
            InitializeComponent();
            List<int> years = new List<int>();
            for (int i = DateTime.Now.Year-5; i < DateTime.Now.Year + 5; i++)
            {
                years.Add(i);
            }
            yearComboBox.DataSource = new BindingSource { DataSource = years };
            yearComboBox.SelectedIndex = 5;
        }

        private void yearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                Guna2VProgressBar el = this.Controls.Find("month" + i.ToString(), true)[0] as Guna2VProgressBar;
                Label percentValue = this.Controls.Find("percentM" + i.ToString(), true)[0] as Label;
                el.Value = 0;
                percentValue.Text = "0";
            }
            int year = (int)yearComboBox.SelectedValue;
            var orders = db.Orders.Where(o => o.StartDateTime != null && o.StartDateTime.Value.Year == year)
                                            .GroupBy(x => new
                                            {
                                                Month = x.StartDateTime.Value.Month,
                                            }).Select(y => new
                                            {
                                                Month = y.Key.Month,
                                                OrderCount = y.Count(),
                                            }).ToList();


            int max = orders.Count != 0 ? orders.Max(x => x.OrderCount) : 0;
            maxValue.Text = max.ToString();
            for (int i = 0; i < orders.Count; i++)
            {
                Guna2VProgressBar el = this.Controls.Find("month" + orders[i].Month, true)[0] as Guna2VProgressBar;
                Label percentValue = this.Controls.Find("percentM" + orders[i].Month, true)[0] as Label;
                el.Value = (int)100.0 / max * orders[i].OrderCount;
                percentValue.Text = orders[i].OrderCount.ToString();
            }

            totalOrder.Text = orders.Sum(o => o.OrderCount).ToString();
            totalTurnover.Text = sumTurnover(year).ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
        }
    
    
        private int sumTurnover(int year)
        {
            double sum = 0;
            List<Order> orders = db.Orders.Where(o => o.StartDateTime != null && o.StartDateTime.Value.Year == year).ToList();
            for (int i = 0; i < orders.Count; i++)
            {
                TimeSpan? usedTime = orders[i].EndDateTime - orders[i].StartDateTime;

                double sumRoom = orders[i].RoomPrice * (usedTime.Value.Hours + usedTime.Value.Minutes / 60.0) / 5000.0 ?? 0;
                sumRoom = Math.Round(sumRoom, 0) * 5000;
                double sumFood = orders[i].OrderFoods.Sum(o => o.FoodPrice * o.FoodQuantily) ?? 0;
                sum += (sumRoom + sumFood);
            }
            return (int)sum;
        }
    }
}

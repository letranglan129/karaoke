
namespace Karaoke.Components
{
    partial class Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.RoomTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.printBtn = new Guna.UI2.WinForms.Guna2Button();
            this.printPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.wrapTotalPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sumRoomLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sumFoodLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SumLabel = new System.Windows.Forms.Label();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dateBill = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customerPhone = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.userBill = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.customer = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.RoomTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodTable)).BeginInit();
            this.printPanel.SuspendLayout();
            this.wrapTotalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // RoomTable
            // 
            this.RoomTable.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RoomTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RoomTable.ColumnHeadersHeight = 27;
            this.RoomTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Room,
            this.StartTime,
            this.EndTime,
            this.UsedTime,
            this.Price,
            this.Total});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.RoomTable.Enabled = false;
            this.RoomTable.GridColor = System.Drawing.Color.White;
            this.RoomTable.Location = new System.Drawing.Point(47, 299);
            this.RoomTable.Margin = new System.Windows.Forms.Padding(2);
            this.RoomTable.Name = "RoomTable";
            this.RoomTable.ReadOnly = true;
            this.RoomTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.RoomTable.RowHeadersVisible = false;
            this.RoomTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomTable.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.RoomTable.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomTable.RowTemplate.Height = 33;
            this.RoomTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RoomTable.ShowCellErrors = false;
            this.RoomTable.ShowCellToolTips = false;
            this.RoomTable.ShowEditingIcon = false;
            this.RoomTable.ShowRowErrors = false;
            this.RoomTable.Size = new System.Drawing.Size(770, 105);
            this.RoomTable.TabIndex = 23;
            this.RoomTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RoomTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RoomTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RoomTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RoomTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RoomTable.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.RoomTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.RoomTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RoomTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RoomTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.RoomTable.ThemeStyle.HeaderStyle.Height = 27;
            this.RoomTable.ThemeStyle.ReadOnly = true;
            this.RoomTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.RoomTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RoomTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.RoomTable.ThemeStyle.RowsStyle.Height = 33;
            this.RoomTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.RoomTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // Room
            // 
            this.Room.DataPropertyName = "Room";
            this.Room.HeaderText = "Phòng";
            this.Room.MinimumWidth = 10;
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            // 
            // StartTime
            // 
            this.StartTime.DataPropertyName = "StartTime";
            this.StartTime.HeaderText = "Giờ Vào";
            this.StartTime.MinimumWidth = 10;
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            // 
            // EndTime
            // 
            this.EndTime.DataPropertyName = "EndTime";
            this.EndTime.HeaderText = "Giờ ra";
            this.EndTime.MinimumWidth = 10;
            this.EndTime.Name = "EndTime";
            this.EndTime.ReadOnly = true;
            // 
            // UsedTime
            // 
            this.UsedTime.DataPropertyName = "UsedTime";
            this.UsedTime.HeaderText = "Thời gian dùng";
            this.UsedTime.MinimumWidth = 10;
            this.UsedTime.Name = "UsedTime";
            this.UsedTime.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "N0";
            this.Price.DefaultCellStyle = dataGridViewCellStyle3;
            this.Price.HeaderText = "Đơn giá";
            this.Price.MinimumWidth = 10;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            dataGridViewCellStyle4.Format = "N0";
            this.Total.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total.HeaderText = "Thành tiền";
            this.Total.MinimumWidth = 10;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // FoodTable
            // 
            this.FoodTable.AllowUserToAddRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.FoodTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.FoodTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FoodTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.FoodTable.ColumnHeadersHeight = 30;
            this.FoodTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FoodTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Food,
            this.PriceFood,
            this.Quantity,
            this.TotalFood});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FoodTable.DefaultCellStyle = dataGridViewCellStyle13;
            this.FoodTable.GridColor = System.Drawing.Color.White;
            this.FoodTable.Location = new System.Drawing.Point(47, 428);
            this.FoodTable.Margin = new System.Windows.Forms.Padding(2);
            this.FoodTable.Name = "FoodTable";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FoodTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.FoodTable.RowHeadersVisible = false;
            this.FoodTable.RowHeadersWidth = 82;
            this.FoodTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodTable.RowTemplate.Height = 33;
            this.FoodTable.Size = new System.Drawing.Size(770, 83);
            this.FoodTable.TabIndex = 24;
            this.FoodTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FoodTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FoodTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FoodTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FoodTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FoodTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.FoodTable.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.FoodTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FoodTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FoodTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FoodTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FoodTable.ThemeStyle.HeaderStyle.Height = 30;
            this.FoodTable.ThemeStyle.ReadOnly = false;
            this.FoodTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FoodTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FoodTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.FoodTable.ThemeStyle.RowsStyle.Height = 33;
            this.FoodTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.FoodTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.FoodTable.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.FoodTable_DataBindingComplete);
            // 
            // Food
            // 
            this.Food.DataPropertyName = "NameFood";
            this.Food.HeaderText = "Mặt hàng";
            this.Food.MinimumWidth = 10;
            this.Food.Name = "Food";
            // 
            // PriceFood
            // 
            this.PriceFood.DataPropertyName = "FoodPrice";
            dataGridViewCellStyle10.Format = "N0";
            this.PriceFood.DefaultCellStyle = dataGridViewCellStyle10;
            this.PriceFood.HeaderText = "Giá";
            this.PriceFood.MinimumWidth = 10;
            this.PriceFood.Name = "PriceFood";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "QtyFood";
            dataGridViewCellStyle11.Format = "N0";
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle11;
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.MinimumWidth = 10;
            this.Quantity.Name = "Quantity";
            // 
            // TotalFood
            // 
            this.TotalFood.DataPropertyName = "Sum";
            dataGridViewCellStyle12.Format = "N0";
            this.TotalFood.DefaultCellStyle = dataGridViewCellStyle12;
            this.TotalFood.HeaderText = "Thành tiền";
            this.TotalFood.MinimumWidth = 10;
            this.TotalFood.Name = "TotalFood";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(806, 75);
            this.label5.TabIndex = 34;
            this.label5.Text = "HÓA ĐƠN";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printBtn
            // 
            this.printBtn.BorderRadius = 6;
            this.printBtn.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.printBtn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.printBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.printBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.printBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.printBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(703, 33);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(114, 37);
            this.printBtn.TabIndex = 38;
            this.printBtn.Text = "In hóa đơn";
            this.printBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // printPanel
            // 
            this.printPanel.BackColor = System.Drawing.Color.Transparent;
            this.printPanel.Controls.Add(this.wrapTotalPanel);
            this.printPanel.Controls.Add(this.printBtn);
            this.printPanel.Controls.Add(this.label5);
            this.printPanel.Controls.Add(this.guna2HtmlLabel4);
            this.printPanel.Controls.Add(this.guna2HtmlLabel3);
            this.printPanel.Controls.Add(this.guna2HtmlLabel1);
            this.printPanel.Controls.Add(this.dateBill);
            this.printPanel.Controls.Add(this.FoodTable);
            this.printPanel.Controls.Add(this.RoomTable);
            this.printPanel.Controls.Add(this.customerPhone);
            this.printPanel.Controls.Add(this.userBill);
            this.printPanel.Controls.Add(this.guna2HtmlLabel2);
            this.printPanel.Controls.Add(this.customer);
            this.printPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPanel.Location = new System.Drawing.Point(0, 0);
            this.printPanel.Margin = new System.Windows.Forms.Padding(20);
            this.printPanel.Name = "printPanel";
            this.printPanel.Padding = new System.Windows.Forms.Padding(20);
            this.printPanel.Size = new System.Drawing.Size(855, 696);
            this.printPanel.TabIndex = 0;
            // 
            // wrapTotalPanel
            // 
            this.wrapTotalPanel.Controls.Add(this.label6);
            this.wrapTotalPanel.Controls.Add(this.panel1);
            this.wrapTotalPanel.Controls.Add(this.sumRoomLabel);
            this.wrapTotalPanel.Controls.Add(this.label3);
            this.wrapTotalPanel.Controls.Add(this.sumFoodLabel);
            this.wrapTotalPanel.Controls.Add(this.label1);
            this.wrapTotalPanel.Controls.Add(this.SumLabel);
            this.wrapTotalPanel.Location = new System.Drawing.Point(47, 516);
            this.wrapTotalPanel.Name = "wrapTotalPanel";
            this.wrapTotalPanel.Size = new System.Drawing.Size(770, 145);
            this.wrapTotalPanel.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-7, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 34);
            this.label6.TabIndex = 42;
            this.label6.Text = "Tổng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-2, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 2);
            this.panel1.TabIndex = 41;
            // 
            // sumRoomLabel
            // 
            this.sumRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumRoomLabel.Location = new System.Drawing.Point(609, 46);
            this.sumRoomLabel.Name = "sumRoomLabel";
            this.sumRoomLabel.Size = new System.Drawing.Size(153, 34);
            this.sumRoomLabel.TabIndex = 40;
            this.sumRoomLabel.Text = "Tiền giờ";
            this.sumRoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 34);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tiền giờ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sumFoodLabel
            // 
            this.sumFoodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumFoodLabel.Location = new System.Drawing.Point(609, 1);
            this.sumFoodLabel.Name = "sumFoodLabel";
            this.sumFoodLabel.Size = new System.Drawing.Size(153, 34);
            this.sumFoodLabel.TabIndex = 38;
            this.sumFoodLabel.Text = "Tiền hàng";
            this.sumFoodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-7, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 34);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tiền hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SumLabel
            // 
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumLabel.Location = new System.Drawing.Point(604, 110);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(156, 34);
            this.SumLabel.TabIndex = 43;
            this.SumLabel.Text = "Tiền giờ";
            this.SumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(462, 155);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(74, 22);
            this.guna2HtmlLabel4.TabIndex = 28;
            this.guna2HtmlLabel4.Text = "Thu ngân:";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(47, 241);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(100, 22);
            this.guna2HtmlLabel3.TabIndex = 27;
            this.guna2HtmlLabel3.Text = "Số điện thoại:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(47, 205);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(123, 22);
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "Tên Khách hàng:";
            // 
            // dateBill
            // 
            this.dateBill.BackColor = System.Drawing.Color.Transparent;
            this.dateBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBill.Location = new System.Drawing.Point(133, 155);
            this.dateBill.Name = "dateBill";
            this.dateBill.Size = new System.Drawing.Size(129, 22);
            this.dateBill.TabIndex = 25;
            this.dateBill.Text = "guna2HtmlLabel5";
            // 
            // customerPhone
            // 
            this.customerPhone.BackColor = System.Drawing.Color.Transparent;
            this.customerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhone.Location = new System.Drawing.Point(204, 241);
            this.customerPhone.Margin = new System.Windows.Forms.Padding(2);
            this.customerPhone.Name = "customerPhone";
            this.customerPhone.Size = new System.Drawing.Size(100, 22);
            this.customerPhone.TabIndex = 22;
            this.customerPhone.Text = "Số điện thoại:";
            // 
            // userBill
            // 
            this.userBill.BackColor = System.Drawing.Color.Transparent;
            this.userBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userBill.Location = new System.Drawing.Point(556, 155);
            this.userBill.Margin = new System.Windows.Forms.Padding(2);
            this.userBill.Name = "userBill";
            this.userBill.Size = new System.Drawing.Size(74, 22);
            this.userBill.TabIndex = 21;
            this.userBill.Text = "Thu ngân:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(47, 155);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(43, 22);
            this.guna2HtmlLabel2.TabIndex = 20;
            this.guna2HtmlLabel2.Text = "Ngày:";
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.Transparent;
            this.customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer.Location = new System.Drawing.Point(204, 205);
            this.customer.Margin = new System.Windows.Forms.Padding(2);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(123, 22);
            this.customer.TabIndex = 19;
            this.customer.Text = "Tên Khách hàng:";
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(855, 696);
            this.Controls.Add(this.printPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoodTable)).EndInit();
            this.printPanel.ResumeLayout(false);
            this.printPanel.PerformLayout();
            this.wrapTotalPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private Guna.UI2.WinForms.Guna2DataGridView RoomTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2DataGridView FoodTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFood;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button printBtn;
        private Guna.UI2.WinForms.Guna2Panel printPanel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel dateBill;
        private Guna.UI2.WinForms.Guna2HtmlLabel customerPhone;
        private Guna.UI2.WinForms.Guna2HtmlLabel userBill;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel customer;
        private Guna.UI2.WinForms.Guna2Panel wrapTotalPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label sumRoomLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sumFoodLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SumLabel;
    }
}
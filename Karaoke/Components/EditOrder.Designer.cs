namespace Karaoke.Components
{
    partial class EditOrder
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
            this.statusComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.idTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.statusLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.IdLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.phoneNumberTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.confirmBtn = new Guna.UI2.WinForms.Guna2Button();
            this.closeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.priceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.roomTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // statusComboBox
            // 
            this.statusComboBox.AllowDrop = true;
            this.statusComboBox.BackColor = System.Drawing.Color.Transparent;
            this.statusComboBox.DisplayMember = "123";
            this.statusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.statusComboBox.ItemHeight = 32;
            this.statusComboBox.Items.AddRange(new object[] {
            "Đang sử dụng",
            "Chưa thanh toán",
            "Ðã thanh toán"});
            this.statusComboBox.Location = new System.Drawing.Point(221, 491);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(293, 38);
            this.statusComboBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.statusComboBox.TabIndex = 12;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Location = new System.Drawing.Point(221, 97);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(292, 38);
            this.nameTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.nameTextBox.TabIndex = 10;
            // 
            // idTextBox
            // 
            this.idTextBox.AcceptsTab = true;
            this.idTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTextBox.DefaultText = "";
            this.idTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idTextBox.Enabled = false;
            this.idTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idTextBox.ForeColor = System.Drawing.Color.Black;
            this.idTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idTextBox.Location = new System.Drawing.Point(221, 33);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.PasswordChar = '\0';
            this.idTextBox.PlaceholderText = "";
            this.idTextBox.SelectedText = "";
            this.idTextBox.Size = new System.Drawing.Size(292, 38);
            this.idTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.idTextBox.TabIndex = 9;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = false;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(37, 480);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(160, 38);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Trạng thái";
            this.statusLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = false;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(37, 97);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(160, 38);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Tên";
            this.nameLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = false;
            this.IdLabel.BackColor = System.Drawing.Color.Transparent;
            this.IdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.Location = new System.Drawing.Point(37, 33);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(160, 38);
            this.IdLabel.TabIndex = 8;
            this.IdLabel.Text = "ID";
            this.IdLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumberTextBox.DefaultText = "";
            this.phoneNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(221, 163);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.PasswordChar = '\0';
            this.phoneNumberTextBox.PlaceholderText = "";
            this.phoneNumberTextBox.SelectedText = "";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(292, 38);
            this.phoneNumberTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.phoneNumberTextBox.TabIndex = 14;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(37, 163);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(160, 38);
            this.guna2HtmlLabel1.TabIndex = 13;
            this.guna2HtmlLabel1.Text = "Số điện thoại";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(37, 230);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(160, 38);
            this.guna2HtmlLabel2.TabIndex = 15;
            this.guna2HtmlLabel2.Text = "Phòng";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(37, 355);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(160, 38);
            this.guna2HtmlLabel3.TabIndex = 17;
            this.guna2HtmlLabel3.Text = "Thời gian bắt đầu";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(37, 416);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(160, 38);
            this.guna2HtmlLabel4.TabIndex = 20;
            this.guna2HtmlLabel4.Text = "Thời gian kết thúc";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BorderRadius = 8;
            this.confirmBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.confirmBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.confirmBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.confirmBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.confirmBtn.ForeColor = System.Drawing.Color.White;
            this.confirmBtn.Location = new System.Drawing.Point(393, 550);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(120, 38);
            this.confirmBtn.TabIndex = 22;
            this.confirmBtn.Text = "Xác nhận";
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BorderRadius = 8;
            this.closeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(253, 550);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(120, 38);
            this.closeBtn.TabIndex = 23;
            this.closeBtn.Text = "Hủy";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceTextBox.DefaultText = "";
            this.priceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceTextBox.Enabled = false;
            this.priceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.priceTextBox.ForeColor = System.Drawing.Color.Black;
            this.priceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceTextBox.Location = new System.Drawing.Point(221, 294);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.PasswordChar = '\0';
            this.priceTextBox.PlaceholderText = "";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.SelectedText = "";
            this.priceTextBox.Size = new System.Drawing.Size(293, 38);
            this.priceTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.priceTextBox.TabIndex = 25;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(37, 294);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(160, 38);
            this.guna2HtmlLabel5.TabIndex = 24;
            this.guna2HtmlLabel5.Text = "Giá";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roomTextBox
            // 
            this.roomTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.roomTextBox.DefaultText = "";
            this.roomTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.roomTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.roomTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.roomTextBox.Enabled = false;
            this.roomTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.roomTextBox.ForeColor = System.Drawing.Color.Black;
            this.roomTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.roomTextBox.Location = new System.Drawing.Point(221, 230);
            this.roomTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roomTextBox.Name = "roomTextBox";
            this.roomTextBox.PasswordChar = '\0';
            this.roomTextBox.PlaceholderText = "";
            this.roomTextBox.ReadOnly = true;
            this.roomTextBox.SelectedText = "";
            this.roomTextBox.Size = new System.Drawing.Size(293, 38);
            this.roomTextBox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.roomTextBox.TabIndex = 26;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeStart.Location = new System.Drawing.Point(221, 366);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeStart.MaximumSize = new System.Drawing.Size(500, 40);
            this.dateTimeStart.MinimumSize = new System.Drawing.Size(0, 40);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(292, 40);
            this.dateTimeStart.TabIndex = 27;
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEnd.Location = new System.Drawing.Point(221, 427);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimeEnd.MaximumSize = new System.Drawing.Size(500, 40);
            this.dateTimeEnd.MinimumSize = new System.Drawing.Size(4, 40);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(292, 40);
            this.dateTimeEnd.TabIndex = 28;
            // 
            // EditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 617);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.roomTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.IdLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditOrder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa hóa đơn";
            this.Load += new System.EventHandler(this.EditOrder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox statusComboBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox idTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel statusLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel IdLabel;
        private Guna.UI2.WinForms.Guna2TextBox phoneNumberTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button confirmBtn;
        private Guna.UI2.WinForms.Guna2Button closeBtn;
        private Guna.UI2.WinForms.Guna2TextBox priceTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox roomTextBox;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
    }
}
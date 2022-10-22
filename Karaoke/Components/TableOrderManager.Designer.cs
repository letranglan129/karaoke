
namespace Karaoke.Components
{
    partial class TableOrderManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.actionRightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.editButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.actionLeftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.statusDropdown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.seachTypeBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.list = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.actionRightPanel.SuspendLayout();
            this.actionLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.actionRightPanel);
            this.guna2Panel1.Controls.Add(this.actionLeftPanel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1678, 100);
            this.guna2Panel1.TabIndex = 11;
            // 
            // actionRightPanel
            // 
            this.actionRightPanel.Controls.Add(this.deleteButton);
            this.actionRightPanel.Controls.Add(this.editButton);
            this.actionRightPanel.Controls.Add(this.addButton);
            this.actionRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionRightPanel.Location = new System.Drawing.Point(1193, 0);
            this.actionRightPanel.Name = "actionRightPanel";
            this.actionRightPanel.Size = new System.Drawing.Size(485, 100);
            this.actionRightPanel.TabIndex = 11;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Animated = true;
            this.deleteButton.BorderRadius = 6;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(2, 20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(138, 60);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Xóa";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Animated = true;
            this.editButton.BorderRadius = 6;
            this.editButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(170, 20);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(140, 60);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Sửa";
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Animated = true;
            this.addButton.BorderRadius = 6;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(340, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(140, 60);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Thêm";
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // actionLeftPanel
            // 
            this.actionLeftPanel.Controls.Add(this.statusDropdown);
            this.actionLeftPanel.Controls.Add(this.searchBox);
            this.actionLeftPanel.Controls.Add(this.seachTypeBox);
            this.actionLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.actionLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.actionLeftPanel.Name = "actionLeftPanel";
            this.actionLeftPanel.Size = new System.Drawing.Size(1154, 100);
            this.actionLeftPanel.TabIndex = 10;
            // 
            // statusDropdown
            // 
            this.statusDropdown.BackColor = System.Drawing.Color.Transparent;
            this.statusDropdown.BorderRadius = 6;
            this.statusDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDropdown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusDropdown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusDropdown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.statusDropdown.IntegralHeight = false;
            this.statusDropdown.ItemHeight = 54;
            this.statusDropdown.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa thanh toán",
            "Ðã thanh toán"});
            this.statusDropdown.Location = new System.Drawing.Point(789, 19);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(341, 60);
            this.statusDropdown.StartIndex = 0;
            this.statusDropdown.TabIndex = 7;
            this.statusDropdown.SelectedValueChanged += new System.EventHandler(this.statusDropdown_SelectedValueChanged);
            // 
            // searchBox
            // 
            this.searchBox.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Location = new System.Drawing.Point(12, 19);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "Tìm kiếm theo tên...";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(374, 62);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // seachTypeBox
            // 
            this.seachTypeBox.BackColor = System.Drawing.Color.Transparent;
            this.seachTypeBox.BorderThickness = 0;
            this.seachTypeBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.seachTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seachTypeBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seachTypeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.seachTypeBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.seachTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.seachTypeBox.ItemHeight = 54;
            this.seachTypeBox.Items.AddRange(new object[] {
            "Tên",
            "Số điện thoại",
            "Phòng"});
            this.seachTypeBox.Location = new System.Drawing.Point(379, 20);
            this.seachTypeBox.Name = "seachTypeBox";
            this.seachTypeBox.Size = new System.Drawing.Size(299, 60);
            this.seachTypeBox.StartIndex = 0;
            this.seachTypeBox.TabIndex = 8;
            this.seachTypeBox.SelectedValueChanged += new System.EventHandler(this.seachTypeBox_SelectedValueChanged);
            // 
            // list
            // 
            this.list.AllowUserToAddRows = false;
            this.list.AllowUserToOrderColumns = true;
            this.list.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.list.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list.CausesValidation = false;
            this.list.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.list.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.list.ColumnHeadersHeight = 60;
            this.list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CustomerName,
            this.PhoneNumber,
            this.RoomName,
            this.PriceRoom,
            this.StartDateTime,
            this.EndDateTime,
            this.Fullname,
            this.Status});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list.DefaultCellStyle = dataGridViewCellStyle14;
            this.list.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.list.Location = new System.Drawing.Point(0, 100);
            this.list.Margin = new System.Windows.Forms.Padding(0);
            this.list.Name = "list";
            this.list.ReadOnly = true;
            this.list.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.list.RowHeadersVisible = false;
            this.list.RowHeadersWidth = 320;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.list.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.list.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Menu;
            this.list.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.list.RowTemplate.Height = 60;
            this.list.Size = new System.Drawing.Size(1678, 1184);
            this.list.TabIndex = 12;
            this.list.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.list.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.list.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.SystemColors.Menu;
            this.list.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.list.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.list.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.list.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.list.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.list.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.list.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.list.ThemeStyle.HeaderStyle.Height = 60;
            this.list.ThemeStyle.ReadOnly = true;
            this.list.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.list.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.list.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.list.ThemeStyle.RowsStyle.Height = 60;
            this.list.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Menu;
            this.list.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.list.VirtualMode = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Id.DefaultCellStyle = dataGridViewCellStyle11;
            this.Id.FillWeight = 27.26611F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.CustomerName.DefaultCellStyle = dataGridViewCellStyle12;
            this.CustomerName.FillWeight = 98.54253F;
            this.CustomerName.HeaderText = "Tên";
            this.CustomerName.MinimumWidth = 10;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.FillWeight = 86.00237F;
            this.PhoneNumber.HeaderText = "Số điện thoại";
            this.PhoneNumber.MinimumWidth = 10;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            // 
            // RoomName
            // 
            this.RoomName.DataPropertyName = "Name";
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.RoomName.DefaultCellStyle = dataGridViewCellStyle13;
            this.RoomName.FillWeight = 86.8856F;
            this.RoomName.HeaderText = "Phòng";
            this.RoomName.MinimumWidth = 10;
            this.RoomName.Name = "RoomName";
            this.RoomName.ReadOnly = true;
            // 
            // PriceRoom
            // 
            this.PriceRoom.DataPropertyName = "Giá Phòng";
            this.PriceRoom.FillWeight = 76.02415F;
            this.PriceRoom.HeaderText = "Giá Phòng";
            this.PriceRoom.MinimumWidth = 10;
            this.PriceRoom.Name = "PriceRoom";
            this.PriceRoom.ReadOnly = true;
            // 
            // StartDateTime
            // 
            this.StartDateTime.DataPropertyName = "StartDateTime";
            this.StartDateTime.FillWeight = 87.80984F;
            this.StartDateTime.HeaderText = "Thời gian bắt đầu";
            this.StartDateTime.MinimumWidth = 10;
            this.StartDateTime.Name = "StartDateTime";
            this.StartDateTime.ReadOnly = true;
            // 
            // EndDateTime
            // 
            this.EndDateTime.DataPropertyName = "EndDateTime";
            this.EndDateTime.FillWeight = 91.63942F;
            this.EndDateTime.HeaderText = "Thời gian kết thúc";
            this.EndDateTime.MinimumWidth = 10;
            this.EndDateTime.Name = "EndDateTime";
            this.EndDateTime.ReadOnly = true;
            // 
            // Fullname
            // 
            this.Fullname.DataPropertyName = "Fullname";
            this.Fullname.FillWeight = 61.76881F;
            this.Fullname.HeaderText = "Người thanh toán";
            this.Fullname.MinimumWidth = 10;
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 61.76881F;
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // TableOrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1678, 1282);
            this.Controls.Add(this.list);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableOrderManager";
            this.Text = "TableOrderManager";
            this.guna2Panel1.ResumeLayout(false);
            this.actionRightPanel.ResumeLayout(false);
            this.actionLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel actionRightPanel;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button editButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Panel actionLeftPanel;
        private Guna.UI2.WinForms.Guna2ComboBox statusDropdown;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private Guna.UI2.WinForms.Guna2DataGridView list;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private Guna.UI2.WinForms.Guna2ComboBox seachTypeBox;
    }
}
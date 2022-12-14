
namespace Karaoke.Components
{
    partial class TableRoomManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableRoomManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.actionRightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.editButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.actionLeftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.statusDropdown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.listRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.actionRightPanel.SuspendLayout();
            this.actionLeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.actionRightPanel);
            this.guna2Panel1.Controls.Add(this.actionLeftPanel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(788, 52);
            this.guna2Panel1.TabIndex = 8;
            // 
            // actionRightPanel
            // 
            this.actionRightPanel.Controls.Add(this.deleteButton);
            this.actionRightPanel.Controls.Add(this.editButton);
            this.actionRightPanel.Controls.Add(this.addButton);
            this.actionRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionRightPanel.Location = new System.Drawing.Point(520, 0);
            this.actionRightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.actionRightPanel.Name = "actionRightPanel";
            this.actionRightPanel.Size = new System.Drawing.Size(268, 52);
            this.actionRightPanel.TabIndex = 11;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Animated = true;
            this.deleteButton.BorderRadius = 6;
            this.deleteButton.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.deleteButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(46)))), ((int)(((byte)(35)))));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(1, 10);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(69, 31);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Xóa";
            this.deleteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editButton.Animated = true;
            this.editButton.BorderRadius = 6;
            this.editButton.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.editButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.editButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(86, 10);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(70, 31);
            this.editButton.TabIndex = 7;
            this.editButton.Text = "Sửa";
            this.editButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Animated = true;
            this.addButton.BorderRadius = 6;
            this.addButton.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.addButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(166)))), ((int)(((byte)(104)))));
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(175, 10);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 31);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Thêm";
            this.addButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // actionLeftPanel
            // 
            this.actionLeftPanel.Controls.Add(this.statusDropdown);
            this.actionLeftPanel.Controls.Add(this.searchBox);
            this.actionLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.actionLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.actionLeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.actionLeftPanel.Name = "actionLeftPanel";
            this.actionLeftPanel.Size = new System.Drawing.Size(418, 52);
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
            this.statusDropdown.ItemHeight = 24;
            this.statusDropdown.Items.AddRange(new object[] {
            "Tất cả",
            "Sẵn sàng",
            "Đang có khách",
            "Bẩn",
            "Đang dọn dẹp",
            "Đang sửa chữa",
            "Đặt trước"});
            this.statusDropdown.Location = new System.Drawing.Point(212, 10);
            this.statusDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(173, 30);
            this.statusDropdown.StartIndex = 0;
            this.statusDropdown.TabIndex = 7;
            this.statusDropdown.SelectedValueChanged += new System.EventHandler(this.statusDropdown_SelectedValueChanged);
            // 
            // searchBox
            // 
            this.searchBox.BorderRadius = 6;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Location = new System.Drawing.Point(0, 10);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "Tìm kiếm theo tên...";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(209, 31);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // listRoom
            // 
            this.listRoom.AllowUserToAddRows = false;
            this.listRoom.AllowUserToDeleteRows = false;
            this.listRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.listRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listRoom.CausesValidation = false;
            this.listRoom.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.listRoom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listRoom.ColumnHeadersHeight = 60;
            this.listRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.NameRoom,
            this.Price,
            this.Status});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listRoom.DefaultCellStyle = dataGridViewCellStyle7;
            this.listRoom.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listRoom.Location = new System.Drawing.Point(0, 52);
            this.listRoom.Margin = new System.Windows.Forms.Padding(2);
            this.listRoom.Name = "listRoom";
            this.listRoom.ReadOnly = true;
            this.listRoom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.listRoom.RowHeadersVisible = false;
            this.listRoom.RowHeadersWidth = 320;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listRoom.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.listRoom.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.listRoom.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Menu;
            this.listRoom.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.listRoom.RowTemplate.Height = 48;
            this.listRoom.Size = new System.Drawing.Size(788, 560);
            this.listRoom.TabIndex = 1;
            this.listRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listRoom.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.listRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.SystemColors.Menu;
            this.listRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.listRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listRoom.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.listRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listRoom.ThemeStyle.HeaderStyle.Height = 60;
            this.listRoom.ThemeStyle.ReadOnly = true;
            this.listRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listRoom.ThemeStyle.RowsStyle.Height = 48;
            this.listRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listRoom.VirtualMode = true;
            this.listRoom.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listRoom_ColumnHeaderMouseClick);
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Code.DefaultCellStyle = dataGridViewCellStyle3;
            this.Code.FillWeight = 25.90253F;
            this.Code.HeaderText = "ID";
            this.Code.MinimumWidth = 10;
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // NameRoom
            // 
            this.NameRoom.DataPropertyName = "Name";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.NameRoom.DefaultCellStyle = dataGridViewCellStyle4;
            this.NameRoom.FillWeight = 25.90253F;
            this.NameRoom.HeaderText = "Tên";
            this.NameRoom.MinimumWidth = 10;
            this.NameRoom.Name = "NameRoom";
            this.NameRoom.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.Price.DefaultCellStyle = dataGridViewCellStyle5;
            this.Price.FillWeight = 25.90253F;
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 10;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.Status.DefaultCellStyle = dataGridViewCellStyle6;
            this.Status.FillWeight = 25.90253F;
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 10;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // TableRoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(788, 573);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.listRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TableRoomManager";
            this.Text = "TableManager";
            this.guna2Panel1.ResumeLayout(false);
            this.actionRightPanel.ResumeLayout(false);
            this.actionLeftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listRoom)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView listRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
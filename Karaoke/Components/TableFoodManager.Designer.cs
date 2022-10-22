
namespace Karaoke.Components
{
    partial class TableFoodManager
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
            this.list = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.actionRightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.editButton = new Guna.UI2.WinForms.Guna2Button();
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.actionLeftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.statusDropdown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.actionRightPanel.SuspendLayout();
            this.actionLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.AllowUserToAddRows = false;
            this.list.AllowUserToDeleteRows = false;
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
            this.NameFood,
            this.Price,
            this.Type});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.list.DefaultCellStyle = dataGridViewCellStyle14;
            this.list.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.list.Location = new System.Drawing.Point(0, 100);
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
            dataGridViewCellStyle16.Format = "g";
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.list.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.list.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.list.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(4, 6, 2, 6);
            this.list.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Menu;
            this.list.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.list.RowTemplate.Height = 48;
            this.list.Size = new System.Drawing.Size(1783, 1139);
            this.list.TabIndex = 9;
            this.list.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.list.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.list.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.SystemColors.Menu;
            this.list.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.list.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.list.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.list.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.list.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.list.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.list.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.list.ThemeStyle.HeaderStyle.Height = 60;
            this.list.ThemeStyle.ReadOnly = true;
            this.list.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.list.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.list.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.list.ThemeStyle.RowsStyle.Height = 48;
            this.list.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.list.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.list.VirtualMode = true;
            this.list.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listRoom_ColumnHeaderMouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.Id.DefaultCellStyle = dataGridViewCellStyle11;
            this.Id.FillWeight = 25.90253F;
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 10;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // NameFood
            // 
            this.NameFood.DataPropertyName = "Name";
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.NameFood.DefaultCellStyle = dataGridViewCellStyle12;
            this.NameFood.FillWeight = 25.90253F;
            this.NameFood.HeaderText = "Tên";
            this.NameFood.MinimumWidth = 10;
            this.NameFood.Name = "NameFood";
            this.NameFood.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.Price.DefaultCellStyle = dataGridViewCellStyle13;
            this.Price.FillWeight = 25.90253F;
            this.Price.HeaderText = "Giá";
            this.Price.MinimumWidth = 10;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Loại";
            this.Type.MinimumWidth = 10;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.actionRightPanel);
            this.guna2Panel1.Controls.Add(this.actionLeftPanel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1783, 100);
            this.guna2Panel1.TabIndex = 10;
            // 
            // actionRightPanel
            // 
            this.actionRightPanel.Controls.Add(this.deleteButton);
            this.actionRightPanel.Controls.Add(this.editButton);
            this.actionRightPanel.Controls.Add(this.addButton);
            this.actionRightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.actionRightPanel.Location = new System.Drawing.Point(1298, 0);
            this.actionRightPanel.Name = "actionRightPanel";
            this.actionRightPanel.Size = new System.Drawing.Size(485, 100);
            this.actionRightPanel.TabIndex = 11;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Animated = true;
            this.deleteButton.BorderRadius = 6;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(46)))), ((int)(((byte)(35)))));
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.ImageSize = new System.Drawing.Size(40, 40);
            this.deleteButton.Location = new System.Drawing.Point(2, 20);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(138, 60);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Xóa";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Animated = true;
            this.editButton.BorderRadius = 6;
            this.editButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.editButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.editButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.editButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(110)))), ((int)(((byte)(254)))));
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
            this.addButton.Animated = true;
            this.addButton.BorderRadius = 6;
            this.addButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(166)))), ((int)(((byte)(104)))));
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
            this.actionLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.actionLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.actionLeftPanel.Name = "actionLeftPanel";
            this.actionLeftPanel.Size = new System.Drawing.Size(836, 100);
            this.actionLeftPanel.TabIndex = 10;
            // 
            // statusDropdown
            // 
            this.statusDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusDropdown.BackColor = System.Drawing.Color.Transparent;
            this.statusDropdown.BorderRadius = 6;
            this.statusDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusDropdown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusDropdown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.statusDropdown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.statusDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.statusDropdown.IntegralHeight = false;
            this.statusDropdown.ItemHeight = 32;
            this.statusDropdown.Items.AddRange(new object[] {
            "Tất cả",
            "Nước giải khát",
            "Thức ăn"});
            this.statusDropdown.Location = new System.Drawing.Point(441, 20);
            this.statusDropdown.Name = "statusDropdown";
            this.statusDropdown.Size = new System.Drawing.Size(341, 38);
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
            this.searchBox.Location = new System.Drawing.Point(0, 20);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "Tìm kiếm theo tên...";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(419, 60);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // TableFoodManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1783, 1240);
            this.Controls.Add(this.list);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableFoodManager";
            this.Text = "TableFoodManager";
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.actionRightPanel.ResumeLayout(false);
            this.actionLeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView list;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel actionRightPanel;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private Guna.UI2.WinForms.Guna2Button editButton;
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Panel actionLeftPanel;
        private Guna.UI2.WinForms.Guna2ComboBox statusDropdown;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}
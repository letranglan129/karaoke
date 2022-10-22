
namespace Karaoke.Components
{
    partial class Manager
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
            this.tabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.roomTab = new System.Windows.Forms.TabPage();
            this.foodTab = new System.Windows.Forms.TabPage();
            this.orderTab = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.roomTab);
            this.tabControl.Controls.Add(this.foodTab);
            this.tabControl.Controls.Add(this.orderTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(320, 48);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1713, 1300);
            this.tabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.tabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.tabControl.TabButtonSize = new System.Drawing.Size(320, 48);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // roomTab
            // 
            this.roomTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.roomTab.Location = new System.Drawing.Point(4, 52);
            this.roomTab.Margin = new System.Windows.Forms.Padding(0);
            this.roomTab.Name = "roomTab";
            this.roomTab.Size = new System.Drawing.Size(1705, 1244);
            this.roomTab.TabIndex = 0;
            this.roomTab.Text = "Quản lý phòng";
            // 
            // foodTab
            // 
            this.foodTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.foodTab.Location = new System.Drawing.Point(4, 52);
            this.foodTab.Name = "foodTab";
            this.foodTab.Padding = new System.Windows.Forms.Padding(3);
            this.foodTab.Size = new System.Drawing.Size(2733, 2024);
            this.foodTab.TabIndex = 1;
            this.foodTab.Text = "Quản lý thức ăn";
            // 
            // orderTab
            // 
            this.orderTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.orderTab.Location = new System.Drawing.Point(4, 52);
            this.orderTab.Margin = new System.Windows.Forms.Padding(0);
            this.orderTab.Name = "orderTab";
            this.orderTab.Size = new System.Drawing.Size(2733, 2024);
            this.orderTab.TabIndex = 2;
            this.orderTab.Text = "Quản lý hóa đơn";
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1713, 1300);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private System.Windows.Forms.TabPage foodTab;
        private System.Windows.Forms.TabPage roomTab;
        private System.Windows.Forms.TabPage orderTab;
    }
}
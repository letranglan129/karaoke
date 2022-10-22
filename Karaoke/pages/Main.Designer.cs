
namespace Karaoke.pages
{
    partial class Main
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
            this.homeTabContainer = new System.Windows.Forms.TabPage();
            this.managerTabContainer = new System.Windows.Forms.TabPage();
            this.userManagerTabContainer = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.homeTabContainer);
            this.tabControl.Controls.Add(this.managerTabContainer);
            this.tabControl.Controls.Add(this.userManagerTabContainer);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ItemSize = new System.Drawing.Size(320, 60);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1711, 922);
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
            this.tabControl.TabButtonSize = new System.Drawing.Size(320, 60);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
            // 
            // homeTabContainer
            // 
            this.homeTabContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.homeTabContainer.Location = new System.Drawing.Point(324, 4);
            this.homeTabContainer.Margin = new System.Windows.Forms.Padding(0);
            this.homeTabContainer.Name = "homeTabContainer";
            this.homeTabContainer.Size = new System.Drawing.Size(1383, 914);
            this.homeTabContainer.TabIndex = 0;
            this.homeTabContainer.Text = "Trang chủ";
            // 
            // managerTabContainer
            // 
            this.managerTabContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.managerTabContainer.Location = new System.Drawing.Point(324, 4);
            this.managerTabContainer.Margin = new System.Windows.Forms.Padding(0);
            this.managerTabContainer.Name = "managerTabContainer";
            this.managerTabContainer.Size = new System.Drawing.Size(1383, 914);
            this.managerTabContainer.TabIndex = 1;
            this.managerTabContainer.Text = "Quản lý";
            // 
            // userManagerTabContainer
            // 
            this.userManagerTabContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.userManagerTabContainer.Location = new System.Drawing.Point(324, 4);
            this.userManagerTabContainer.Name = "userManagerTabContainer";
            this.userManagerTabContainer.Size = new System.Drawing.Size(1383, 914);
            this.userManagerTabContainer.TabIndex = 2;
            this.userManagerTabContainer.Text = "Quản trị";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1711, 922);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Quản lý Karaoke";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl tabControl;
        private System.Windows.Forms.TabPage homeTabContainer;
        private System.Windows.Forms.TabPage managerTabContainer;
        private System.Windows.Forms.TabPage userManagerTabContainer;
    }
}


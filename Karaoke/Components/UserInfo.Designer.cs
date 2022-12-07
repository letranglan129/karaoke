
namespace Karaoke.Components
{
    partial class UserInfo
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
            this.viewRoomStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.tittle = new System.Windows.Forms.Label();
            this.homeContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.userTypeValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.phoneNumberValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.userNameValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nameValue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.changeLogout = new Guna.UI2.WinForms.Guna2Button();
            this.changePassword = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.homeContainer.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewRoomStatus
            // 
            this.viewRoomStatus.BackColor = System.Drawing.Color.Transparent;
            this.viewRoomStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewRoomStatus.Location = new System.Drawing.Point(0, 498);
            this.viewRoomStatus.Margin = new System.Windows.Forms.Padding(2);
            this.viewRoomStatus.Name = "viewRoomStatus";
            this.viewRoomStatus.Size = new System.Drawing.Size(778, 42);
            this.viewRoomStatus.TabIndex = 1;
            // 
            // tittle
            // 
            this.tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.Color.White;
            this.tittle.Location = new System.Drawing.Point(0, 0);
            this.tittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(660, 42);
            this.tittle.TabIndex = 2;
            this.tittle.Text = "Thông tin tài khoản";
            this.tittle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // homeContainer
            // 
            this.homeContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeContainer.AutoScroll = true;
            this.homeContainer.BackColor = System.Drawing.Color.Transparent;
            this.homeContainer.Controls.Add(this.guna2Panel1);
            this.homeContainer.Location = new System.Drawing.Point(0, 42);
            this.homeContainer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 42);
            this.homeContainer.Name = "homeContainer";
            this.homeContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 42);
            this.homeContainer.Size = new System.Drawing.Size(778, 457);
            this.homeContainer.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.userTypeValue);
            this.guna2Panel1.Controls.Add(this.phoneNumberValue);
            this.guna2Panel1.Controls.Add(this.userNameValue);
            this.guna2Panel1.Controls.Add(this.nameValue);
            this.guna2Panel1.Controls.Add(this.changeLogout);
            this.guna2Panel1.Controls.Add(this.changePassword);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(763, 448);
            this.guna2Panel1.TabIndex = 0;
            // 
            // userTypeValue
            // 
            this.userTypeValue.BackColor = System.Drawing.Color.Transparent;
            this.userTypeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeValue.ForeColor = System.Drawing.Color.White;
            this.userTypeValue.Location = new System.Drawing.Point(561, 100);
            this.userTypeValue.Margin = new System.Windows.Forms.Padding(1);
            this.userTypeValue.Name = "userTypeValue";
            this.userTypeValue.Size = new System.Drawing.Size(49, 22);
            this.userTypeValue.TabIndex = 27;
            this.userTypeValue.Text = "Quyền";
            // 
            // phoneNumberValue
            // 
            this.phoneNumberValue.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberValue.ForeColor = System.Drawing.Color.White;
            this.phoneNumberValue.Location = new System.Drawing.Point(561, 33);
            this.phoneNumberValue.Margin = new System.Windows.Forms.Padding(1);
            this.phoneNumberValue.Name = "phoneNumberValue";
            this.phoneNumberValue.Size = new System.Drawing.Size(96, 22);
            this.phoneNumberValue.TabIndex = 26;
            this.phoneNumberValue.Text = "Số điện thoại";
            // 
            // userNameValue
            // 
            this.userNameValue.BackColor = System.Drawing.Color.Transparent;
            this.userNameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameValue.ForeColor = System.Drawing.Color.White;
            this.userNameValue.Location = new System.Drawing.Point(182, 100);
            this.userNameValue.Margin = new System.Windows.Forms.Padding(1);
            this.userNameValue.Name = "userNameValue";
            this.userNameValue.Size = new System.Drawing.Size(110, 22);
            this.userNameValue.TabIndex = 25;
            this.userNameValue.Text = "Tên đăng nhập";
            // 
            // nameValue
            // 
            this.nameValue.BackColor = System.Drawing.Color.Transparent;
            this.nameValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameValue.ForeColor = System.Drawing.Color.White;
            this.nameValue.Location = new System.Drawing.Point(182, 33);
            this.nameValue.Margin = new System.Windows.Forms.Padding(1);
            this.nameValue.Name = "nameValue";
            this.nameValue.Size = new System.Drawing.Size(102, 22);
            this.nameValue.TabIndex = 24;
            this.nameValue.Text = "Tên nhân viên";
            // 
            // changeLogout
            // 
            this.changeLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeLogout.Animated = true;
            this.changeLogout.BorderRadius = 6;
            this.changeLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(46)))), ((int)(((byte)(35)))));
            this.changeLogout.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.changeLogout.ForeColor = System.Drawing.Color.White;
            this.changeLogout.Location = new System.Drawing.Point(35, 169);
            this.changeLogout.Margin = new System.Windows.Forms.Padding(2);
            this.changeLogout.Name = "changeLogout";
            this.changeLogout.Size = new System.Drawing.Size(179, 41);
            this.changeLogout.TabIndex = 21;
            this.changeLogout.Text = "Đăng xuất";
            this.changeLogout.Click += new System.EventHandler(this.changeLogout_Click);
            // 
            // changePassword
            // 
            this.changePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changePassword.Animated = true;
            this.changePassword.BorderRadius = 6;
            this.changePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(166)))), ((int)(((byte)(104)))));
            this.changePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePassword.ForeColor = System.Drawing.Color.White;
            this.changePassword.Location = new System.Drawing.Point(228, 169);
            this.changePassword.Margin = new System.Windows.Forms.Padding(2);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(153, 41);
            this.changePassword.TabIndex = 20;
            this.changePassword.Text = "Đổi mật khẩu";
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(416, 100);
            this.guna2HtmlLabel6.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(53, 22);
            this.guna2HtmlLabel6.TabIndex = 23;
            this.guna2HtmlLabel6.Text = "Quyền:";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(416, 33);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(100, 22);
            this.guna2HtmlLabel5.TabIndex = 22;
            this.guna2HtmlLabel5.Text = "Số điện thoại:";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(35, 100);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(114, 22);
            this.guna2HtmlLabel2.TabIndex = 16;
            this.guna2HtmlLabel2.Text = "Tên đăng nhập:";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(35, 33);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(1);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(106, 22);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "Tên nhân viên:";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(778, 540);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.viewRoomStatus);
            this.Controls.Add(this.homeContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserInfo";
            this.Text = "Home";
            this.homeContainer.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel viewRoomStatus;
        private System.Windows.Forms.Label tittle;
        private System.Windows.Forms.FlowLayoutPanel homeContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button changeLogout;
        private Guna.UI2.WinForms.Guna2Button changePassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel userTypeValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel phoneNumberValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel userNameValue;
        private Guna.UI2.WinForms.Guna2HtmlLabel nameValue;
    }
}
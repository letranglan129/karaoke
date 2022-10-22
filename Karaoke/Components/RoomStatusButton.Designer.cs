
namespace Karaoke.Components
{
    partial class RoomStatusButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new Guna.UI2.WinForms.Guna2Button();
            this.lineButton = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button.FillColor = System.Drawing.Color.White;
            this.button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button.ForeColor = System.Drawing.Color.Black;
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Margin = new System.Windows.Forms.Padding(0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(1038, 80);
            this.button.TabIndex = 0;
            this.button.Text = "Phòng trống";
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // lineButton
            // 
            this.lineButton.BackColor = System.Drawing.Color.Maroon;
            this.lineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.lineButton.Location = new System.Drawing.Point(0, 0);
            this.lineButton.Margin = new System.Windows.Forms.Padding(0);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(10, 80);
            this.lineButton.TabIndex = 1;
            // 
            // RoomStatusButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.button);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 16, 0);
            this.Name = "RoomStatusButton";
            this.Size = new System.Drawing.Size(1038, 80);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel lineButton;
        private Guna.UI2.WinForms.Guna2Button button;
    }
}

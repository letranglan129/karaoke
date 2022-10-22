
namespace Karaoke.Components
{
    partial class Home
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
            this.homeContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.viewRoomStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.tittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // homeContainer
            // 
            this.homeContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeContainer.AutoScroll = true;
            this.homeContainer.BackColor = System.Drawing.Color.Transparent;
            this.homeContainer.Location = new System.Drawing.Point(0, 80);
            this.homeContainer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 80);
            this.homeContainer.Name = "homeContainer";
            this.homeContainer.Padding = new System.Windows.Forms.Padding(0, 0, 0, 80);
            this.homeContainer.Size = new System.Drawing.Size(1557, 879);
            this.homeContainer.TabIndex = 0;
            // 
            // viewRoomStatus
            // 
            this.viewRoomStatus.BackColor = System.Drawing.Color.Transparent;
            this.viewRoomStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.viewRoomStatus.Location = new System.Drawing.Point(0, 958);
            this.viewRoomStatus.Name = "viewRoomStatus";
            this.viewRoomStatus.Size = new System.Drawing.Size(1557, 80);
            this.viewRoomStatus.TabIndex = 1;
            // 
            // tittle
            // 
            this.tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tittle.ForeColor = System.Drawing.Color.White;
            this.tittle.Location = new System.Drawing.Point(0, 0);
            this.tittle.Name = "tittle";
            this.tittle.Size = new System.Drawing.Size(1320, 80);
            this.tittle.TabIndex = 2;
            this.tittle.Text = "Tất cả";
            this.tittle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1557, 1038);
            this.Controls.Add(this.tittle);
            this.Controls.Add(this.viewRoomStatus);
            this.Controls.Add(this.homeContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel homeContainer;
        private System.Windows.Forms.FlowLayoutPanel viewRoomStatus;
        private System.Windows.Forms.Label tittle;
    }
}
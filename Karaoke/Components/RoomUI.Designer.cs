
namespace Karaoke.Components
{
    partial class RoomUI
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
            this.components = new System.ComponentModel.Container();
            this.nameRoom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.statusRoom = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.price = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // nameRoom
            // 
            this.nameRoom.AutoSize = false;
            this.nameRoom.BackColor = System.Drawing.Color.Transparent;
            this.nameRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameRoom.ForeColor = System.Drawing.Color.White;
            this.nameRoom.Location = new System.Drawing.Point(10, 10);
            this.nameRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nameRoom.Name = "nameRoom";
            this.nameRoom.Size = new System.Drawing.Size(140, 30);
            this.nameRoom.TabIndex = 0;
            this.nameRoom.Text = "Tên phòng";
            this.nameRoom.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusRoom
            // 
            this.statusRoom.AutoSize = false;
            this.statusRoom.BackColor = System.Drawing.Color.Transparent;
            this.statusRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusRoom.ForeColor = System.Drawing.Color.White;
            this.statusRoom.Location = new System.Drawing.Point(10, 40);
            this.statusRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusRoom.Name = "statusRoom";
            this.statusRoom.Size = new System.Drawing.Size(140, 29);
            this.statusRoom.TabIndex = 1;
            this.statusRoom.Text = "Tình trạng phòng";
            this.statusRoom.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // price
            // 
            this.price.AutoSize = false;
            this.price.BackColor = System.Drawing.Color.Transparent;
            this.price.Dock = System.Windows.Forms.DockStyle.Top;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.White;
            this.price.Location = new System.Drawing.Point(10, 69);
            this.price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(140, 32);
            this.price.TabIndex = 3;
            this.price.Text = "Giá: 120000";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // RoomUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(184)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.price);
            this.Controls.Add(this.statusRoom);
            this.Controls.Add(this.nameRoom);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Name = "RoomUI";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.Size = new System.Drawing.Size(160, 166);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel nameRoom;
        private Guna.UI2.WinForms.Guna2HtmlLabel statusRoom;
        private Guna.UI2.WinForms.Guna2HtmlLabel price;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

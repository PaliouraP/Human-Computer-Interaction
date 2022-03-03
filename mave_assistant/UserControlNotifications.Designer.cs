
namespace mave_assistant
{
    partial class UserControlNotifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlNotifications));
            this.title = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.details = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(7, 15);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(81, 23);
            this.title.TabIndex = 0;
            this.title.Text = "notif_title";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(243, 13);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 38;
            this.pictureBox9.TabStop = false;
            // 
            // details
            // 
            this.details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.details.Location = new System.Drawing.Point(7, 41);
            this.details.Multiline = true;
            this.details.Name = "details";
            this.details.ReadOnly = true;
            this.details.Size = new System.Drawing.Size(223, 67);
            this.details.TabIndex = 39;
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Location = new System.Drawing.Point(215, 17);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(18, 20);
            this.delete.TabIndex = 40;
            this.delete.Text = "X";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // UserControlNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.details);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.title);
            this.Name = "UserControlNotifications";
            this.Size = new System.Drawing.Size(243, 113);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.TextBox details;
        private System.Windows.Forms.Label delete;
    }
}

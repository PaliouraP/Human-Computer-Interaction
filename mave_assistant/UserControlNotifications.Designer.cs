
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
            this.details = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(22, 15);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(95, 28);
            this.title.TabIndex = 0;
            this.title.Text = "notif_title";
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.details.Location = new System.Drawing.Point(22, 55);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(90, 20);
            this.details.TabIndex = 1;
            this.details.Text = "notif_details";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(254, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 38;
            this.pictureBox9.TabStop = false;
            // 
            // UserControlNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.details);
            this.Controls.Add(this.title);
            this.Name = "UserControlNotifications";
            this.Size = new System.Drawing.Size(243, 105);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label details;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}

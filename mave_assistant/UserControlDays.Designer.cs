
namespace mave_assistant
{
    partial class UserControlDays
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
            this.days_label = new System.Windows.Forms.Label();
            this.dot4 = new System.Windows.Forms.PictureBox();
            this.dot3 = new System.Windows.Forms.PictureBox();
            this.dot2 = new System.Windows.Forms.PictureBox();
            this.dot1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot1)).BeginInit();
            this.SuspendLayout();
            // 
            // days_label
            // 
            this.days_label.AutoSize = true;
            this.days_label.Location = new System.Drawing.Point(8, 6);
            this.days_label.Name = "days_label";
            this.days_label.Size = new System.Drawing.Size(25, 20);
            this.days_label.TabIndex = 0;
            this.days_label.Text = "00";
            // 
            // dot4
            // 
            this.dot4.Location = new System.Drawing.Point(118, 6);
            this.dot4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dot4.Name = "dot4";
            this.dot4.Size = new System.Drawing.Size(17, 20);
            this.dot4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dot4.TabIndex = 38;
            this.dot4.TabStop = false;
            // 
            // dot3
            // 
            this.dot3.Location = new System.Drawing.Point(95, 6);
            this.dot3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dot3.Name = "dot3";
            this.dot3.Size = new System.Drawing.Size(17, 20);
            this.dot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dot3.TabIndex = 37;
            this.dot3.TabStop = false;
            // 
            // dot2
            // 
            this.dot2.Location = new System.Drawing.Point(72, 6);
            this.dot2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dot2.Name = "dot2";
            this.dot2.Size = new System.Drawing.Size(17, 20);
            this.dot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dot2.TabIndex = 36;
            this.dot2.TabStop = false;
            // 
            // dot1
            // 
            this.dot1.Location = new System.Drawing.Point(49, 6);
            this.dot1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dot1.Name = "dot1";
            this.dot1.Size = new System.Drawing.Size(17, 20);
            this.dot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dot1.TabIndex = 35;
            this.dot1.TabStop = false;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dot4);
            this.Controls.Add(this.dot3);
            this.Controls.Add(this.dot2);
            this.Controls.Add(this.dot1);
            this.Controls.Add(this.days_label);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(150, 100);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dot1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label days_label;
        public System.Windows.Forms.PictureBox dot4;
        public System.Windows.Forms.PictureBox dot3;
        public System.Windows.Forms.PictureBox dot2;
        public System.Windows.Forms.PictureBox dot1;
    }
}

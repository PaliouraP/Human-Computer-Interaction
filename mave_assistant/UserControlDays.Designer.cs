
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
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.days_label);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(150, 100);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label days_label;
    }
}

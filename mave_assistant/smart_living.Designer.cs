
namespace mave_assistant
{
    partial class smart_living
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
            this.smart_home_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // smart_home_label
            // 
            this.smart_home_label.AutoSize = true;
            this.smart_home_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.smart_home_label.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.smart_home_label.Location = new System.Drawing.Point(3, 9);
            this.smart_home_label.Name = "smart_home_label";
            this.smart_home_label.Size = new System.Drawing.Size(196, 45);
            this.smart_home_label.TabIndex = 15;
            this.smart_home_label.Text = "Smart Living";
            // 
            // smart_living
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(965, 637);
            this.Controls.Add(this.smart_home_label);
            this.Name = "smart_living";
            this.Text = "smart_living";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label smart_home_label;
    }
}
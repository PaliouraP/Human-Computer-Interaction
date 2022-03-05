
namespace mave_assistant
{
    partial class home_screen_events
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
            this.details = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.dot = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.details.Location = new System.Drawing.Point(43, 3);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(43, 17);
            this.details.TabIndex = 44;
            this.details.Text = "label2";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type.Location = new System.Drawing.Point(123, 3);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(43, 17);
            this.type.TabIndex = 43;
            this.type.Text = "label1";
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(20, 3);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(17, 17);
            this.dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dot.TabIndex = 42;
            this.dot.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::mave_assistant.Properties.Resources.line;
            this.pictureBox10.Location = new System.Drawing.Point(3, 23);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(218, 10);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 61;
            this.pictureBox10.TabStop = false;
            // 
            // home_screen_events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.details);
            this.Controls.Add(this.type);
            this.Controls.Add(this.dot);
            this.Name = "home_screen_events";
            this.Size = new System.Drawing.Size(206, 31);
            ((System.ComponentModel.ISupportInitialize)(this.dot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label details;
        public System.Windows.Forms.Label type;
        public System.Windows.Forms.PictureBox dot;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}

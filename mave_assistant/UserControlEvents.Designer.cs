
namespace mave_assistant
{
    partial class UserControlEvents
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
            this.dot = new System.Windows.Forms.PictureBox();
            this.type = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dot)).BeginInit();
            this.SuspendLayout();
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(9, 22);
            this.dot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(17, 20);
            this.dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dot.TabIndex = 39;
            this.dot.TabStop = false;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(49, 22);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(50, 20);
            this.type.TabIndex = 40;
            this.type.Text = "label1";
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Location = new System.Drawing.Point(150, 22);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(50, 20);
            this.details.TabIndex = 41;
            this.details.Text = "label2";
            // 
            // UserControlEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.details);
            this.Controls.Add(this.type);
            this.Controls.Add(this.dot);
            this.Name = "UserControlEvents";
            this.Size = new System.Drawing.Size(278, 48);
            ((System.ComponentModel.ISupportInitialize)(this.dot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox dot;
        public System.Windows.Forms.Label type;
        public System.Windows.Forms.Label details;
    }
}

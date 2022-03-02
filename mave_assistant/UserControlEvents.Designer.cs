
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
            this.date = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.CheckBox();
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
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(236, 22);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(39, 20);
            this.date.TabIndex = 42;
            this.date.Text = "date";
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.delete.Location = new System.Drawing.Point(396, 0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(18, 48);
            this.delete.TabIndex = 43;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.CheckedChanged += new System.EventHandler(this.delete_CheckedChanged);
            // 
            // UserControlEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.delete);
            this.Controls.Add(this.date);
            this.Controls.Add(this.details);
            this.Controls.Add(this.type);
            this.Controls.Add(this.dot);
            this.Name = "UserControlEvents";
            this.Size = new System.Drawing.Size(414, 48);
            ((System.ComponentModel.ISupportInitialize)(this.dot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox dot;
        public System.Windows.Forms.Label type;
        public System.Windows.Forms.Label details;
        public System.Windows.Forms.Label date;
        public System.Windows.Forms.CheckBox delete;
    }
}

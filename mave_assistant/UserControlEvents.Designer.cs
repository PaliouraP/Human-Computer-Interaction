
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
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(3, 3);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(20, 20);
            this.dot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dot.TabIndex = 39;
            this.dot.TabStop = false;
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type.Location = new System.Drawing.Point(135, 6);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(43, 17);
            this.type.TabIndex = 40;
            this.type.Text = "label1";
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.details.Location = new System.Drawing.Point(45, 6);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(43, 17);
            this.details.TabIndex = 41;
            this.details.Text = "label2";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.Location = new System.Drawing.Point(45, 27);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(34, 17);
            this.date.TabIndex = 42;
            this.date.Text = "date";
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.delete.Location = new System.Drawing.Point(243, 0);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(15, 60);
            this.delete.TabIndex = 43;
            this.delete.UseVisualStyleBackColor = true;
            this.delete.CheckedChanged += new System.EventHandler(this.delete_CheckedChanged);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = global::mave_assistant.Properties.Resources.line;
            this.pictureBox10.Location = new System.Drawing.Point(0, 47);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(269, 10);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 60;
            this.pictureBox10.TabStop = false;
            // 
            // UserControlEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.date);
            this.Controls.Add(this.details);
            this.Controls.Add(this.type);
            this.Controls.Add(this.dot);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserControlEvents";
            this.Size = new System.Drawing.Size(258, 60);
            this.Load += new System.EventHandler(this.UserControlEvents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox dot;
        public System.Windows.Forms.Label type;
        public System.Windows.Forms.Label details;
        public System.Windows.Forms.Label date;
        public System.Windows.Forms.CheckBox delete;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}

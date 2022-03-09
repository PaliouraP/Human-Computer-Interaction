
namespace mave_assistant
{
    partial class planner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(planner));
            this.digital_planner_label = new System.Windows.Forms.Label();
            this.day_container = new System.Windows.Forms.FlowLayoutPanel();
            this.add_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prev_btn = new System.Windows.Forms.PictureBox();
            this.next_btn = new System.Windows.Forms.PictureBox();
            this.month_year_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prev_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // digital_planner_label
            // 
            this.digital_planner_label.AutoSize = true;
            this.digital_planner_label.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.digital_planner_label.Location = new System.Drawing.Point(3, 9);
            this.digital_planner_label.Name = "digital_planner_label";
            this.digital_planner_label.Size = new System.Drawing.Size(227, 45);
            this.digital_planner_label.TabIndex = 15;
            this.digital_planner_label.Text = "Digital Planner";
            // 
            // day_container
            // 
            this.day_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.day_container.Location = new System.Drawing.Point(8, 151);
            this.day_container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.day_container.Name = "day_container";
            this.day_container.Size = new System.Drawing.Size(960, 479);
            this.day_container.TabIndex = 16;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_btn.Location = new System.Drawing.Point(709, 634);
            this.add_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(118, 40);
            this.add_btn.TabIndex = 0;
            this.add_btn.Text = "Add Event";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.del_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.del_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.del_btn.Location = new System.Drawing.Point(850, 634);
            this.del_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(118, 40);
            this.del_btn.TabIndex = 27;
            this.del_btn.Text = "Delete Event";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Sunday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(188, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Monday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(323, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tuesday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(450, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Wednesday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(591, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Thursday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(732, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Friday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(869, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Saturday";
            // 
            // prev_btn
            // 
            this.prev_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prev_btn.Image = ((System.Drawing.Image)(resources.GetObject("prev_btn.Image")));
            this.prev_btn.Location = new System.Drawing.Point(261, 59);
            this.prev_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(38, 46);
            this.prev_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.prev_btn.TabIndex = 24;
            this.prev_btn.TabStop = false;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // next_btn
            // 
            this.next_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.next_btn.Image = ((System.Drawing.Image)(resources.GetObject("next_btn.Image")));
            this.next_btn.Location = new System.Drawing.Point(666, 59);
            this.next_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(38, 46);
            this.next_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.next_btn.TabIndex = 25;
            this.next_btn.TabStop = false;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // month_year_label
            // 
            this.month_year_label.AutoSize = true;
            this.month_year_label.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.month_year_label.Location = new System.Drawing.Point(370, 59);
            this.month_year_label.Name = "month_year_label";
            this.month_year_label.Size = new System.Drawing.Size(220, 45);
            this.month_year_label.TabIndex = 26;
            this.month_year_label.Text = "MONTH YEAR";
            // 
            // planner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(981, 676);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.month_year_label);
            this.Controls.Add(this.next_btn);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.digital_planner_label);
            this.Controls.Add(this.day_container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "planner";
            this.Text = "Digital Planner";
            this.Load += new System.EventHandler(this.planner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prev_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.next_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label digital_planner_label;
        private System.Windows.Forms.FlowLayoutPanel day_container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox prev_btn;
        private System.Windows.Forms.PictureBox next_btn;
        private System.Windows.Forms.Label month_year_label;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button del_btn;
    }
}
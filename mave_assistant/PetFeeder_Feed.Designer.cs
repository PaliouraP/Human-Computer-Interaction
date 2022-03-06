
namespace mave_assistant
{
    partial class PetFeeder_Feed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetFeeder_Feed));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.portion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerFood = new System.Windows.Forms.DateTimePicker();
            this.time_lbl = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.portion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePickerFood);
            this.panel1.Controls.Add(this.time_lbl);
            this.panel1.Location = new System.Drawing.Point(54, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 375);
            this.panel1.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(199, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 53);
            this.button2.TabIndex = 93;
            this.button2.Text = "FEED NOW";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // portion
            // 
            this.portion.DisplayMember = "Home";
            this.portion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portion.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.portion.ForeColor = System.Drawing.Color.DimGray;
            this.portion.FormattingEnabled = true;
            this.portion.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500"});
            this.portion.Location = new System.Drawing.Point(141, 193);
            this.portion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.portion.Name = "portion";
            this.portion.Size = new System.Drawing.Size(130, 28);
            this.portion.TabIndex = 92;
            this.portion.ValueMember = "Home";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.label5.Location = new System.Drawing.Point(89, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 31);
            this.label5.TabIndex = 7;
            this.label5.Text = "Feeding Portion in gr";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(18, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "PROGRAM FEED";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerFood
            // 
            this.dateTimePickerFood.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFood.Location = new System.Drawing.Point(141, 91);
            this.dateTimePickerFood.MinDate = new System.DateTime(2022, 3, 4, 0, 0, 0, 0);
            this.dateTimePickerFood.Name = "dateTimePickerFood";
            this.dateTimePickerFood.ShowUpDown = true;
            this.dateTimePickerFood.Size = new System.Drawing.Size(107, 27);
            this.dateTimePickerFood.TabIndex = 3;
            this.dateTimePickerFood.Value = new System.DateTime(2022, 3, 4, 1, 37, 41, 0);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.Color.Transparent;
            this.time_lbl.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.time_lbl.Location = new System.Drawing.Point(119, 40);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(152, 31);
            this.time_lbl.TabIndex = 0;
            this.time_lbl.Text = "Feeding Time";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(3, -1);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(161, 80);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 60;
            this.logo.TabStop = false;
            // 
            // PetFeeder_Feed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(525, 543);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.panel1);
            this.Name = "PetFeeder_Feed";
            this.Text = "Feed";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox portion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFood;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.PictureBox logo;
    }
}
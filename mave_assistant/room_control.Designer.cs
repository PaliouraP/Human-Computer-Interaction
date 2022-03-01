
namespace mave_assistant
{
    partial class room_control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(room_control));
            this.room_pic = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.celcius = new System.Windows.Forms.Label();
            this.hum_minus = new System.Windows.Forms.PictureBox();
            this.hum_plus = new System.Windows.Forms.PictureBox();
            this.temp_minus = new System.Windows.Forms.PictureBox();
            this.temp_plus = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Humidity = new System.Windows.Forms.Label();
            this.humidity_bar = new CircularProgressBar.CircularProgressBar();
            this.temperature_bar = new CircularProgressBar.CircularProgressBar();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.toggle = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.hydrometers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.room_pic)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hum_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hum_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_minus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            this.SuspendLayout();
            // 
            // room_pic
            // 
            this.room_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.room_pic.Image = global::mave_assistant.Properties.Resources.kitchen;
            this.room_pic.Location = new System.Drawing.Point(12, 11);
            this.room_pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.room_pic.Name = "room_pic";
            this.room_pic.Size = new System.Drawing.Size(397, 272);
            this.room_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.room_pic.TabIndex = 59;
            this.room_pic.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.celcius);
            this.panel4.Controls.Add(this.hum_minus);
            this.panel4.Controls.Add(this.hum_plus);
            this.panel4.Controls.Add(this.temp_minus);
            this.panel4.Controls.Add(this.temp_plus);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.Humidity);
            this.panel4.Controls.Add(this.humidity_bar);
            this.panel4.Controls.Add(this.temperature_bar);
            this.panel4.Controls.Add(this.pictureBox24);
            this.panel4.Controls.Add(this.pictureBox22);
            this.panel4.Controls.Add(this.toggle);
            this.panel4.Controls.Add(this.pictureBox20);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.name_label);
            this.panel4.Controls.Add(this.pictureBox28);
            this.panel4.Controls.Add(this.hydrometers);
            this.panel4.Location = new System.Drawing.Point(12, 287);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 362);
            this.panel4.TabIndex = 60;
            // 
            // celcius
            // 
            this.celcius.AutoSize = true;
            this.celcius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.celcius.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.celcius.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.celcius.Location = new System.Drawing.Point(56, 124);
            this.celcius.Name = "celcius";
            this.celcius.Size = new System.Drawing.Size(73, 32);
            this.celcius.TabIndex = 91;
            this.celcius.Text = "18 °C";
            // 
            // hum_minus
            // 
            this.hum_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.hum_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hum_minus.Image = global::mave_assistant.Properties.Resources.minus;
            this.hum_minus.Location = new System.Drawing.Point(234, 133);
            this.hum_minus.Name = "hum_minus";
            this.hum_minus.Size = new System.Drawing.Size(20, 20);
            this.hum_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hum_minus.TabIndex = 90;
            this.hum_minus.TabStop = false;
            this.hum_minus.Click += new System.EventHandler(this.hum_minus_Click);
            // 
            // hum_plus
            // 
            this.hum_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.hum_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hum_plus.Image = global::mave_assistant.Properties.Resources.plus;
            this.hum_plus.Location = new System.Drawing.Point(339, 133);
            this.hum_plus.Name = "hum_plus";
            this.hum_plus.Size = new System.Drawing.Size(20, 20);
            this.hum_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hum_plus.TabIndex = 89;
            this.hum_plus.TabStop = false;
            this.hum_plus.Click += new System.EventHandler(this.hum_plus_Click);
            // 
            // temp_minus
            // 
            this.temp_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.temp_minus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temp_minus.Image = global::mave_assistant.Properties.Resources.minus;
            this.temp_minus.Location = new System.Drawing.Point(30, 133);
            this.temp_minus.Name = "temp_minus";
            this.temp_minus.Size = new System.Drawing.Size(20, 20);
            this.temp_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.temp_minus.TabIndex = 88;
            this.temp_minus.TabStop = false;
            this.temp_minus.Click += new System.EventHandler(this.temp_minus_Click);
            // 
            // temp_plus
            // 
            this.temp_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.temp_plus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.temp_plus.Image = global::mave_assistant.Properties.Resources.plus;
            this.temp_plus.Location = new System.Drawing.Point(135, 133);
            this.temp_plus.Name = "temp_plus";
            this.temp_plus.Size = new System.Drawing.Size(20, 20);
            this.temp_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.temp_plus.TabIndex = 87;
            this.temp_plus.TabStop = false;
            this.temp_plus.Click += new System.EventHandler(this.temp_plus_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::mave_assistant.Properties.Resources.live_circle;
            this.pictureBox1.Location = new System.Drawing.Point(249, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 85;
            this.label1.Text = "Live Audio";
            // 
            // Humidity
            // 
            this.Humidity.AutoSize = true;
            this.Humidity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.Humidity.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Humidity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Humidity.Location = new System.Drawing.Point(259, 104);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(74, 21);
            this.Humidity.TabIndex = 84;
            this.Humidity.Text = "Humidity";
            // 
            // humidity_bar
            // 
            this.humidity_bar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.humidity_bar.AnimationSpeed = 500;
            this.humidity_bar.BackColor = System.Drawing.Color.Transparent;
            this.humidity_bar.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.humidity_bar.ForeColor = System.Drawing.Color.Silver;
            this.humidity_bar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.humidity_bar.InnerMargin = 1;
            this.humidity_bar.InnerWidth = 10;
            this.humidity_bar.Location = new System.Drawing.Point(234, 158);
            this.humidity_bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.humidity_bar.MarqueeAnimationSpeed = 2000;
            this.humidity_bar.Name = "humidity_bar";
            this.humidity_bar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.humidity_bar.OuterMargin = -40;
            this.humidity_bar.OuterWidth = 40;
            this.humidity_bar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.humidity_bar.ProgressWidth = 40;
            this.humidity_bar.SecondaryFont = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.humidity_bar.Size = new System.Drawing.Size(125, 125);
            this.humidity_bar.StartAngle = 270;
            this.humidity_bar.SubscriptColor = System.Drawing.Color.DimGray;
            this.humidity_bar.SubscriptMargin = new System.Windows.Forms.Padding(-80, -5, 0, 1);
            this.humidity_bar.SubscriptText = "tasks completed";
            this.humidity_bar.SuperscriptColor = System.Drawing.Color.Goldenrod;
            this.humidity_bar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.humidity_bar.SuperscriptText = "";
            this.humidity_bar.TabIndex = 83;
            this.humidity_bar.TextMargin = new System.Windows.Forms.Padding(80, -20, 20, 0);
            this.humidity_bar.Value = 30;
            // 
            // temperature_bar
            // 
            this.temperature_bar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.temperature_bar.AnimationSpeed = 500;
            this.temperature_bar.BackColor = System.Drawing.Color.Transparent;
            this.temperature_bar.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temperature_bar.ForeColor = System.Drawing.Color.Silver;
            this.temperature_bar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.temperature_bar.InnerMargin = 1;
            this.temperature_bar.InnerWidth = 10;
            this.temperature_bar.Location = new System.Drawing.Point(30, 158);
            this.temperature_bar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.temperature_bar.MarqueeAnimationSpeed = 2000;
            this.temperature_bar.Maximum = 30;
            this.temperature_bar.Name = "temperature_bar";
            this.temperature_bar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.temperature_bar.OuterMargin = -40;
            this.temperature_bar.OuterWidth = 40;
            this.temperature_bar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.temperature_bar.ProgressWidth = 40;
            this.temperature_bar.SecondaryFont = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.temperature_bar.Size = new System.Drawing.Size(125, 125);
            this.temperature_bar.StartAngle = 270;
            this.temperature_bar.SubscriptColor = System.Drawing.Color.DimGray;
            this.temperature_bar.SubscriptMargin = new System.Windows.Forms.Padding(-80, -5, 0, 1);
            this.temperature_bar.SubscriptText = "tasks completed";
            this.temperature_bar.SuperscriptColor = System.Drawing.Color.Goldenrod;
            this.temperature_bar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.temperature_bar.SuperscriptText = "";
            this.temperature_bar.TabIndex = 82;
            this.temperature_bar.TextMargin = new System.Windows.Forms.Padding(80, -20, 20, 0);
            this.temperature_bar.Value = 18;
            // 
            // pictureBox24
            // 
            this.pictureBox24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pictureBox24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox24.Image = global::mave_assistant.Properties.Resources.voice;
            this.pictureBox24.Location = new System.Drawing.Point(229, 305);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(156, 24);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 81;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox22.Image = global::mave_assistant.Properties.Resources.line;
            this.pictureBox22.Location = new System.Drawing.Point(17, 90);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(366, 11);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 80;
            this.pictureBox22.TabStop = false;
            // 
            // toggle
            // 
            this.toggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggle.Image = global::mave_assistant.Properties.Resources.toggle_off;
            this.toggle.Location = new System.Drawing.Point(340, 54);
            this.toggle.Name = "toggle";
            this.toggle.Size = new System.Drawing.Size(30, 30);
            this.toggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.toggle.TabIndex = 74;
            this.toggle.TabStop = false;
            this.toggle.Click += new System.EventHandler(this.toggle_Click);
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox20.Image = global::mave_assistant.Properties.Resources.line;
            this.pictureBox20.Location = new System.Drawing.Point(15, 288);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(368, 11);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 79;
            this.pictureBox20.TabStop = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.label22.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(41, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 21);
            this.label22.TabIndex = 68;
            this.label22.Text = "Temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 56;
            this.label4.Text = "Air Condition";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label.Location = new System.Drawing.Point(146, 11);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(106, 23);
            this.name_label.TabIndex = 48;
            this.name_label.Text = "Room Name";
            // 
            // pictureBox28
            // 
            this.pictureBox28.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox28.Image = global::mave_assistant.Properties.Resources.line;
            this.pictureBox28.Location = new System.Drawing.Point(15, 37);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(370, 14);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 49;
            this.pictureBox28.TabStop = false;
            // 
            // hydrometers
            // 
            this.hydrometers.AutoSize = true;
            this.hydrometers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.hydrometers.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hydrometers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hydrometers.Location = new System.Drawing.Point(263, 124);
            this.hydrometers.Name = "hydrometers";
            this.hydrometers.Size = new System.Drawing.Size(70, 32);
            this.hydrometers.TabIndex = 92;
            this.hydrometers.Text = "30 %";
            // 
            // room_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(417, 660);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.room_pic);
            this.Name = "room_control";
            this.Text = "Room Control";
            this.Load += new System.EventHandler(this.room_control_Load);
            ((System.ComponentModel.ISupportInitialize)(this.room_pic)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hum_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hum_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_minus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox room_pic;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox22;
        private System.Windows.Forms.PictureBox toggle;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox pictureBox28;
        private System.Windows.Forms.PictureBox pictureBox24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Humidity;
        private CircularProgressBar.CircularProgressBar humidity_bar;
        private CircularProgressBar.CircularProgressBar temperature_bar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox hum_minus;
        private System.Windows.Forms.PictureBox hum_plus;
        private System.Windows.Forms.PictureBox temp_minus;
        private System.Windows.Forms.PictureBox temp_plus;
        private System.Windows.Forms.Label celcius;
        private System.Windows.Forms.Label hydrometers;
    }
}
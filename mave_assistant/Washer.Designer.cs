
namespace mave_assistant
{
    partial class Washer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Washer));
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BinMessage = new System.Windows.Forms.Label();
            this.progressBar = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.wool_btn = new System.Windows.Forms.Button();
            this.duration_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.spins_lbl = new System.Windows.Forms.Label();
            this.temperature_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.eco_btn = new System.Windows.Forms.Button();
            this.delicate_btn = new System.Windows.Forms.Button();
            this.cotton_lbl = new System.Windows.Forms.Button();
            this.rapid_btn = new System.Windows.Forms.Button();
            this.intense_btn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.time_lbl = new System.Windows.Forms.Label();
            this.pr_lbl = new System.Windows.Forms.Label();
            this.cancel_wash = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Washing Machine";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Location = new System.Drawing.Point(652, 527);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 349);
            this.panel3.TabIndex = 55;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(99, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 30);
            this.label13.TabIndex = 48;
            this.label13.Text = "Energy Consumption";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(34, 61);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(348, 256);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.BinMessage);
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(652, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 381);
            this.panel2.TabIndex = 54;
            // 
            // BinMessage
            // 
            this.BinMessage.AutoSize = true;
            this.BinMessage.BackColor = System.Drawing.Color.Transparent;
            this.BinMessage.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BinMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.BinMessage.Location = new System.Drawing.Point(34, 327);
            this.BinMessage.Name = "BinMessage";
            this.BinMessage.Size = new System.Drawing.Size(348, 28);
            this.BinMessage.TabIndex = 38;
            this.BinMessage.Text = "You should consider adding dish soap!";
            this.BinMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar.AnimationSpeed = 500;
            this.progressBar.BackColor = System.Drawing.Color.Transparent;
            this.progressBar.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.progressBar.ForeColor = System.Drawing.Color.Silver;
            this.progressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.progressBar.InnerMargin = 2;
            this.progressBar.InnerWidth = -1;
            this.progressBar.Location = new System.Drawing.Point(91, 61);
            this.progressBar.MarqueeAnimationSpeed = 2000;
            this.progressBar.Name = "progressBar";
            this.progressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.progressBar.OuterMargin = -25;
            this.progressBar.OuterWidth = 26;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.progressBar.ProgressWidth = 20;
            this.progressBar.SecondaryFont = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.progressBar.Size = new System.Drawing.Size(230, 261);
            this.progressBar.StartAngle = 270;
            this.progressBar.SubscriptColor = System.Drawing.Color.DimGray;
            this.progressBar.SubscriptMargin = new System.Windows.Forms.Padding(-80, -5, 0, 1);
            this.progressBar.SubscriptText = "filled";
            this.progressBar.SuperscriptColor = System.Drawing.Color.Goldenrod;
            this.progressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar.SuperscriptText = "";
            this.progressBar.TabIndex = 37;
            this.progressBar.Text = "68%";
            this.progressBar.TextMargin = new System.Windows.Forms.Padding(40, -10, 20, 0);
            this.progressBar.Value = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 28);
            this.label2.TabIndex = 20;
            this.label2.Text = "Laundry Detergent";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pictureBox5.Location = new System.Drawing.Point(26, 31);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(376, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.wool_btn);
            this.panel1.Controls.Add(this.duration_lbl);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.spins_lbl);
            this.panel1.Controls.Add(this.temperature_lbl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.eco_btn);
            this.panel1.Controls.Add(this.delicate_btn);
            this.panel1.Controls.Add(this.cotton_lbl);
            this.panel1.Controls.Add(this.rapid_btn);
            this.panel1.Controls.Add(this.intense_btn);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.time_lbl);
            this.panel1.Controls.Add(this.pr_lbl);
            this.panel1.Location = new System.Drawing.Point(56, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 746);
            this.panel1.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(222, 554);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "min";
            // 
            // wool_btn
            // 
            this.wool_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.wool_btn.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wool_btn.Image = ((System.Drawing.Image)(resources.GetObject("wool_btn.Image")));
            this.wool_btn.Location = new System.Drawing.Point(380, 363);
            this.wool_btn.Name = "wool_btn";
            this.wool_btn.Size = new System.Drawing.Size(97, 87);
            this.wool_btn.TabIndex = 17;
            this.wool_btn.Text = "Wools";
            this.wool_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.wool_btn.UseVisualStyleBackColor = true;
            this.wool_btn.Click += new System.EventHandler(this.wool_btn_Click);
            // 
            // duration_lbl
            // 
            this.duration_lbl.AutoSize = true;
            this.duration_lbl.BackColor = System.Drawing.Color.Transparent;
            this.duration_lbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.duration_lbl.Location = new System.Drawing.Point(186, 554);
            this.duration_lbl.Name = "duration_lbl";
            this.duration_lbl.Size = new System.Drawing.Size(17, 20);
            this.duration_lbl.TabIndex = 16;
            this.duration_lbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(73, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Duration:";
            // 
            // spins_lbl
            // 
            this.spins_lbl.AutoSize = true;
            this.spins_lbl.BackColor = System.Drawing.Color.Transparent;
            this.spins_lbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.spins_lbl.Location = new System.Drawing.Point(186, 521);
            this.spins_lbl.Name = "spins_lbl";
            this.spins_lbl.Size = new System.Drawing.Size(17, 20);
            this.spins_lbl.TabIndex = 14;
            this.spins_lbl.Text = "0";
            // 
            // temperature_lbl
            // 
            this.temperature_lbl.AutoSize = true;
            this.temperature_lbl.BackColor = System.Drawing.Color.Transparent;
            this.temperature_lbl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.temperature_lbl.Location = new System.Drawing.Point(186, 489);
            this.temperature_lbl.Name = "temperature_lbl";
            this.temperature_lbl.Size = new System.Drawing.Size(17, 20);
            this.temperature_lbl.TabIndex = 13;
            this.temperature_lbl.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(73, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Spins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(73, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Temperature: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(186, 624);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "WASH";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eco_btn
            // 
            this.eco_btn.Font = new System.Drawing.Font("Nirmala UI", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eco_btn.Location = new System.Drawing.Point(73, 234);
            this.eco_btn.Name = "eco_btn";
            this.eco_btn.Size = new System.Drawing.Size(97, 87);
            this.eco_btn.TabIndex = 10;
            this.eco_btn.Text = "ECO";
            this.eco_btn.UseVisualStyleBackColor = true;
            this.eco_btn.Click += new System.EventHandler(this.eco_btn_Click);
            // 
            // delicate_btn
            // 
            this.delicate_btn.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delicate_btn.Image = ((System.Drawing.Image)(resources.GetObject("delicate_btn.Image")));
            this.delicate_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.delicate_btn.Location = new System.Drawing.Point(225, 234);
            this.delicate_btn.Name = "delicate_btn";
            this.delicate_btn.Size = new System.Drawing.Size(97, 87);
            this.delicate_btn.TabIndex = 9;
            this.delicate_btn.Text = "Delicate";
            this.delicate_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.delicate_btn.UseVisualStyleBackColor = true;
            this.delicate_btn.Click += new System.EventHandler(this.delicate_btn_Click);
            // 
            // cotton_lbl
            // 
            this.cotton_lbl.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cotton_lbl.Image = ((System.Drawing.Image)(resources.GetObject("cotton_lbl.Image")));
            this.cotton_lbl.Location = new System.Drawing.Point(227, 363);
            this.cotton_lbl.Name = "cotton_lbl";
            this.cotton_lbl.Size = new System.Drawing.Size(97, 87);
            this.cotton_lbl.TabIndex = 8;
            this.cotton_lbl.Text = "Cottons";
            this.cotton_lbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cotton_lbl.UseVisualStyleBackColor = true;
            this.cotton_lbl.Click += new System.EventHandler(this.cotton_lbl_Click);
            // 
            // rapid_btn
            // 
            this.rapid_btn.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rapid_btn.Image = ((System.Drawing.Image)(resources.GetObject("rapid_btn.Image")));
            this.rapid_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rapid_btn.Location = new System.Drawing.Point(380, 234);
            this.rapid_btn.Name = "rapid_btn";
            this.rapid_btn.Size = new System.Drawing.Size(97, 87);
            this.rapid_btn.TabIndex = 7;
            this.rapid_btn.Text = "Rapid 30\'";
            this.rapid_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rapid_btn.UseVisualStyleBackColor = true;
            this.rapid_btn.Click += new System.EventHandler(this.rapid_btn_Click);
            // 
            // intense_btn
            // 
            this.intense_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.intense_btn.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.intense_btn.Image = ((System.Drawing.Image)(resources.GetObject("intense_btn.Image")));
            this.intense_btn.Location = new System.Drawing.Point(73, 363);
            this.intense_btn.Name = "intense_btn";
            this.intense_btn.Size = new System.Drawing.Size(97, 87);
            this.intense_btn.TabIndex = 6;
            this.intense_btn.Text = "Intensive";
            this.intense_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.intense_btn.UseVisualStyleBackColor = true;
            this.intense_btn.Click += new System.EventHandler(this.intense_btn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 100);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 3, 4, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 4, 1, 37, 41, 0);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.Color.Transparent;
            this.time_lbl.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.time_lbl.Location = new System.Drawing.Point(241, 51);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(64, 31);
            this.time_lbl.TabIndex = 0;
            this.time_lbl.Text = "Time";
            this.time_lbl.Click += new System.EventHandler(this.time_lbl_Click);
            // 
            // pr_lbl
            // 
            this.pr_lbl.AutoSize = true;
            this.pr_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pr_lbl.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pr_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.pr_lbl.Location = new System.Drawing.Point(222, 168);
            this.pr_lbl.Name = "pr_lbl";
            this.pr_lbl.Size = new System.Drawing.Size(102, 31);
            this.pr_lbl.TabIndex = 1;
            this.pr_lbl.Text = "Program";
            // 
            // cancel_wash
            // 
            this.cancel_wash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.cancel_wash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_wash.FlatAppearance.BorderSize = 0;
            this.cancel_wash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_wash.Font = new System.Drawing.Font("Nirmala UI", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_wash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_wash.Location = new System.Drawing.Point(801, 77);
            this.cancel_wash.Name = "cancel_wash";
            this.cancel_wash.Size = new System.Drawing.Size(264, 36);
            this.cancel_wash.TabIndex = 56;
            this.cancel_wash.Text = "CANCEL PROGRAMMED WASH";
            this.cancel_wash.UseVisualStyleBackColor = false;
            this.cancel_wash.Visible = false;
            this.cancel_wash.Click += new System.EventHandler(this.cancel_wash_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Washer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1121, 901);
            this.Controls.Add(this.cancel_wash);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Washer";
            this.Text = "Washer";
            this.Load += new System.EventHandler(this.Washer_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BinMessage;
        private CircularProgressBar.CircularProgressBar progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button eco_btn;
        private System.Windows.Forms.Button delicate_btn;
        private System.Windows.Forms.Button cotton_lbl;
        private System.Windows.Forms.Button rapid_btn;
        private System.Windows.Forms.Button intense_btn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label pr_lbl;
        private System.Windows.Forms.Label spins_lbl;
        private System.Windows.Forms.Label temperature_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label duration_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button wool_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancel_wash;
        private System.Windows.Forms.Timer timer1;
    }
}
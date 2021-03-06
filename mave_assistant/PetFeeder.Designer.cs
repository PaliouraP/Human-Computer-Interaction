
namespace mave_assistant
{
    partial class pet_feeder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pet_feeder));
            this.cancel_feed = new System.Windows.Forms.Button();
            this.feed_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pet_feeder_cam = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bowl_lbl = new System.Windows.Forms.Label();
            this.alert_pb = new System.Windows.Forms.PictureBox();
            this.time_lbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.record = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.water_btn = new System.Windows.Forms.Button();
            this.cancel_water = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.progressBar = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.progressBar1 = new CircularProgressBar.CircularProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.water_event = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.next_feed_lbl = new System.Windows.Forms.Label();
            this.next_water_change_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pet_feeder_cam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert_pb)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.record)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel_feed
            // 
            this.cancel_feed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.cancel_feed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_feed.FlatAppearance.BorderSize = 0;
            this.cancel_feed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_feed.Font = new System.Drawing.Font("Nirmala UI", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_feed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_feed.Location = new System.Drawing.Point(10, 130);
            this.cancel_feed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_feed.Name = "cancel_feed";
            this.cancel_feed.Size = new System.Drawing.Size(306, 27);
            this.cancel_feed.TabIndex = 61;
            this.cancel_feed.Text = "CANCEL PROGRAMMED FEED";
            this.cancel_feed.UseVisualStyleBackColor = false;
            this.cancel_feed.Visible = false;
            this.cancel_feed.Click += new System.EventHandler(this.cancel_feed_Click);
            // 
            // feed_btn
            // 
            this.feed_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.feed_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.feed_btn.FlatAppearance.BorderSize = 0;
            this.feed_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feed_btn.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.feed_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feed_btn.Location = new System.Drawing.Point(10, 130);
            this.feed_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.feed_btn.Name = "feed_btn";
            this.feed_btn.Size = new System.Drawing.Size(306, 27);
            this.feed_btn.TabIndex = 4;
            this.feed_btn.Text = "Feed";
            this.feed_btn.UseVisualStyleBackColor = false;
            this.feed_btn.Click += new System.EventHandler(this.feed_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 45);
            this.label1.TabIndex = 57;
            this.label1.Text = "Pet Feeder";
            // 
            // pet_feeder_cam
            // 
            this.pet_feeder_cam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pet_feeder_cam.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pet_feeder_cam.Location = new System.Drawing.Point(27, 49);
            this.pet_feeder_cam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pet_feeder_cam.Name = "pet_feeder_cam";
            this.pet_feeder_cam.Size = new System.Drawing.Size(271, 222);
            this.pet_feeder_cam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pet_feeder_cam.TabIndex = 65;
            this.pet_feeder_cam.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(15, 26);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(298, 17);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 49;
            this.pictureBox6.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(15, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "07:00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(78, 52);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 22);
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(117, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 65;
            this.label7.Text = "Barely Touched    ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(117, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 68;
            this.label9.Text = "Ate 50 gr    ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(78, 93);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 22);
            this.pictureBox3.TabIndex = 67;
            this.pictureBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(15, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 25);
            this.label10.TabIndex = 66;
            this.label10.Text = "11:00";
            // 
            // bowl_lbl
            // 
            this.bowl_lbl.AutoSize = true;
            this.bowl_lbl.BackColor = System.Drawing.Color.Transparent;
            this.bowl_lbl.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bowl_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.bowl_lbl.Location = new System.Drawing.Point(117, 133);
            this.bowl_lbl.Name = "bowl_lbl";
            this.bowl_lbl.Size = new System.Drawing.Size(163, 25);
            this.bowl_lbl.TabIndex = 71;
            this.bowl_lbl.Text = "Water bowl flipped";
            this.bowl_lbl.Visible = false;
            // 
            // alert_pb
            // 
            this.alert_pb.BackColor = System.Drawing.Color.Transparent;
            this.alert_pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alert_pb.BackgroundImage")));
            this.alert_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.alert_pb.Location = new System.Drawing.Point(78, 133);
            this.alert_pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alert_pb.Name = "alert_pb";
            this.alert_pb.Size = new System.Drawing.Size(26, 22);
            this.alert_pb.TabIndex = 70;
            this.alert_pb.TabStop = false;
            this.alert_pb.Visible = false;
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.Color.Transparent;
            this.time_lbl.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.time_lbl.Location = new System.Drawing.Point(15, 133);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(56, 25);
            this.time_lbl.TabIndex = 69;
            this.time_lbl.Text = "14:00";
            this.time_lbl.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.pictureBox7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.bowl_lbl);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.alert_pb);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.time_lbl);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Location = new System.Drawing.Point(10, 428);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(960, 226);
            this.panel5.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(442, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 25);
            this.label13.TabIndex = 72;
            this.label13.Text = "Feedback";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(19, 32);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(917, 17);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 73;
            this.pictureBox7.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.record);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.pet_feeder_cam);
            this.panel6.Controls.Add(this.pictureBox6);
            this.panel6.Location = new System.Drawing.Point(644, 130);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(326, 292);
            this.panel6.TabIndex = 73;
            // 
            // record
            // 
            this.record.BackColor = System.Drawing.Color.Transparent;
            this.record.Cursor = System.Windows.Forms.Cursors.Hand;
            this.record.Image = global::mave_assistant.Properties.Resources.live_circle;
            this.record.Location = new System.Drawing.Point(244, 9);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(28, 28);
            this.record.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.record.TabIndex = 73;
            this.record.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(79, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 25);
            this.label14.TabIndex = 72;
            this.label14.Text = "Pet Feeder Camera";
            // 
            // water_btn
            // 
            this.water_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.water_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.water_btn.FlatAppearance.BorderSize = 0;
            this.water_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.water_btn.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.water_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.water_btn.Location = new System.Drawing.Point(327, 130);
            this.water_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.water_btn.Name = "water_btn";
            this.water_btn.Size = new System.Drawing.Size(306, 27);
            this.water_btn.TabIndex = 93;
            this.water_btn.Text = "Change Water";
            this.water_btn.UseVisualStyleBackColor = false;
            this.water_btn.Click += new System.EventHandler(this.water_btn_Click);
            // 
            // cancel_water
            // 
            this.cancel_water.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.cancel_water.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_water.FlatAppearance.BorderSize = 0;
            this.cancel_water.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_water.Font = new System.Drawing.Font("Nirmala UI", 9.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cancel_water.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel_water.Location = new System.Drawing.Point(327, 130);
            this.cancel_water.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel_water.Name = "cancel_water";
            this.cancel_water.Size = new System.Drawing.Size(306, 27);
            this.cancel_water.TabIndex = 95;
            this.cancel_water.Text = "CANCEL WATER CHANGE";
            this.cancel_water.UseVisualStyleBackColor = false;
            this.cancel_water.Visible = false;
            this.cancel_water.Click += new System.EventHandler(this.cancel_water_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Location = new System.Drawing.Point(327, 162);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 260);
            this.panel2.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(125, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Water";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(23, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(266, 18);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 38;
            this.pictureBox5.TabStop = false;
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
            this.progressBar.Location = new System.Drawing.Point(53, 56);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.MarqueeAnimationSpeed = 2000;
            this.progressBar.Name = "progressBar";
            this.progressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.progressBar.OuterMargin = -25;
            this.progressBar.OuterWidth = 26;
            this.progressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.progressBar.ProgressWidth = 20;
            this.progressBar.SecondaryFont = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.progressBar.Size = new System.Drawing.Size(192, 183);
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
            this.label2.Location = new System.Drawing.Point(126, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Food";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 163);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 260);
            this.panel1.TabIndex = 97;
            // 
            // progressBar1
            // 
            this.progressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.progressBar1.AnimationSpeed = 500;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.progressBar1.ForeColor = System.Drawing.Color.Silver;
            this.progressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.progressBar1.InnerMargin = 2;
            this.progressBar1.InnerWidth = -1;
            this.progressBar1.Location = new System.Drawing.Point(53, 56);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.MarqueeAnimationSpeed = 2000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.progressBar1.OuterMargin = -25;
            this.progressBar1.OuterWidth = 26;
            this.progressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.progressBar1.ProgressWidth = 20;
            this.progressBar1.SecondaryFont = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.progressBar1.Size = new System.Drawing.Size(192, 182);
            this.progressBar1.StartAngle = 270;
            this.progressBar1.SubscriptColor = System.Drawing.Color.DimGray;
            this.progressBar1.SubscriptMargin = new System.Windows.Forms.Padding(-80, -5, 0, 1);
            this.progressBar1.SubscriptText = "filled";
            this.progressBar1.SuperscriptColor = System.Drawing.Color.Goldenrod;
            this.progressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.progressBar1.SuperscriptText = "";
            this.progressBar1.TabIndex = 37;
            this.progressBar1.Text = "68%";
            this.progressBar1.TextMargin = new System.Windows.Forms.Padding(40, -10, 20, 0);
            this.progressBar1.Value = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // water_event
            // 
            this.water_event.Interval = 15000;
            this.water_event.Tick += new System.EventHandler(this.water_event_Tick);
            // 
            // next_feed_lbl
            // 
            this.next_feed_lbl.AutoSize = true;
            this.next_feed_lbl.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.next_feed_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.next_feed_lbl.Location = new System.Drawing.Point(25, 106);
            this.next_feed_lbl.Name = "next_feed_lbl";
            this.next_feed_lbl.Size = new System.Drawing.Size(50, 20);
            this.next_feed_lbl.TabIndex = 98;
            this.next_feed_lbl.Text = "label4";
            this.next_feed_lbl.Visible = false;
            // 
            // next_water_change_lbl
            // 
            this.next_water_change_lbl.AutoSize = true;
            this.next_water_change_lbl.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.next_water_change_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.next_water_change_lbl.Location = new System.Drawing.Point(367, 106);
            this.next_water_change_lbl.Name = "next_water_change_lbl";
            this.next_water_change_lbl.Size = new System.Drawing.Size(50, 20);
            this.next_water_change_lbl.TabIndex = 99;
            this.next_water_change_lbl.Text = "label4";
            this.next_water_change_lbl.Visible = false;
            // 
            // pet_feeder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(981, 676);
            this.Controls.Add(this.next_water_change_lbl);
            this.Controls.Add(this.next_feed_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.water_btn);
            this.Controls.Add(this.cancel_water);
            this.Controls.Add(this.feed_btn);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.cancel_feed);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "pet_feeder";
            this.Text = "PetFeeder";
            this.Load += new System.EventHandler(this.PetFeeder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pet_feeder_cam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alert_pb)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.record)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pet_feeder_cam;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label bowl_lbl;
        private System.Windows.Forms.PictureBox alert_pb;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox record;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private CircularProgressBar.CircularProgressBar progressBar;
        private System.Windows.Forms.Panel panel1;
        private CircularProgressBar.CircularProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button cancel_feed;
        public System.Windows.Forms.Button feed_btn;
        public System.Windows.Forms.Button water_btn;
        public System.Windows.Forms.Button cancel_water;
        private System.Windows.Forms.Timer water_event;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Label next_feed_lbl;
        public System.Windows.Forms.Label next_water_change_lbl;
    }
}
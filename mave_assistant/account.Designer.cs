﻿
namespace mave_assistant
{
    partial class account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account));
            this.account_label = new System.Windows.Forms.Label();
            this.completed_tasks_panel = new System.Windows.Forms.Panel();
            this.pet = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dob = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.profile = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.completed_tasks_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.SuspendLayout();
            // 
            // account_label
            // 
            this.account_label.AutoSize = true;
            this.account_label.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.account_label.Location = new System.Drawing.Point(3, 9);
            this.account_label.Name = "account_label";
            this.account_label.Size = new System.Drawing.Size(137, 45);
            this.account_label.TabIndex = 15;
            this.account_label.Text = "Account";
            // 
            // completed_tasks_panel
            // 
            this.completed_tasks_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.completed_tasks_panel.Controls.Add(this.pet);
            this.completed_tasks_panel.Controls.Add(this.label6);
            this.completed_tasks_panel.Controls.Add(this.dob);
            this.completed_tasks_panel.Controls.Add(this.name);
            this.completed_tasks_panel.Controls.Add(this.user);
            this.completed_tasks_panel.Controls.Add(this.profile);
            this.completed_tasks_panel.Controls.Add(this.label4);
            this.completed_tasks_panel.Controls.Add(this.label5);
            this.completed_tasks_panel.Controls.Add(this.label2);
            this.completed_tasks_panel.Location = new System.Drawing.Point(290, 109);
            this.completed_tasks_panel.Name = "completed_tasks_panel";
            this.completed_tasks_panel.Size = new System.Drawing.Size(419, 373);
            this.completed_tasks_panel.TabIndex = 17;
            // 
            // pet
            // 
            this.pet.AutoSize = true;
            this.pet.Location = new System.Drawing.Point(341, 320);
            this.pet.Name = "pet";
            this.pet.Size = new System.Drawing.Size(38, 15);
            this.pet.TabIndex = 35;
            this.pet.Text = "label1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(10, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "Pet Name";
            // 
            // dob
            // 
            this.dob.AutoSize = true;
            this.dob.Location = new System.Drawing.Point(341, 274);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(28, 15);
            this.dob.TabIndex = 33;
            this.dob.Text = "dob";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(341, 184);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(37, 15);
            this.name.TabIndex = 31;
            this.name.Text = "name";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(341, 138);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(29, 15);
            this.user.TabIndex = 30;
            this.user.Text = "user";
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.profile.Image = ((System.Drawing.Image)(resources.GetObject("profile.Image")));
            this.profile.Location = new System.Drawing.Point(149, 18);
            this.profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(115, 111);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile.TabIndex = 29;
            this.profile.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(10, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(10, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(215)))), ((int)(((byte)(241)))));
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(10, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Username";
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(965, 637);
            this.Controls.Add(this.completed_tasks_panel);
            this.Controls.Add(this.account_label);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "account";
            this.Text = "account";
            this.Load += new System.EventHandler(this.account_Load);
            this.completed_tasks_panel.ResumeLayout(false);
            this.completed_tasks_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account_label;
        private System.Windows.Forms.Panel completed_tasks_panel;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label pet;
    }
}
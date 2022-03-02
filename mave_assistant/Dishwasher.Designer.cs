
namespace mave_assistant
{
    partial class Dishwasher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dishwasher));
            this.time_lbl = new System.Windows.Forms.Label();
            this.pr_lbl = new System.Windows.Forms.Label();
            this.soap_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wash_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.Color.Transparent;
            this.time_lbl.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.time_lbl.Location = new System.Drawing.Point(501, 68);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(64, 31);
            this.time_lbl.TabIndex = 0;
            this.time_lbl.Text = "Time";
            // 
            // pr_lbl
            // 
            this.pr_lbl.AutoSize = true;
            this.pr_lbl.BackColor = System.Drawing.Color.Transparent;
            this.pr_lbl.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pr_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.pr_lbl.Location = new System.Drawing.Point(486, 195);
            this.pr_lbl.Name = "pr_lbl";
            this.pr_lbl.Size = new System.Drawing.Size(102, 31);
            this.pr_lbl.TabIndex = 1;
            this.pr_lbl.Text = "Program";
            // 
            // soap_lbl
            // 
            this.soap_lbl.AutoSize = true;
            this.soap_lbl.BackColor = System.Drawing.Color.Transparent;
            this.soap_lbl.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soap_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.soap_lbl.Location = new System.Drawing.Point(486, 337);
            this.soap_lbl.Name = "soap_lbl";
            this.soap_lbl.Size = new System.Drawing.Size(114, 31);
            this.soap_lbl.TabIndex = 2;
            this.soap_lbl.Text = "Add Soap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dishwasher";
            // 
            // wash_btn
            // 
            this.wash_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.wash_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wash_btn.FlatAppearance.BorderSize = 0;
            this.wash_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wash_btn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wash_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wash_btn.Location = new System.Drawing.Point(468, 724);
            this.wash_btn.Name = "wash_btn";
            this.wash_btn.Size = new System.Drawing.Size(175, 53);
            this.wash_btn.TabIndex = 4;
            this.wash_btn.Text = "WASH";
            this.wash_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.time_lbl);
            this.panel1.Controls.Add(this.pr_lbl);
            this.panel1.Controls.Add(this.soap_lbl);
            this.panel1.Location = new System.Drawing.Point(55, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 544);
            this.panel1.TabIndex = 5;
            // 
            // Dishwasher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1121, 901);
            this.Controls.Add(this.wash_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Dishwasher";
            this.Text = "Dishwasher";
            this.Load += new System.EventHandler(this.Dishwasher_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label pr_lbl;
        private System.Windows.Forms.Label soap_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wash_btn;
        private System.Windows.Forms.Panel panel1;
    }
}
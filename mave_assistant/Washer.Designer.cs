
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
            this.label1 = new System.Windows.Forms.Label();
            this.wash_btn = new System.Windows.Forms.Button();
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
            // wash_btn
            // 
            this.wash_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(67)))), ((int)(((byte)(159)))));
            this.wash_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wash_btn.FlatAppearance.BorderSize = 0;
            this.wash_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wash_btn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wash_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.wash_btn.Location = new System.Drawing.Point(372, 424);
            this.wash_btn.Name = "wash_btn";
            this.wash_btn.Size = new System.Drawing.Size(175, 53);
            this.wash_btn.TabIndex = 3;
            this.wash_btn.Text = "WASH";
            this.wash_btn.UseVisualStyleBackColor = false;
            // 
            // Washer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1121, 901);
            this.Controls.Add(this.wash_btn);
            this.Controls.Add(this.label1);
            this.Name = "Washer";
            this.Text = "Washer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wash_btn;
    }
}
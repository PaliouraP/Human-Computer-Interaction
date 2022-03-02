
namespace mave_assistant
{
    partial class Events
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
            this.current_events_container = new System.Windows.Forms.FlowLayoutPanel();
            this.date_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // current_events_container
            // 
            this.current_events_container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.current_events_container.Location = new System.Drawing.Point(24, 100);
            this.current_events_container.Name = "current_events_container";
            this.current_events_container.Size = new System.Drawing.Size(495, 238);
            this.current_events_container.TabIndex = 0;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.Location = new System.Drawing.Point(27, 27);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(39, 20);
            this.date_lbl.TabIndex = 1;
            this.date_lbl.Text = "date";
            // 
            // Events
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 417);
            this.Controls.Add(this.date_lbl);
            this.Controls.Add(this.current_events_container);
            this.Name = "Events";
            this.Text = "Events";
            this.Load += new System.EventHandler(this.Events_Load);
            this.Leave += new System.EventHandler(this.Events_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel current_events_container;
        private System.Windows.Forms.Label date_lbl;
    }
}
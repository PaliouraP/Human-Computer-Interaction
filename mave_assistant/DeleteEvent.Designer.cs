
namespace mave_assistant
{
    partial class DeleteEvent
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
            this.SuspendLayout();
            // 
            // current_events_container
            // 
            this.current_events_container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.current_events_container.Location = new System.Drawing.Point(141, 107);
            this.current_events_container.Name = "current_events_container";
            this.current_events_container.Size = new System.Drawing.Size(437, 331);
            this.current_events_container.TabIndex = 1;
            // 
            // DeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.current_events_container);
            this.Name = "DeleteEvent";
            this.Text = "DeleteEvent";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel current_events_container;
    }
}
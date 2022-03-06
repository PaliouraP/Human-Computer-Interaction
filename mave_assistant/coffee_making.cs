using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class coffee_making : Form
    {
        public coffee_making()
        {
            InitializeComponent();
        }

        
        private void panel3_MouseEnter(object sender, EventArgs e)
        {

        }
        

        private void pictureBox17_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.Gray;
        }

        // Make coffee button
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coffee making started.");
        }

        // Schedule button
        private void button2_Click(object sender, EventArgs e)
        {
            make_coffee cf = new make_coffee();
            cf.ShowDialog();
        }
    }
}

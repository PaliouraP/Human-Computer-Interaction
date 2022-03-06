using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class PetFeeder_Water : Form
    {
        public PetFeeder_Water()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pet feeder water has now been changed");
            pet_feeder.cancel_w = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pet feeder water will be changed at "+ dateTimePickerWater.Text);
            pet_feeder.water = true;
            this.Close();
        }
    }
}

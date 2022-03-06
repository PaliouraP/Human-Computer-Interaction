using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class PetFeeder_Feed : Form
    {
        
        public PetFeeder_Feed()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pet will be fed at " + dateTimePickerFood.Text);
            pet_feeder.food = true;
            this.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pet has now been fed");
            if (Int32.Parse(portion.Text) == 100)
            {
                pet_feeder.p = 2; //we assume the pet feeder dry food container can contain a maximum of 5L
            } 
            else if (Int32.Parse(portion.Text) == 200)
            {
                pet_feeder.p = 4; //we assume the pet feeder dry food container can contain a maximum of 5L
            } 
            else if (Int32.Parse(portion.Text) == 300)
            {
                pet_feeder.p = 6; //we assume the pet feeder dry food container can contain a maximum of 5L
            } 
            else if (Int32.Parse(portion.Text) == 400)
            {
                pet_feeder.p = 8; //we assume the pet feeder dry food container can contain a maximum of 5L
            } 
            else if (Int32.Parse(portion.Text) == 500)
            {
                pet_feeder.p = 10; //we assume the pet feeder dry food container can contain a maximum of 5L
            }
            pet_feeder.cancel_f = false;
            this.Close();
        }
    }
}

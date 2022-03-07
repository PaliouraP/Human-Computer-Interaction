using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class watering_system : Form
    {
        public watering_system()
        {
            InitializeComponent();
        }

        // Water temperature plus button
        private void temp_plus_Click(object sender, EventArgs e)
        {
            if (temperature_bar.Value + 1 > 30)
            {
                MessageBox.Show("Water temperature value is out of range.");
            }
            else
            {
                temperature_bar.Value += 1;
                celcius.Text = temperature_bar.Value + " °C";
            }
        }

        // Water temperature minus button
        private void temp_minus_Click(object sender, EventArgs e)
        {
            if (temperature_bar.Value - 1 < 0)
            {
                MessageBox.Show("Water temperature value is out of range.");
            }
            else
            {
                temperature_bar.Value -= 1;
                celcius.Text = temperature_bar.Value + " °C";
            }
        }


        // Water pressure plus button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pressure_bar.Value + 2 > 100)
            {
                MessageBox.Show("Water pressure value is out of range.");
            } 
            else
            {
                pressure_bar.Value += 2;
                press.Text = pressure_bar.Value + " psi";
            }  

        }
        // Water pressure minus button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pressure_bar.Value - 2 < 0)
            {
                MessageBox.Show("Water pressure value is out of range.");
            }
            else
            {
                pressure_bar.Value -= 2;
                press.Text = pressure_bar.Value + " psi";
            }

        }



        // Water flow plus button
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (flow_bar.Value + 1 > 2)
            {
                MessageBox.Show("Water flow value is out of range.");
            }
            else
            {
                flow_bar.Value += 1;
                flow_text.Text = flow_bar.Value + " m/s";
            }
        }
        // Water pressure minus button
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (flow_bar.Value - 1 < 0)
            {
                MessageBox.Show("Water flow value is out of range.");
            }
            else
            {
                flow_bar.Value -= 1;
                flow_text.Text = flow_bar.Value + " m/s";
            }
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Watering scheduled on " + dt.Text + " at " + time.Text + ".");
        }
    }
}

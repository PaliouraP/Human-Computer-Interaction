using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class room_control : Form
    {
        // Initializing a local reference to toggle images as "on" and "off"
        Image off = Properties.Resources.toggle_off;
        Image on = Properties.Resources.toggle_on;

        public room_control(Image room, string room_name)
        {
            InitializeComponent();
            room_pic.Image = room;
            name_label.Text = room_name;
        }

        private void room_control_Load(object sender, EventArgs e)
        {
            toggle.Image = off;
        }

        // Humidity Control
        private void hum_plus_Click(object sender, EventArgs e)
        {
            humidity_bar.Value += 10;
            hydrometers.Text = humidity_bar.Value + " %";
            
        }

        private void hum_minus_Click(object sender, EventArgs e)
        {
            humidity_bar.Value -= 10;
            hydrometers.Text = humidity_bar.Value + " %";
        }

        // Temperature Control
        private void temp_plus_Click(object sender, EventArgs e)
        {
            temperature_bar.Value += 1;
            celcius.Text = temperature_bar.Value + " °C";
        }

        private void temp_minus_Click(object sender, EventArgs e)
        {
            temperature_bar.Value -= 1;
            celcius.Text = temperature_bar.Value + " °C";
        }

        private void toggle_Click(object sender, EventArgs e)
        {
            if (toggle.Image == off)
            {
                toggle.Image = on;
            }
            else
            {
                toggle.Image = off;
            }
        }
    }
}

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

        // Lights on
        Image kitch = Properties.Resources.kitchen;
        Image bath = Properties.Resources.bathroom;
        Image liv = Properties.Resources.living_room;
        Image off_space = Properties.Resources.office;
        Image dining = Properties.Resources.dining_room;
        Image bedr = Properties.Resources.bedroom;

        // Rooms with lights off
        Image dark_kitch = Properties.Resources.kitchen_dark;
        Image dark_bath = Properties.Resources.bathroom_dark;
        Image dark_liv = Properties.Resources.living_room_dark;
        Image dark_off_space = Properties.Resources.office_dark;
        Image dark_dining = Properties.Resources.dining_room_dark;
        Image dark_bedr = Properties.Resources.bedroom_dark;

        public room_control(Image room, string room_name)
        {
            InitializeComponent();
            room_pic.Image = room;
            name_label.Text = room_name;

        }

        private void room_control_Load(object sender, EventArgs e)
        {
            toggle.Image = on;
        }

        // Humidity Control
        private void hum_plus_Click(object sender, EventArgs e)
        {
            if (humidity_bar.Value + 10 > 100)
            {
                MessageBox.Show("Humidity value is out of range.");
            } 
            else
            {
                humidity_bar.Value += 10;
                hydrometers.Text = humidity_bar.Value + " %";
            }            
        }

        private void hum_minus_Click(object sender, EventArgs e)
        {
            if (humidity_bar.Value - 10 < 0)
            {
                MessageBox.Show("Humidity value is out of range.");
            }
            else
            {
                humidity_bar.Value -= 10;
                hydrometers.Text = humidity_bar.Value + " %";
            }
        }

        // Temperature Control
        private void temp_plus_Click(object sender, EventArgs e)
        {
            if (temperature_bar.Value + 1 > 30)
            {
                MessageBox.Show("Temperature value is out of range.");
            }
            else
            {
                temperature_bar.Value += 1;
                celcius.Text = temperature_bar.Value + " °C";
            }
        }

        private void temp_minus_Click(object sender, EventArgs e)
        {
            if (temperature_bar.Value - 1 < 0)
            {
                MessageBox.Show("Temperature value is out of range.");
            }
            else
            {
                temperature_bar.Value -= 1;
                celcius.Text = temperature_bar.Value + " °C";
            }   
        }

        private void toggle_Click(object sender, EventArgs e)
        {
            if (toggle.Image == off)
            {
                toggle.Image = on;
                if (name_label.Text == "Bedroom")
                {
                    room_pic.Image = bedr;
                } 
                else if (name_label.Text == "Kitchen")
                {
                    room_pic.Image = kitch;
                }
                else if (name_label.Text == "Dining Room")
                {
                    room_pic.Image = dining;
                }
                else if (name_label.Text == "Living Room")
                {
                    room_pic.Image = liv;
                }
                else if (name_label.Text == "Office")
                {
                    room_pic.Image = off_space;
                }
                else if (name_label.Text == "Bathroom")
                {
                    room_pic.Image = bath;
                }
            }
            else
            {
                toggle.Image = off;
                if (name_label.Text == "Bedroom")
                {
                    room_pic.Image = dark_bedr;
                }
                else if (name_label.Text == "Kitchen")
                {
                    room_pic.Image = dark_kitch;
                }
                else if (name_label.Text == "Dining Room")
                {
                    room_pic.Image = dark_dining;
                }
                else if (name_label.Text == "Living Room")
                {
                    room_pic.Image = dark_liv;
                }
                else if (name_label.Text == "Office")
                {
                    room_pic.Image = dark_off_space;
                }
                else if (name_label.Text == "Bathroom")
                {
                    room_pic.Image = dark_bath;
                }
            }
        }
    }
}

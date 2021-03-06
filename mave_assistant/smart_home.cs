using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class smart_home : Form
    {
        // Initializing a local reference to toggle images as "on" and "off"
        Image off = Properties.Resources.toggle_off;
        Image on = Properties.Resources.toggle_on;

        // Initializing a local reference to alarm system images
        Image away = Properties.Resources.arm_away;
        Image stay = Properties.Resources.arm_sleep;
        Image disarm = Properties.Resources.disarm;

        // Initializing a local reference to room images
        // Lights on
        Image kitch = Properties.Resources.kitchen;
        Image bath = Properties.Resources.bathroom;
        Image liv = Properties.Resources.living_room;
        Image off_space = Properties.Resources.office;
        Image dining = Properties.Resources.dining_room;
        Image bedr = Properties.Resources.bedroom;

        // Lights off
        Image dark_kitch = Properties.Resources.kitchen_dark;
        Image dark_bath = Properties.Resources.bathroom_dark;
        Image dark_liv = Properties.Resources.living_room_dark;
        Image dark_off_space = Properties.Resources.office_dark;
        Image dark_dining = Properties.Resources.dining_room_dark;
        Image dark_bedr = Properties.Resources.bedroom_dark;

        public smart_home()
        {
            InitializeComponent();
            
            // Setting images of alarm system when form loads
            pictureBox9.Image = away;
            pictureBox8.Image = stay;
            pictureBox6.Image = disarm;

            // Setting images of toggles when form loads
            pictureBox21.Image = off;
            pictureBox24.Image = on;
            pictureBox25.Image = off;
            pictureBox26.Image = off;
            pictureBox27.Image = on;
            pictureBox26.Image = on;
        }

        private void smart_home_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
        Boolean lights;
        // Click events for on/off ---------------------------------------------------
        // If the image of the picture box is "toggle_on" we change it to "toggle_off" and vice versa.
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (pictureBox24.Image == off)
            {
                // Setting the toggle on
                pictureBox24.Image = on;

                // Setting images of pic boxes as if lights were on
                kitchen.Image = kitch;
                bathroom.Image = bath;
                office.Image = off_space;
                bedroom.Image = bedr;
                dining_room.Image = dining;
                living_room.Image = liv;
                lights = true;

            } else
            {
                // Setting the toggle off
                pictureBox24.Image = off;

                // Setting images of pic boxes as if lights were off
                kitchen.Image = dark_kitch;
                bathroom.Image = dark_bath;
                office.Image = dark_off_space;
                bedroom.Image = dark_bedr;
                dining_room.Image = dark_dining;
                living_room.Image = dark_liv;
                lights = false;
            }

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (pictureBox25.Image == off)
            {
                pictureBox25.Image = on;
            }
            else
            {
                pictureBox25.Image = off;
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            if (pictureBox26.Image == off)
            {
                pictureBox26.Image = on;
            }
            else
            {
                pictureBox26.Image = off;
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            if (pictureBox27.Image == off)
            {
                pictureBox27.Image = on;
            }
            else
            {
                pictureBox27.Image = off;
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            if (pictureBox29.Image == off)
            {
                pictureBox29.Image = on;
            }
            else
            {
                pictureBox29.Image = off;
            }
        }
        // -----------------------------------------------------------------------

        // Click events for alarm system images ----------------------------------
        // Click event for the middle icon of alarm system panel
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image == away)
            {
                MessageBox.Show("System is already in arm away mode.");
            } 
            else if (pictureBox9.Image == stay)
            {
                MessageBox.Show("System is already in arm stay mode.");
            }
            else if (pictureBox9.Image == disarm)
            {
                MessageBox.Show("System is already in disarm mode.");
            }
        }

        Image temp;

        // Click event for the right icon of alarm system panel
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (pictureBox6.Image == away)
            {
                // Set temp as the image of middle picture box
                temp = pictureBox9.Image;

                // Change images
                pictureBox9.Image = away;
                pictureBox6.Image = temp;

                // Change label's text and forecolour
                alarm_label.Text = "Armed  away";
                alarm_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#26E07F");
            }
            else if (pictureBox6.Image == stay)
            {
                // Set temp as the image of middle picture box
                temp = pictureBox9.Image;

                // Change images
                pictureBox9.Image = stay;
                pictureBox6.Image = temp;

                // Change label's text and forecolour
                alarm_label.Text = "  Armed  stay";
                alarm_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#4A90E2");
            }
            else if (pictureBox6.Image == disarm)
            {
                // Set temp as the image of middle picture box
                temp = pictureBox9.Image;

                // Change images
                pictureBox9.Image = disarm;
                pictureBox6.Image = temp;

                // Change label's text and forecolour
                alarm_label.Text = "      Disarm";
                alarm_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FA314A");
            }
        }

        // Click event for the left icon of alarm system panel
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (pictureBox8.Image == away)
            {
                // Set temp as the image of middle picture box
                temp = pictureBox9.Image;

                // Change images
                pictureBox9.Image = away;
                pictureBox8.Image = temp;

                // Change label's text and forecolour
                alarm_label.Text = "   Armed  away";
                alarm_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#26E07F");
            }
            else if (pictureBox8.Image == stay)
            {
                // Set temp as the image of middle picture box
                temp = pictureBox9.Image;

                // Change images
                pictureBox9.Image = stay;
                pictureBox8.Image = temp;

                // Change label's text and forecolour
                alarm_label.Text = "Armed  stay";
                alarm_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#4A90E2");
            }
            else if (pictureBox8.Image == disarm)
            {
                // Set temp as the image of middle picture box
                temp = pictureBox9.Image;

                // Change images
                pictureBox9.Image = disarm;
                pictureBox8.Image = temp;

                // Change label's text and forecolour
                alarm_label.Text = "      Disarm";
                alarm_label.ForeColor = System.Drawing.ColorTranslator.FromHtml("#FA314A");
            }
            // -----------------------------------------------------------------------
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (pictureBox21.Image == off)
            {
                pictureBox21.Image = on;
            }
            else
            {
                pictureBox21.Image = off;
            }
        }

        // Click events for rooms

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            room_control rc = new room_control(kitchen.Image, "Kitchen");
            rc.ShowDialog();
        }

        private void dining_room_Click(object sender, EventArgs e)
        {
            room_control rc = new room_control(dining_room.Image, "Dining Room");
            rc.ShowDialog();
        }

        private void living_room_Click(object sender, EventArgs e)
        {
            room_control rc = new room_control(living_room.Image, "Living Room");
            rc.ShowDialog();
        }

        private void bedroom_Click(object sender, EventArgs e)
        {
            room_control rc = new room_control(bedroom.Image, "Bedroom");
            rc.ShowDialog();
        }

        private void office_Click(object sender, EventArgs e)
        {
            room_control rc = new room_control(office.Image, "Office");
            rc.ShowDialog();
        }

        private void bathroom_Click(object sender, EventArgs e)
        {
            room_control rc = new room_control(bathroom.Image, "Bathroom");
            rc.ShowDialog();
        }
    }
}

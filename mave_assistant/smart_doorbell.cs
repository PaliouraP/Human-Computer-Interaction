using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class smart_doorbell : Form
    {
        // Initializing a local reference to toggle images as "on" and "off"
        Image off = Properties.Resources.toggle_off;
        Image on = Properties.Resources.toggle_on;

        // Initializing a local reference to record icons
        Image rec_stop = Properties.Resources.record_stop;
        Image rec_play = Properties.Resources.record_play;

        public smart_doorbell()
        {
            InitializeComponent();
        }

        // Record button click event
        private void record_Click(object sender, EventArgs e)
        {
            if (record.Image == rec_stop)
            {
                record.Image = rec_play;
                MessageBox.Show("Recording has started.", "Smart Doorbell");
            }
            else
            {
                record.Image = rec_stop;
                MessageBox.Show("Recording has stopped.", "Smart Doorbell");
            }
        }

        private void smart_doorbell_Load(object sender, EventArgs e)
        {
            record.Image = rec_stop;

        }

        private void open_door_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Door is open.", "Smart Doorbell");
        }

        private void open_mic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Microphone is on.", "Smart Doorbell");
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recording Scheduled.", "Smart Doorbell");
        }


        // Click events for toggles
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (pictureBox24.Image == off)
            {
                pictureBox24.Image = on;
            }
            else
            {
                pictureBox24.Image = off;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox15.Image == off)
            {
                pictureBox15.Image = on;
            }
            else
            {
                pictureBox15.Image = off;
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (pictureBox17.Image == off)
            {
                pictureBox17.Image = on;
            }
            else
            {
                pictureBox17.Image = off;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (pictureBox16.Image == off)
            {
                pictureBox16.Image = on;
            }
            else
            {
                pictureBox16.Image = off;
            }
        }


        // Reset settings button
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox24.Image = on;
            pictureBox17.Image = on;
            pictureBox16.Image = on;
            pictureBox15.Image = on;
            comboBox2.Text = "720p60";
            MessageBox.Show("Settings have been reset.", "Smart Doorbell");
        }
    }
}

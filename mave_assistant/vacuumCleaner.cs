using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class vacuumCleaner : Form
    {
        bool isCleaning = false;
        bool isPaused=false;
        bool sendHome=false;
        Image on = Properties.Resources.icons8_toggle_on_50;
        Image off = Properties.Resources.icons8_toggle_off_50;
        public static string setValueForTime = "";
        public static string setValueForDays = "";
        public static string setValueForRooms = "";
        public static string setValueForMode="";


        public vacuumCleaner()
        {
            InitializeComponent();
        }
        //start button
        private void button2_Click(object sender, EventArgs e)
        {
            if (isCleaning == false)
            {
                isCleaning = true;
                isPaused = false;
                state.Text = "Vacuuming";
                loading.Visible = true;
            }
            else
            {
                MessageBox.Show("Robot has already started!");
            }
           
        }
        //pause button
        private void button3_Click(object sender, EventArgs e)
        {
            if (isCleaning == true)
            {
                state.Text = "Paused";
                isCleaning = false;
                isPaused = true;
                loading.Visible = false;
            }
            else
            {
                MessageBox.Show("Robot hasn't started yet");
            }
        }
        //send home button
        private void button4_Click(object sender, EventArgs e)
        {
            if (isPaused == true)
            {
                sendHome = true;
                state.Text = "At Home";
            }
            else if (isCleaning == true)
            {
                MessageBox.Show("You need to pause the robot first!");
            }
            else if (sendHome == true)
            {
                MessageBox.Show("Robot is already at home");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == on)
            {
                pictureBox2.Image = off;
            }
            else
            {
                pictureBox2.Image = on;
                pictureBox5.Image = off;
                pictureBox10.Image = off;
                pictureBox9.Image = off;
                pictureBox4.Image = off;
                setValueForMode = pictureBox2.Tag.ToString();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Image == on)
            {
                pictureBox5.Image = off;
            }
            else
            {
                pictureBox5.Image = on;
                pictureBox2.Image = off;
                pictureBox10.Image = off;
                pictureBox9.Image = off;
                pictureBox4.Image = off;
                setValueForMode = pictureBox5.Tag.ToString();

            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (pictureBox10.Image == on)
            {
                pictureBox10.Image = off;
            }
            else
            {
                pictureBox10.Image = on;
                pictureBox5.Image = off;
                pictureBox2.Image = off;
                pictureBox9.Image = off;
                pictureBox4.Image = off;
                setValueForMode = pictureBox10.Tag.ToString();

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pictureBox9.Image == on)
            {
                pictureBox9.Image = off;
            }
            else
            {
                pictureBox9.Image = on;
                pictureBox5.Image = off;
                pictureBox10.Image = off;
                pictureBox2.Image = off;
                pictureBox4.Image = off;
                setValueForMode = pictureBox9.Tag.ToString();

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.Image == on)
            {
                pictureBox4.Image = off;
            }
            else
            {
                pictureBox4.Image = on;
                pictureBox5.Image = off;
                pictureBox10.Image = off;
                pictureBox9.Image = off;
                pictureBox2.Image = off;
                setValueForMode = pictureBox4.Tag.ToString();

            }
        }
        //scedule button
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
            {
                setValueForTime = comboBox2.Text;
                setValueForDays = comboBox1.Text;
                setValueForRooms = comboBox3.Text;
                Scedule f = new Scedule();
                f.Show();
            }
            else if(comboBox1.Text=="")
            {
                MessageBox.Show("You haven't picked a day for your sceduled vaccuming");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("You haven't picked a time for your sceduled vaccuming");
            }
            else if (comboBox3.Text == "")
            {
                MessageBox.Show("You haven't picked any rooms for your sceduled vaccuming");

            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            map map = new map();
            map.Show();
        }
    }
}

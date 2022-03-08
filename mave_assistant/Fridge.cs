using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class Fridge : Form
    {
        bool Scanning=false;
        public static string setValueForTime = "";
        public static string setValueForDays = "";

        public Fridge()
        {
            InitializeComponent();
        }

        //scan button
        private void button2_Click(object sender, EventArgs e)
        {
            Scanning = true;
            timer1.Start();
            loading.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loading.Visible == true)
            {
                loading.Visible = false;

            }
            timer1.Stop();
            lastscan.Text = "Last Scan: Just Now";
            label23.Text = "300 gr";
            pictureBox9.Image = Properties.Resources.icons8_whole_apple_48;
            label15.Text = "250 gr";
            pictureBox6.Image = Properties.Resources.icons8_egg_carton_48;
            label10.Text = "1 pc";
            pictureBox11.Image = Properties.Resources.icons8_no_meat_48;
            label19.Text = "Unavailable";
            checkBox1.Text = "Stake";
            pictureBox14.Image = Properties.Resources.icons8_no_celery_48;
            label27.Text = "Unavailable";
            checkBox2.Text = "Celery";
            label23.Text = "100 gr";

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "" )
            {
                MessageBox.Show("You have successfully scheduled your Fridge Scan");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("You haven't picked a day for your sceduled scanning");
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("You haven't picked a time for your sceduled scanning");
            }
            
        }

        private void label35_Click(object sender, EventArgs e)
        {
            checkBox3.Text = "Pasta";
        }

        private void Fridge_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.icons8_cold_96;
        }

        private void panel17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = "https://www.ab.gr/";
            process.Start();
        }
    }
}

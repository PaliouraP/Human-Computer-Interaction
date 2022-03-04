using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class Washer : Form
    {
        string program = "";
        bool flag = false;
        TimeSpan timer; 
        double t = 0; //time until wash in minutes
        public Washer()
        {
            InitializeComponent();
        }

        private void changePicture(int percentage)
        {
            if (percentage < 15)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#ff0033");
                // progressBar.InnerColor = ColorTranslator.FromHtml("#4bb543");
                BinMessage.Text = "You need to add laundry detergent!";
            }
            else if (percentage >= 15 && percentage < 40)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#eed202");
                // progressBar.InnerColor = ColorTranslator.FromHtml("#eed202");
                BinMessage.Text = "You should consider adding laundry detergent!";

            }
            else
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#4bb543");
                //progressBar.InnerColor = ColorTranslator.FromHtml("#ff0033");
                BinMessage.Text = "No need to add laundry detergent yet!";
            }
        }

        private void Washer_Load(object sender, EventArgs e)
        {
            progressBar.Value = Login.SetValueForLaundryDetergent;
            progressBar.Text = Login.SetValueForLaundryDetergent.ToString() + "%";
            changePicture(Login.SetValueForLaundryDetergent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.SetValueForLaundryDetergent < 15)
            {
                MessageBox.Show("You need to add laundry detergent to the dishwasher first!");
            }
            else if (flag)
            {
                MessageBox.Show("You have already programmed a wash.");
            }
            else
            {
                flag = true;
                cancel_wash.Visible = true;
                string dt = dateTimePicker1.Value.ToString("HH:mm");
                string dtn = DateTime.Now.ToString("HH:mm");
                timer = DateTime.Parse(dt).Subtract(DateTime.Parse(dtn));
                if (timer.CompareTo(TimeSpan.Zero) < 0)
                {
                    timer = timer.Add(TimeSpan.Parse("24:00:00"));
                }
                t = timer.TotalMinutes + Int32.Parse(duration_lbl.Text);
                timer1.Interval = Convert.ToInt32(t) * 60000;
                timer1.Enabled = true;
                MessageBox.Show("Programmed " + program + " wash at " + dateTimePicker1.Text + " succesfully!");
            }
        }

        private void time_lbl_Click(object sender, EventArgs e)
        {

        }

        private void eco_btn_Click(object sender, EventArgs e)
        {
            program = "Economy";
            temperature_lbl.Text = "20°C";
            spins_lbl.Text = "1000";
            duration_lbl.Text = "60";
        }

        private void delicate_btn_Click(object sender, EventArgs e)
        {
            program = "Delicate";
            temperature_lbl.Text = "30°C";
            spins_lbl.Text = "400";
            duration_lbl.Text = "180";
        }

        private void rapid_btn_Click(object sender, EventArgs e)
        {
            program = "Rapid";
            temperature_lbl.Text = "30°C";
            spins_lbl.Text = "1000";
            duration_lbl.Text = "30";
        }

        private void cotton_lbl_Click(object sender, EventArgs e)
        {
            program = "Cotton";
            temperature_lbl.Text = "40°C";
            spins_lbl.Text = "1000";
            duration_lbl.Text = "180";
        }

        private void intense_btn_Click(object sender, EventArgs e)
        {
            program = "Intensive";
            temperature_lbl.Text = "60°C";
            spins_lbl.Text = "1000";
            duration_lbl.Text = "180";
        }

        private void wool_btn_Click(object sender, EventArgs e)
        {
            program = "Wool";
            temperature_lbl.Text = "40°C";
            spins_lbl.Text = "800";
            duration_lbl.Text = "180";
        }

        private void cancel_wash_Click(object sender, EventArgs e)
        {
            flag = false;
            cancel_wash.Visible = false;
            MessageBox.Show("Canceled programmed wash succesfully!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flag = false;
            cancel_wash.Visible = false;
            MessageBox.Show("Wash concluded");
            timer1.Enabled = false; //wash ended
        }
    }
}

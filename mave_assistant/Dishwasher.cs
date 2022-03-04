using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class Dishwasher : Form
    {
        string program = "";
        bool flag = false;
        TimeSpan timer;
        double t = 0; //time until wash in minutes
        public Dishwasher()
        {
            InitializeComponent();
            
        }

        private void changePicture(int percentage)
        {
            if (percentage < 15)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#ff0033");
                // progressBar.InnerColor = ColorTranslator.FromHtml("#4bb543");
                BinMessage.Text = "You need to add dish soap!";
            }
            else if (percentage >= 15 && percentage < 40)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#eed202");
                // progressBar.InnerColor = ColorTranslator.FromHtml("#eed202");
                BinMessage.Text = "You should consider adding dish soap!";
                
            }
            else
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#4bb543");
                //progressBar.InnerColor = ColorTranslator.FromHtml("#ff0033");
                BinMessage.Text = "No need to add dish soap yet!";
            }
        }

        private void wash_btn_Click(object sender, EventArgs e)
        {
            if (Login.SetValueForDishSoap < 15)
            {
                MessageBox.Show("You need to add dish soap to the dishwasher first!");
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

        private void Dishwasher_Load(object sender, EventArgs e)
        {
            progressBar.Value = Login.SetValueForDishSoap;
            progressBar.Text = Login.SetValueForDishSoap.ToString() + "%";
            changePicture(Login.SetValueForDishSoap);
        }

        private void eco_btn_Click(object sender, EventArgs e)
        {
            program = "Economy";
            temperature_lbl.Text = "45°C";
            duration_lbl.Text = "120";
        }

        private void delicate_btn_Click(object sender, EventArgs e)
        {
            program = "Delicate";
            temperature_lbl.Text = "40°C";
            duration_lbl.Text = "150";
        }

        private void intensive_lbl_Click(object sender, EventArgs e)
        {
            program = "Intensive";
            temperature_lbl.Text = "70°C";
            duration_lbl.Text = "180";
        }

        private void normal_btn_Click(object sender, EventArgs e)
        {
            program = "Normal";
            temperature_lbl.Text = "55°C";
            duration_lbl.Text = "150";
        }

        private void half_load_btn_Click(object sender, EventArgs e)
        {
            program = "Half Load";
            temperature_lbl.Text = "55°C";
            duration_lbl.Text = "75";
        }

        private void rapid_btn_Click(object sender, EventArgs e)
        {
            program = "Rapid";
            temperature_lbl.Text = "50°C";
            duration_lbl.Text = "30";
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

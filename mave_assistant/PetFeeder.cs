using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class pet_feeder : Form
    {
        public static bool food = false;
        public static bool water = false;
        public static bool cancel_f = true;
        public static bool cancel_w = true;
        public static int p;
        public pet_feeder()
        {
            InitializeComponent();
        }

        private void changePicture(int percentage)
        {
            if (percentage < 15)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#ff0033");
            }
            else if (percentage >= 15 && percentage < 40)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#eed202");

            }
            else
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#4bb543");
            }
        }

        private void changePicture1(int percentage)
        {
            if (percentage < 10)
            {
                progressBar1.ProgressColor = ColorTranslator.FromHtml("#ff0033");
            }
            else if (percentage >= 10 && percentage < 40)
            {
                progressBar1.ProgressColor = ColorTranslator.FromHtml("#eed202");

            }
            else
            {
                progressBar1.ProgressColor = ColorTranslator.FromHtml("#4bb543");
            }
        }

        private void PetFeeder_Load(object sender, EventArgs e)
        {
            pet_feeder_cam.ImageLocation = "Resources\\cat-curious.gif";

            //Water
            progressBar.Value = Login.SetValueForWater;
            progressBar.Text = Login.SetValueForWater.ToString() + "%";
            changePicture(Login.SetValueForWater);

            //Food
            progressBar1.Value = Login.SetValueForFood;
            progressBar1.Text = Login.SetValueForFood.ToString() + "%";
            changePicture1(Login.SetValueForFood);
        }

        private void cancel_feed_Click(object sender, EventArgs e)
        {
            food = false;
            cancel_feed.Visible = food;
            feed_btn.Visible = !food;
        }

        private void cancel_water_Click(object sender, EventArgs e)
        {
            water = false;
            cancel_water.Visible = water;
            water_btn.Visible = !water;
        }

        private void feed_btn_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 10)
            {
                MessageBox.Show("Not enough dry food in the pet feeder's container to conclude this action!");
            }
            else
            {
                PetFeeder_Feed f = new PetFeeder_Feed();
                f.ShowDialog();
                cancel_feed.Visible = food;
                feed_btn.Visible = !food;
                if (!cancel_f)
                {
                    progressBar1.Value = progressBar1.Value - p;
                    progressBar1.Text = progressBar1.Value.ToString() + "%";
                    changePicture1(progressBar1.Value);
                    cancel_f = true;
                }
            }
            
            
        }

        private void water_btn_Click(object sender, EventArgs e)
        {
            PetFeeder_Water f = new PetFeeder_Water();
            f.ShowDialog();
            cancel_water.Visible = water;
            water_btn.Visible = !water;
            if (!cancel_w)
            {
                progressBar.Value = 100;
                progressBar.Text = "100%";
                progressBar.ProgressColor = ColorTranslator.FromHtml("#4bb543");
                cancel_w = true;
            }
            
        }
    }
}

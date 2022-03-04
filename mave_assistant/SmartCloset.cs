﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class SmartCloset : Form
    {
        Random random = new Random();
        //List<string> list = new List<string>(); 
        public List<string> formal = new List<string>() 
        {"Resources\formal1.png","Resources\formal4.png","Resources\formal3.png","Resources\formal2.png"};
        bool ImageChosen = false;

        public SmartCloset()
        {
            InitializeComponent();

        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            foreach (Control x in panel1.Controls)
            {
                if (x is PictureBox)
                {
                    ((PictureBox)x).BackColor = Color.Transparent;
                }
            }
            if (category.Text == "Formal")
            {
                category.Text = "Athletic";
                changeImages(2);
            }
            else if (category.Text == "Athletic")
            {
                category.Text = "Casual";
                changeImages(3);
            }
            else if (category.Text == "Casual")
            {
                category.Text = "Night out";
                changeImages(4);
            }
            else 
            {
                category.Text = "Formal";
                changeImages(1);
            }
        }
        private void changeImages(int num)
        {
            switch (num)
            {
                //gallery of formal outfits
                case 1:
                    pictureBox1.Image = Properties.Resources.formal12;
                    pictureBox2.Image = Properties.Resources.formal21;
                    pictureBox3.Image = Properties.Resources.formal3;
                    pictureBox4.Image = Properties.Resources.formal42;
                    break;
                    //gallery of athletic outfits
                case 2:
                    pictureBox1.Image = Properties.Resources.athletic_summer;
                    pictureBox2.Image = Properties.Resources.athletic_spring1;
                    pictureBox3.Image = Properties.Resources.athletic_winter;
                    pictureBox4.Image = Properties.Resources.athletic_fall1;
                    break;
                    //gallery of casualoutfits
                case 3:
                    pictureBox1.Image = Properties.Resources.casual1;
                    pictureBox2.Image = Properties.Resources.mycasual1;
                    pictureBox3.Image = Properties.Resources.casual3;
                    pictureBox4.Image = Properties.Resources.casual4;
                    break;
                    //gallery of nightout outfits
                case 4:
                    pictureBox1.Image = Properties.Resources.nightout1;
                    pictureBox2.Image = Properties.Resources.nightout2;
                    pictureBox3.Image = Properties.Resources.nightout3;
                    pictureBox4.Image = Properties.Resources.nightout4;
                    break;
            }
        }

        private void SmartCloset_Load(object sender, EventArgs e)
        {
            PictureBox picture;
            panel1.Visible = false;
            if (category.Text == "Formal")
            {
                changeImages(1);
             
            }
            if (label2.Text == "Formal")
            {
                TodaysOutfit(1);
            }

            message.Text = Login.SetValueForWeather + " Weather";
            DateTime d = DateTime.Now;
            date.Text = d.ToString("MM.dd");
            if (Login.SetValueForWeather == "Sunny")
            {
                pictureBox6.Image = Properties.Resources.sunny_weather;
            }
            else
            {
                pictureBox6.Image = Properties.Resources.heavy_rain;

            }

        }
       
        private void upload_btn_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            panel1.Visible = true;
            
        }

        private void todays_outfit_btn_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
            }
            panel2.Visible = true;
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pictureBox3.BackColor == Color.Transparent)
            {
                pictureBox3.BackColor = ColorTranslator.FromHtml("#ecebf0");
                ImageChosen = true;
            }
            else
            {
                pictureBox3.BackColor = Color.Transparent;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.BackColor == Color.Transparent)
            {
                pictureBox2.BackColor = ColorTranslator.FromHtml("#ecebf0");
                ImageChosen = true;
            }            
            else 
            {
                pictureBox2.BackColor = Color.Transparent; 
            } 

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (pictureBox4.BackColor == Color.Transparent)
            {
                pictureBox4.BackColor = ColorTranslator.FromHtml("#ecebf0");
                ImageChosen = true;
            }
            else
            {
                pictureBox4.BackColor = Color.Transparent;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackColor == Color.Transparent)
            {
                pictureBox1.BackColor = ColorTranslator.FromHtml("#ecebf0");
                ImageChosen = true;
            }
            else
            {
                pictureBox1.BackColor = Color.Transparent;
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            ImageChosen = false;
            foreach (Control x in panel1.Controls)
            {
                if(x is PictureBox)
                {
                    ((PictureBox)x).BackColor = Color.Transparent;
                }
            }
            if (category.Text == "Formal")
            {
                category.Text = "Night out";
                changeImages(4);
            }
            else if (category.Text == "Night out")
            {
                category.Text = "Casual";
                changeImages(3);
            }
            else if (category.Text == "Casual")
            {
                category.Text = "Athletic";
                changeImages(2);
            }
            else
            {
                category.Text = "Formal";
                changeImages(1);
            }
        }

        //Today's outfit Panel

        private void button1_Click(object sender, EventArgs e)
        {
            if (ImageChosen == true)
            {
                MessageBox.Show("Successfully added to your Smart Closet!");
            }
            else
            {
                MessageBox.Show("You haven't picked an outfit!");
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Formal")
            {
                label2.Text = "Athletic";
                TodaysOutfit(2);

            }
            else if (label2.Text == "Athletic")
            {
                label2.Text = "Casual";
                TodaysOutfit(3);
            }
            else if (label2.Text == "Casual")
            {
                label2.Text = "Night out";
                TodaysOutfit(4);
            }
            else
            {
                label2.Text = "Formal";
                TodaysOutfit(1);
                
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (label2.Text == "Formal")
            {
                label2.Text = "Night out";
                TodaysOutfit(4);
            }
            else if (label2.Text == "Night out")
            {
                label2.Text = "Casual";
                TodaysOutfit(3);
            }
            else if (label2.Text == "Casual")
            {
                label2.Text = "Athletic";
                TodaysOutfit(2);
            }
            else
            {
                label2.Text = "Formal"; 
                TodaysOutfit(1);
            }
        }

        private void TodaysOutfit(int number)
        {
            switch (number)
            {
                //formal
                case 1:
                    if (Login.SetValueForWeather == "Sunny")
                    {
                        Outfit.Image = Properties.Resources.myformal1;
                        Warning.Text = "The weather is great!";

                    }
                    else
                    {

                        Outfit.Image = Properties.Resources.error;
                        
                        Warning.Text = "Oh no! ";
                    }
                    break;
                    //athletic
                case 2:
                    if (Login.SetValueForWeather == "Sunny")
                    {
                        Outfit.Image = Properties.Resources.myathletic1;
                        Warning.Text = "What a beautiful day \nto workout outdoors!";
                    }
                    else
                    {
                        Outfit.Image = Properties.Resources.myathletic2;
                        Warning.Text = "I suggest you don't \ntrain outdoors due to \n the weather!";
                    }
                    break;
                case 3:
                    if (Login.SetValueForWeather == "Sunny")
                    {
                        Outfit.Image = Properties.Resources.error;
                        Warning.Text = "Oh no!";

                    }
                    else
                    {
                        Outfit.Image = Properties.Resources.mycasual2;
                        Warning.Text = "Don't forget your \numbrella!";

                    }
                    break;
                case 4:
                    if (Login.SetValueForWeather == "Sunny")
                    {
                        Outfit.Image = Properties.Resources.mynightout2;
                        Warning.Text = "Have fun!";

                    }
                    else
                    {
                        Outfit.Image = Properties.Resources.mynightout1;
                        Warning.Text = "Have fun and don't \nforget your umbrella!";
                    }
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = "https://www.zara.com/gr/";
            proc.Start();
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myCloset closet = new myCloset();
            closet.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

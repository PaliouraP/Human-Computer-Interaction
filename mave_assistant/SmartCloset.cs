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
    public partial class SmartCloset : Form
    {
        Random random = new Random();
        //List<string> list = new List<string>(); 
        public static List<Outfit> outfits = new List<Outfit>();
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
                    pictureBox1.ImageLocation = "Resources/formal11.png";
                    pictureBox2.ImageLocation = "Resources/formal2.png";
                    pictureBox3.ImageLocation = "Resources/formal3.png";
                    pictureBox4.ImageLocation = "Resources/formal4.png";
                    break;
                    //gallery of athletic outfits
                case 2:
                    pictureBox1.ImageLocation = "Resources/athletic_summer.png";
                    pictureBox2.ImageLocation = "Resources/athletic_spring.png";
                    pictureBox3.ImageLocation = "Resources/athletic_winter.png";
                    pictureBox4.ImageLocation = "Resources/athletic_fall.png";
                    break;
                    //gallery of casualoutfits
                case 3:
                    pictureBox1.ImageLocation = "Resources/casual1.png";
                    pictureBox2.ImageLocation = "Resources/casual2.png";
                    pictureBox3.ImageLocation = "Resources/casual3.png";
                    pictureBox4.ImageLocation = "Resources/casual4.png";
                    break;
                    //gallery of nightout outfits
                case 4:
                    pictureBox1.ImageLocation = "Resources/nightout1.png";
                    pictureBox2.ImageLocation = "Resources/nightout2.png";
                    pictureBox3.ImageLocation = "Resources/nightout3.png";
                    pictureBox4.ImageLocation = "Resources/nightout4.png";
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

            Outfit casual1 = new Outfit(false, "Resources/casual1.png", "casual");
            Outfit casual2 = new Outfit(false, "Resources/casual2.png", "casual");
            Outfit casual3 = new Outfit(false, "Resources/casual3.png", "casual");
            Outfit casual4 = new Outfit(false, "Resources/casual4.png", "casual");
            Outfit mycasual1 = new Outfit(true, "Resources/mycasual1.png", "casual");
            Outfit mycasual2 = new Outfit(true, "Resources/mycasual2.png", "casual");

            Outfit formal1 = new Outfit(false, "Resources/formal11.png", "formal");
            Outfit formal2 = new Outfit(false, "Resources/formal2.png", "formal");
            Outfit formal3 = new Outfit(false, "Resources/formal3.png", "formal");
            Outfit formal4 = new Outfit(false, "Resources/formal4.png", "formal");
            Outfit myformal1 = new Outfit(true, "Resources/myformal1.png", "formal");
            Outfit myformal2 = new Outfit(true, "Resources/myformal21.png", "formal");

            Outfit nightout1 = new Outfit(false, "Resources/nightout1.png", "nightout");
            Outfit nightout2 = new Outfit(false, "Resources/nightout2.png", "nightout");
            Outfit nightout3 = new Outfit(false, "Resources/nightout3.png", "nightout");
            Outfit nightout4 = new Outfit(false, "Resources/nightout4.png", "nightout");
            Outfit mynightout1 = new Outfit(true, "Resources/mynightout1.png", "nightout");
            Outfit mynightout2 = new Outfit(true, "Resources/mynightout2.png", "nightout");

            Outfit athletic_fall = new Outfit(false, "Resources/athletic_fall.png", "athletic");
            Outfit athletic_spring = new Outfit(false, "Resources/athletic_spring.png", "athletic");
            Outfit athletic_summer = new Outfit(false, "Resource/athletic_summer.png", "athletic");
            Outfit athletic_winter = new Outfit(false, "Resources/athletic_winter.png", "athletic");
            Outfit myathletic1 = new Outfit(true, "Resources/myathletic1.png", "athletic");
            Outfit myathletic2 = new Outfit(true, "Resources/myathletic2.png", "athletic");

            outfits.Add(casual1);
            outfits.Add(casual2);
            outfits.Add(casual3);
            outfits.Add(casual4);
            outfits.Add(mycasual1);
            outfits.Add(mycasual2);

            outfits.Add(formal1);
            outfits.Add(formal2);
            outfits.Add(formal3);
            outfits.Add(formal4);
            outfits.Add(myformal1);
            outfits.Add(myformal2);

            outfits.Add(nightout1);
            outfits.Add(nightout2);
            outfits.Add(nightout3);
            outfits.Add(nightout4);
            outfits.Add(mynightout1);
            outfits.Add(mynightout2);

            outfits.Add(athletic_fall);
            outfits.Add(athletic_spring);
            outfits.Add(athletic_summer);
            outfits.Add(athletic_winter);
            outfits.Add(myathletic1);
            outfits.Add(myathletic2);
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
            if (pictureBox1.BackColor != Color.Transparent || pictureBox2.BackColor != Color.Transparent || pictureBox3.BackColor != Color.Transparent || pictureBox4.BackColor != Color.Transparent)
            {
                if (pictureBox1.BackColor != Color.Transparent)
                {
                    foreach (Outfit obj in outfits)
                    {
                        if (obj.pic == pictureBox1.ImageLocation)
                        {
                            obj.available = true;
                        }
                    }
                }

                if (pictureBox2.BackColor != Color.Transparent)
                {
                    foreach (Outfit obj in outfits)
                    {
                        if (obj.pic == pictureBox2.ImageLocation)
                        {
                            obj.available = true;
                        }
                    }
                }
                
                if (pictureBox3.BackColor != Color.Transparent)
                {
                    foreach (Outfit obj in outfits)
                    {
                        if (obj.pic == pictureBox3.ImageLocation)
                        {
                            obj.available = true;
                        }
                    }
                }
                
                if (pictureBox4.BackColor != Color.Transparent)
                {
                    foreach (Outfit obj in outfits)
                    {
                        if (obj.pic == pictureBox4.ImageLocation)
                        {
                            obj.available = true;
                        }
                    }
                }

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

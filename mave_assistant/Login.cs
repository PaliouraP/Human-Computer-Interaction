using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace mave_assistant
{
    public partial class Login : Form
    {
        String connectionString = "Data Source=mave.db;Version=3;";
        SQLiteConnection conn;

        public static string SetValueUsername = "";
        public static string SetValuePassword = "";
        public static bool SetValueForCheckBox1; // remember me
        bool f = false;
        public static int SetValueForPercentage; //in form Bin
        public static string SetValueForWeather; //in form Smart Closet
        public static int SetValueForDishSoap; //in form Dish Washer
        public static int SetValueForLaundryDetergent; //in form Washing Machine
        public static int SetValueForWater; //in form Pet feeder
        public static int SetValueForFood; //in form Pet feeder

        public Login()
        {
            InitializeComponent();
            
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp f = new SignUp();
            f.Show(); //shows Sign Up
            this.Hide(); //hides Login
        }


        private void Login_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString); //connecting database
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueUsername = textBox1.Text;
            SetValuePassword = textBox2.Text;
            SetValueForCheckBox1 = checkBox1.Checked;
            Random random = new Random();
            //bin percentage
            int percentage = random.Next(1, 100);
            //dish soap percentage
            int percentageDS = random.Next(1, 100);
            //laundry detergent percentage
            int percentageLD = random.Next(1, 100);
            //pet feeder water percentage
            int percentageWater = random.Next(1, 100);
            //pet feeder food percentage
            int percentageFood = random.Next(1, 100);
            //weather
            List<string> weather = new List<string>() {"Sunny","Rainy" };
            int index = random.Next(weather.Count);
            string randomWeather = weather[index];

            String selectQuery = "Select username from users where username=@user and password=@pass";

            //SQL commands are called in a using(){} environment in order to avoid unintended locking of the database
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, conn))
            {
                conn.Open(); //opening database
                command.Parameters.AddWithValue("@user", textBox1.Text); //setting parameter @user as user's username
                command.Parameters.AddWithValue("@pass", textBox2.Text); //setting parameter @user as user's password
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    //checking if user and password match
                    if (reader.Read())
                    {
                        f = true;
                    }
                    else
                    {
                        f = false;
                        MessageBox.Show("Username or password incorrect.");
                    }

                }
                conn.Close();//closing database

                //opening homescreen if username and password correct
                if (f)
                {
                    SetValueForPercentage = percentage;
                    SetValueForWeather = randomWeather;
                    SetValueForDishSoap = percentageDS;
                    SetValueForLaundryDetergent = percentageLD;
                    SetValueForWater = percentageWater;
                    SetValueForFood = percentageFood;
                    home_screen_form f = new home_screen_form();
                    f.Show(); //shows home screen                 
                    this.Hide(); //hides Login


                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
    }
  
}
    


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class smart_living : Form
    {

        // Initializing a local reference to mave maps images
        Image home_university = Properties.Resources.home_uni;
        Image university_home = Properties.Resources.uni_home;
        Image hm_gym = Properties.Resources.home_gym;
        Image gym_hm = Properties.Resources.gym_home;
        Image university_gym = Properties.Resources.uni_gym;
        Image gym_university = Properties.Resources.gym_uni;
        Image attica = Properties.Resources.attica_map;


        public smart_living()
        {
            InitializeComponent();
        }


        private void smart_living_Load(object sender, EventArgs e)
        {
            progressBar.Value = Login.SetValueForPercentage;
            progressBar.Text = Login.SetValueForPercentage.ToString() + "%";
            changePicture(Login.SetValueForPercentage);
        }
        private void changePicture(int percentage)
        {
            if (percentage < 60)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#4bb543");
                // progressBar.InnerColor = ColorTranslator.FromHtml("#4bb543");
                BinMessage.Text = "No need to take the trash out yet!";
            }
            else if (percentage >= 60 && percentage < 75)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#eed202");
                // progressBar.InnerColor = ColorTranslator.FromHtml("#eed202");
                BinMessage.Text = "You should consider taking the trash out!";
            }
            else
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#ff0033");
                //progressBar.InnerColor = ColorTranslator.FromHtml("#ff0033");
                BinMessage.Text = "You need to take the trash out!";
            }
        }

        // MAVE MAPS ---------------------------------------------------------------------

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {

        }
        private void car_MouseMove(object sender, MouseEventArgs e)
        {

        }

        string transport_option;
        public Image fastest_route;

        // Mouse Enter and Leave Events for car icon
        private void car_MouseEnter(object sender, EventArgs e)
        {
            car.BorderStyle = BorderStyle.FixedSingle;
        }
        private void car_MouseLeave(object sender, EventArgs e)
        {
            car.BorderStyle = BorderStyle.None;
        }
        private void car_Click(object sender, EventArgs e)
        {
            car.BorderStyle = BorderStyle.FixedSingle;
            transport_option = "Car";
            car.BackColor = Color.Gray;
        }

        // Mouse Enter and Leave Events for public_transport icon
        private void public_transport_MouseEnter(object sender, EventArgs e)
        {
            public_transport.BorderStyle = BorderStyle.FixedSingle;
        }
        private void public_transport_MouseLeave(object sender, EventArgs e)
        {
            public_transport.BorderStyle = BorderStyle.None;
        }
        private void public_transport_Click(object sender, EventArgs e)
        {
            public_transport.BorderStyle = BorderStyle.FixedSingle;
            transport_option = "Public Transport";
            public_transport.BackColor = Color.Gray;
        }

        // Mouse Enter and Leave Events for walk icon
        private void walk_MouseEnter(object sender, EventArgs e)
        {
            walk.BorderStyle = BorderStyle.FixedSingle;
        }
        private void walk_MouseLeave(object sender, EventArgs e)
        {
            walk.BorderStyle = BorderStyle.None;
        }
        private void walk_Click(object sender, EventArgs e)
        {
            walk.BorderStyle = BorderStyle.FixedSingle;
            transport_option = "Walking";
            walk.BackColor = Color.Gray;

        }


        // Search route click event
        private void search_route_Click(object sender, EventArgs e)
        {

            if (from.Text == "" || to.Text == "" || stop.Text == "" || transport_option == null || time.Text == "")
            {
                MessageBox.Show("There are empty fields.", "Empty fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                // Changing the image of map picture box based on the chosen route
                if (from.Text == "Home" && to.Text == "University of Piraeus")
                {
                    map.Image = home_university;
                }
                else if (from.Text == "University of Piraeus" && to.Text == "Home")
                {
                    map.Image = university_home;
                }
                else if (from.Text == "University of Piraeus" && to.Text == "Gym")
                {
                    map.Image = university_gym;
                }
                else if (from.Text == "Gym" && to.Text == "University of Piraeus")
                {
                    map.Image = gym_university;
                }
                else if (from.Text == "Gym" && to.Text == "Home")
                {
                    map.Image = gym_hm;
                }
                else if (from.Text == "Home" && to.Text == "Gym")
                {
                    map.Image = hm_gym;
                }
                else if ((from.Text == "Home" && to.Text == "Home") || (from.Text == "Gym" && to.Text == "Gym") || (from.Text == "University of Piraeus" && to.Text == "University of Piraeus"))
                {
                    map.Image = attica;
                    from.Text = "Home";
                    to.Text = "University of Piraeus";
                    MessageBox.Show("This route is unavailable. Please make sure you have inserted correctly the origin and destination point.", "Unavailable Route",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                string beggining = from.Text;
                string destination = to.Text;
                string stop_for = stop.Text;
                string arrive_time = time.Text;


                fastest_route = map.Image;
                map_details f2 = new map_details(fastest_route, beggining, destination, stop_for, arrive_time, transport_option);
                f2.ShowDialog(); // Shows Form2

            }









        }


    }
}

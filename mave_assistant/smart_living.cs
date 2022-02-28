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
            
        }

        
        // Search route click event
        private void search_route_Click(object sender, EventArgs e)
        {
            string beggining = from.Text;
            string destination = to.Text;
            string stop_for = stop.Text;
            string depart_time = time.Text;
            
            MessageBox.Show("Route Details\n" +
                "From: " + beggining + "\n" +
                "To: " + destination + "\n" +
                "By: " + transport_option + "\n" +
                "Stop for: " + stop_for + " at Coffee Island (G. Lampraki 107, 185 34)\n" +
                "Arrive by: " + depart_time + "\n" +
                "Depart by: 09:00\n" +
                "Parking Spot: Available inside University of Piraeus parking lot");
            
        }
        

    }
}

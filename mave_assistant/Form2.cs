using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class map_details : Form
    {
        public map_details(Image route, string origin, string destination, string stop, string arrival_time, string trasnport)
        {
            InitializeComponent();
            // Parameters from smart_living form
            map.Image = route;
            from_label.Text = origin;
            to_label.Text = destination;
            trasnport_label.Text = trasnport;
            stop_label.Text = stop;
            arrive_label.Text = arrival_time;
            depart_label.Text = "45 minutes earlier";
        

            if (trasnport == "Car")
            {
                parking_label.Text = "Parking Spot Available";
                traffic_label.Text = "Usual Traffic";

                if (destination == "Home")
                {
                    parking_place_label.Text = "Inside Home Parking Lot";
                }
                else if (destination == "University of Piraues")
                {
                    parking_place_label.Text = "Inside Home Parking Lot";
                }
                else if (destination == "Gym")
                {
                    parking_place_label.Text = "Inside Gym Parking Lot";
                }
            } else
            {
                traffic_label.Text = "None";
                parking_label.Text = "None";
                parking_place_label.Text = "None";
            }
            

            // Setting stop location
            if (stop == "Coffee")
            {
                stop_place_label.Text = "Coffee Island";
            }
            else if (stop == "Food")
            {
                stop_place_label.Text = "Everest";
            }
            else if (stop == "Gas")
            {
                stop_place_label.Text = "Shell";
            }
            else if (stop == "ATM")
            {
                stop_place_label.Text = "Eurobank ATM";
            }
            else if (stop == "None")
            {
                stop_place_label.Text = "None";
            }
        }

        private void map_details_Load(object sender, EventArgs e)
        {
 
        }
    }
}

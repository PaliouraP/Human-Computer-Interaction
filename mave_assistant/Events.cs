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
    public partial class Events : Form
    {
        String connectionString = "Data Source=mave.db;Version=3;";
        SQLiteConnection conn;

        public Events()
        {
            InitializeComponent();
        }

        private void Events_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString); //connecting database  

            date_lbl.Text = planner.static_year + "-" + planner.static_month + "-" + UserControlDays.static_day;

            

            //SQL commands are called in a using(){} environment in order to avoid unintended locking of the database
            String selectQuery = "Select * from events where username='" + planner.username + "' and date='" + date_lbl.Text + "'";
            
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, conn))
            {
                conn.Open(); //opening database
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) //while an event exists on a certain day
                    {
                        UserControlEvents current_events = new UserControlEvents();
                        current_events.type.Text = reader.GetString(1);
                        current_events.details.Text = reader.GetString(3);
                        current_events.date.Text = "";
                        current_events.delete.Hide();

                        if (reader.GetString(1) == "Social")
                        {
                            current_events.dot.Load("Resources/dot1.png");
                            
                        }
                        else if (reader.GetString(1) == "Work")
                        {
                            current_events.dot.Load("Resources/dot2.png");
                            
                        }
                        else if (reader.GetString(1) == "Appointment")
                        {
                            current_events.dot.Load("Resources/dot3.png");
                            
                        }
                        else if (reader.GetString(1) == "Other")
                        {
                            current_events.dot.Load("Resources/dot4.png");
                            
                        }
                        current_events_container.Controls.Add(current_events);

                    }
                    
                    conn.Close(); //closing database
                    
                }
                
            }
        }

        private void Events_Leave(object sender, EventArgs e)
        {

        }
    }
}

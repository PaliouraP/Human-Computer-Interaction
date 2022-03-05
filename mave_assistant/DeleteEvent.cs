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
    public partial class DeleteEvent : Form
    {
        String connectionString = "Data Source=mave.db;Version=3;";
        SQLiteConnection conn;
        public DeleteEvent()
        {
            InitializeComponent();
        }

        private void DeleteEvent_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString); //connecting database  

            //SQL commands are called in a using(){} environment in order to avoid unintended locking of the database
            String selectQuery = "Select * from events where username='" + planner.username + "'";

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
                        current_events.date.Text = reader.GetString(2);

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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the selected events?", "Digital Planner", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                String deleteQuery = "Delete from events where username=@user and date=@date and type=@type";

                //SQL commands are called in a using(){} environment in order to avoid unintended locking of the database
                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, conn))
                {
                    conn.Open(); //opening database
                    foreach (Event evnt in UserControlEvents.events_to_delete)
                    {
                        command.Parameters.AddWithValue("@user", evnt.username);
                        command.Parameters.AddWithValue("@date", evnt.date);
                        command.Parameters.AddWithValue("@type", evnt.type);
                        command.ExecuteNonQuery();

                    }

                    conn.Close(); //closing database
                }
                MessageBox.Show("Events deleted successfully!");
                this.Close(); //closes sign up
            }
        }
    }
}

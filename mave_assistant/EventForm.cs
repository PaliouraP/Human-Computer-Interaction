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
    public partial class EventForm : Form
    {
        String connectionString = "Data Source=mave.db;Version=3;";
        SQLiteConnection conn;

        public string username = "";
        public EventForm(string usr)
        {
            username = usr;
            InitializeComponent();
        }

        private void Social(object sender, EventArgs e)
        {

        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Event evnt = new Event();
            evnt.username = username;
            evnt.date = event_date.Value.ToString("yyyy-MMMM-dd");
            evnt.type = event_type.Text;
            evnt.details = event_details.Text;

            conn = new SQLiteConnection(connectionString); //connecting database  
            String insertQuery = "Insert into events(username, type, date, details) values('" + evnt.username + "', '" + evnt.type + "', '" + evnt.date + "', '" + evnt.details + "')";
            conn.Open(); //opening database
            using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("New event added succesfully!");
                conn.Close(); //closing database
                this.Close(); //closes sign up
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

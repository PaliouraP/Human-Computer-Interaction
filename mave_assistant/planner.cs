using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace mave_assistant
{
    
    public partial class planner : Form
    {
        String connectionString = "Data Source=mave.db;Version=3;";
        SQLiteConnection conn;

        public static string username = "";
        int month, year;

        public static string static_month = "";
        public static string static_year = "";
        public planner(string usr)
        {
            username = usr;
            InitializeComponent();
        }

        private void planner_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString); //connecting database  
            displayDays();
        }

        private void displayDays()
        {

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            
            String month_name = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            static_month = month_name;
            static_year = year.ToString();

            month_year_label.Text = month_name + " " + year;
            //Getting first day of the month
            DateTime startofmonth = new DateTime(year, month, 1);

            //Getting count of days of current month
            int days = DateTime.DaysInMonth(year, month);

            //Converting startofmonth to int
            int day = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;

            //Blank days
            for (int i = 1; i < day; i++)
            {
                UserControl1 uc1 = new UserControl1();
                day_container.Controls.Add(uc1);
            }

            //Days
            for (int i = 1; i <= days; i++)
            {
                string date_string = year + "-" + month_name + "-" + i; //the date format we save event dates in database

                UserControlDays ucdays = new UserControlDays();

                //SQL commands are called in a using(){} environment in order to avoid unintended locking of the database
                String selectQuery = "Select * from events where username='" + username + "' and date='" + date_string + "'";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, conn))
                {
                    conn.Open(); //opening database
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) //while an event exists on a certain day
                        {
                            if (reader.GetString(1) == "Social")
                            {
                                ucdays.dot1.Load("Resources/dot1.png");
                            }
                            if (reader.GetString(1) == "Work")
                            {
                                ucdays.dot2.Load("Resources/dot2.png");
                            }
                            if (reader.GetString(1) == "Appointment")
                            {
                                ucdays.dot3.Load("Resources/dot3.png");
                            }
                            if (reader.GetString(1) == "Other")
                            {
                                ucdays.dot4.Load("Resources/dot4.png");
                            }
                        }

                        conn.Close(); //closing database
                    }
                    ucdays.days(i);
                    day_container.Controls.Add(ucdays);
                }
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            //clear container
            day_container.Controls.Clear();

            //previous month
            month--;

            String month_name = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            static_month = month_name;
            static_year = year.ToString();

            month_year_label.Text = month_name + " " + year;

            DateTime startofmonth = new DateTime(year, month, 1);

            //Getting count of days of current month
            int days = DateTime.DaysInMonth(year, month);

            //Converting startofmonth to int
            int day = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;

            //Blank days
            for (int i = 1; i < day; i++)
            {
                UserControl1 uc1 = new UserControl1();
                day_container.Controls.Add(uc1);
            }

            //Days
            for (int i = 1; i <= days; i++)
            {
                string date_string = year + "-" + month_name + "-" + i; //the date format we save event dates in database

                UserControlDays ucdays = new UserControlDays();

                //SQL commands are called in a using(){} environment in order to avoid unintended locking of the database
                String selectQuery = "Select * from events where username='" + username + "' and date='" + date_string + "'";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, conn))
                {
                    conn.Open(); //opening database
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) //while an event exists on a certain day
                        {
                            if (reader.GetString(1) == "Social")
                            {
                                ucdays.dot1.Load("Resources/dot1.png");
                            }
                            if (reader.GetString(1) == "Work")
                            {
                                ucdays.dot2.Load("Resources/dot2.png");
                            }
                            if (reader.GetString(1) == "Appointment")
                            {
                                ucdays.dot3.Load("Resources/dot3.png");
                            }
                            if (reader.GetString(1) == "Other")
                            {
                                ucdays.dot4.Load("Resources/dot4.png");
                            }
                        }

                        conn.Close(); //closing database
                    }
                    ucdays.days(i);
                    day_container.Controls.Add(ucdays);
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            EventForm ev = new EventForm(username);
            ev.ShowDialog(); // Shows event form
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            //clear container
            day_container.Controls.Clear();

            //next month
            month++;

            String month_name = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);

            static_month = month_name;
            static_year = year.ToString();

            month_year_label.Text = month_name + " " + year;

            DateTime startofmonth = new DateTime(year, month, 1);

            //Getting count of days of current month
            int days = DateTime.DaysInMonth(year, month);

            //Converting startofmonth to int
            int day = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;

            //Blank days
            for (int i = 1; i < day; i++)
            {
                UserControl1 uc1 = new UserControl1();
                day_container.Controls.Add(uc1);
            }

            //Days
            for (int i = 1; i <= days; i++)
            {
                string date_string = year + "-" + month_name + "-" + i; //the date format we save event dates in database

                UserControlDays ucdays = new UserControlDays();

                //SQL commands are called in a using(){} environment in order to avoid unintended locking of the database
                String selectQuery = "Select * from events where username='" + username + "' and date='" + date_string + "'";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, conn))
                {
                    conn.Open(); //opening database
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read()) //while an event exists on a certain day
                        {
                            if (reader.GetString(1) == "Social")
                            {
                                ucdays.dot1.Load("Resources/dot1.png");
                            }
                            if (reader.GetString(1) == "Work")
                            {
                                ucdays.dot2.Load("Resources/dot2.png");
                            }
                            if (reader.GetString(1) == "Appointment")
                            {
                                ucdays.dot3.Load("Resources/dot3.png");
                            }
                            if (reader.GetString(1) == "Other")
                            {
                                ucdays.dot4.Load("Resources/dot4.png");
                            }
                        }

                        conn.Close(); //closing database
                    }
                    ucdays.days(i);
                    day_container.Controls.Add(ucdays);
                }
            }
        }
    }
}

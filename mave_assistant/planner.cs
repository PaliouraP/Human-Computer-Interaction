using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    
    public partial class planner : Form
    {
        string username = "";
        int month, year;
        public planner(string usr)
        {
            username = usr;
            InitializeComponent();
        }

        private void planner_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String month_name = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            month_year_label.Text = month_name + " " + year ;
            //Getting first day of the month
            DateTime startofmonth = new DateTime(year, month,1);

            //Getting count of days of current month
            int days = DateTime.DaysInMonth(year, month);

            //Converting startofmonth to int
            int day = Convert.ToInt32(startofmonth.DayOfWeek.ToString("d")) + 1;

            //Blank days
            for(int i = 1; i < day; i++)
            {
                UserControl1 uc1 = new UserControl1();
                day_container.Controls.Add(uc1);
            }

            //Days
            for(int i = 1; i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                day_container.Controls.Add(ucdays);
            }
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            //clear container
            day_container.Controls.Clear();

            //previous month
            month--;

            String month_name = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
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
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                day_container.Controls.Add(ucdays);
            }
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            //clear container
            day_container.Controls.Clear();

            //next month
            month++;

            String month_name = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
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
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                day_container.Controls.Add(ucdays);
            }
        }
    }
}

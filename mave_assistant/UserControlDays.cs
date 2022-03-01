using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class UserControlDays : UserControl
    {
        public static string static_day = "";
        public UserControlDays()
        {
            InitializeComponent();
        }


        public void days(int numday)
        {
            days_label.Text = numday + "";
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            static_day = days_label.Text;
            Events evnts = new Events();
            evnts.ShowDialog(); // Shows events form
        }

    }
}

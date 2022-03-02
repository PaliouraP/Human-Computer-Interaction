using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class UserControlEvents : UserControl
    {
        public static List<Event> events_to_delete = new List<Event>();
        public UserControlEvents()
        {
            InitializeComponent();
        }

        private void delete_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                // add username, type and date of event checked in the list
                Event ev = new Event();
                ev.username = planner.username;
                ev.date = date.Text;
                ev.type = type.Text;

                events_to_delete.Add(ev);
            }
            else
            {
                // remove username, type and date of event checked in the list
                Event ev = new Event();
                ev.username = planner.username;
                ev.date = date.Text;
                ev.type = type.Text;
                events_to_delete.Remove(ev);
            }

        }
    }
}

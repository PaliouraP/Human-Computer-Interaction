using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class Scedule : Form
    {
        public Scedule()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            time.Text = vacuumCleaner.setValueForTime;
            days.Text = vacuumCleaner.setValueForDays;
            rooms.Text = vacuumCleaner.setValueForRooms;
            mode.Text = vacuumCleaner.setValueForMode;
        }
    }
}

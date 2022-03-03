using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class Dishwasher : Form
    {
        public Dishwasher()
        {
            InitializeComponent();
            
        }

        private void wash_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed -insert program- wash at "+ dateTimePicker1.Text+" succesfully!");
        }
    }
}

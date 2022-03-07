using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class make_coffee : Form
    {
        public make_coffee(string type, string blend, string sugar, string milk)
        {
            InitializeComponent();
            type_lbl.Text = type;
            blend_lbl.Text = blend;
            m_s_lbl.Text = milk + " / " + sugar;
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scheduled coffee making on " + dateTimePicker1.Value + " at " + time.Text + ".");
            this.Close();
        }
    }
}

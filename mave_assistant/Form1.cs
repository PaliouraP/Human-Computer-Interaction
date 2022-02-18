using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class home_screen_form : Form
    {
        public home_screen_form()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        // Method that opens a single form isnide the container panel (panel_childform)
        private void openChildForm(Form childForm)
        {
            // If there is an open form, we close it
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;

            // Indicate that the childForm isn't at the top level
            childForm.TopLevel = false;

            // Remove the border of the form
            childForm.FormBorderStyle = FormBorderStyle.None;

            // Set dock property to fill the entire container panel (panel_childform)
            childForm.Dock = DockStyle.Fill;

            // Add the form to the list of controls of the container panel (panel_childform)
            panel_childform.Controls.Add(childForm);

            // Associate form with the container panel
            panel_childform.Tag = childForm;

            // Bring childForm to the front
            childForm.BringToFront();

            // Show the child form
            childForm.Show();
        }

        private void smart_home_btn_Click(object sender, EventArgs e)
        {
            // When clicking on "Smart Home" button, smart_home form appears
            openChildForm(new smart_home());
        }

        private void hello_label_Click(object sender, EventArgs e)
        {
        }

        private void home_screen_btn_Click(object sender, EventArgs e)
        {
            // If there is an open form, we close it, and home_screen appears, once again
            if (activeForm != null)
            {
                activeForm.Close();
            }

        }

        private void smart_living_btn_Click(object sender, EventArgs e)
        {
            // When clicking on "Smart Living" button, smart_living form appears
            openChildForm(new smart_living());
        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.ShowDialog(); // Shows Form2
        }

        private void panel_childform_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show(); //shows Login
            this.Close(); //closes home screen
        }
    }
}

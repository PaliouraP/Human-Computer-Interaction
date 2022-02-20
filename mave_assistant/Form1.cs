using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace mave_assistant
{
    public partial class home_screen_form : Form
    {
        String connectionString = "Data Source=mave.db;Version=3;";
        SQLiteConnection conn;

        User u = new User();

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

        private void account_btn_Click(object sender, EventArgs e)
        {
            // When clicking on "Account" button, account form appears
            openChildForm(new account(u.username, u.password, u.name, u.dob, u.picture, u.pet));
        }

        private void username_label_Click(object sender, EventArgs e)
        {
            // When clicking on your username, the acoount info form appears
            openChildForm(new account(u.username, u.password, u.name, u.dob, u.picture, u.pet));
        }

        private void home_screen_form_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString); //connecting database

            username_label.Text = Login.SetValueUsername;

            String selectQuery = "Select * from users where username=@user";

            //SQL commands are called in a using(){} environment in order to avoid unintended locking of the database
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, conn))
            {
                conn.Open();
                command.Parameters.AddWithValue("@user", Login.SetValueUsername);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        u.username = reader.GetString(0);
                        u.password = reader.GetString(2);
                        u.name = reader.GetString(1);
                        u.dob = reader.GetString(3);
                        u.picture = reader.GetString(4);
                        u.pet = reader.GetString(5);
                        user_icon2.ImageLocation = u.picture;
                        hello_label.Text = "Hello " + u.name;
                    }

                }
                conn.Close();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show(); //shows Login
            this.Close(); //closes home screen
        }

        private void digital_planner_btn_Click(object sender, EventArgs e)
        {
            // When clicking on your username, the acoount info form appears
            openChildForm(new planner(u.username));
        }
    }
}

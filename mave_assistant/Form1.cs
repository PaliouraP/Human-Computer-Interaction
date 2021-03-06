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
            dropDownMenu();
            //test notification
            UserControlNotifications ucnotif = new UserControlNotifications();
            ucnotif.title.Text = "Welcome Back!";
            ucnotif.details.Text = "Mave is happy to see you.";

            notification_container.Controls.Add(ucnotif);

            //alarm system notification 
            if (Login.SetValueForPercentage < 50)
            {
                UserControlNotifications alarm_notif = new UserControlNotifications();
                alarm_notif.title.Text = "Low Battery!";
                alarm_notif.details.Text = "Alarm system battery is low.";

                notification_container.Controls.Add(alarm_notif);
            }

            //trash notification 
            if (Login.SetValueForPercentage > 75)
            {
                UserControlNotifications trash_notif = new UserControlNotifications();
                trash_notif.title.Text = "Trash bin Full!";
                trash_notif.details.Text = "Take the trash out.";

                notification_container.Controls.Add(trash_notif);
            }

            //dish soap
            if (Login.SetValueForDishSoap < 15)
            {
                UserControlNotifications ds_notif = new UserControlNotifications();
                ds_notif.title.Text = "Out of Dish Soap!";
                ds_notif.details.Text = "Please refill the dish soap on your dish washer.";

                notification_container.Controls.Add(ds_notif);
            }

            //laundry detergent
            if (Login.SetValueForLaundryDetergent < 15)
            {
                UserControlNotifications ld_notif = new UserControlNotifications();
                ld_notif.title.Text = "Out of Laundry Detergent!";
                ld_notif.details.Text = "Please refill the laundry detergent on your washing machine.";

                notification_container.Controls.Add(ld_notif);
            }

            //dry food
            if (Login.SetValueForFood < 15)
            {
                UserControlNotifications df_notif = new UserControlNotifications();
                df_notif.title.Text = "Out of Dry Food!";
                df_notif.details.Text = "Please refill the dry food container on your pet feeder.";

                notification_container.Controls.Add(df_notif);
            }

            //pet feeder water
            if (Login.SetValueForWater < 15)
            {
                UserControlNotifications w_notif = new UserControlNotifications();
                w_notif.title.Text = "Out of Water!";
                w_notif.details.Text = "Your pet's water bowl is empty.";

                notification_container.Controls.Add(w_notif);
            }


        }

        // Method to show today's events
        public void todaysEvents()
        {
            DateTime now = DateTime.Now;
            string date_string = now.ToString("yyyy-MMMM-dd");

            //SQL commands are called in a using(){} environment in order to avoid unintended locking of the database
            String selectQuery = "Select * from events where username='" + Login.SetValueUsername + "' and date='" + date_string + "'";

            using (SQLiteCommand command = new SQLiteCommand(selectQuery, conn))
            {
                conn.Open(); //opening database
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) //while an event exists on a certain day
                    {
                        home_screen_events current_events = new home_screen_events();
                        current_events.type.Text = reader.GetString(1);
                        current_events.details.Text = reader.GetString(3);
                        // current_events.date.Text = "";
                        // current_events.delete.Hide();

                        if (reader.GetString(1) == "Social")
                        {
                            current_events.dot.Load("Resources/dot1.png");

                        }
                        else if (reader.GetString(1) == "Work")
                        {
                            current_events.dot.Load("Resources/dot2.png");

                        }
                        else if (reader.GetString(1) == "Appointment")
                        {
                            current_events.dot.Load("Resources/dot3.png");

                        }
                        else if (reader.GetString(1) == "Other")
                        {
                            current_events.dot.Load("Resources/dot4.png");

                        }
                        current_events_container.Controls.Add(current_events);

                    }

                    conn.Close(); //closing database

                }
            }
        }
        //Method that initially makes sub menus invisible
        private void dropDownMenu()
        {
            panelSmartLiving.Visible = false;
            panelSmartHome.Visible = false;
        }

        //Method that hides drop down sub menus if they are open
        private void hideSubMenu()
        {
            if (panelSmartLiving.Visible == true)
                panelSmartLiving.Visible = false;
            if (panelSmartHome.Visible == true)
                panelSmartHome.Visible = false;
        }


        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false; 
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

        

        private void home_screen_btn_Click(object sender, EventArgs e)
        {
            // If there is an open form, we close it, and home_screen appears, once again
            if (activeForm != null)
            {
                activeForm.Close();
            }

        }
        private void panel_childform_Paint(object sender, PaintEventArgs e)
        {

        }


        private void username_label_Click(object sender, EventArgs e)
        {
            // When clicking on your username, the acoount info form appears
            openChildForm(new account(u.username, u.password, u.name, u.dob, u.picture, u.pet));
        }

        private void home_screen_form_Load(object sender, EventArgs e)
        {
            //progress bar reset
            progressBarTasks.Value = 0;
            progressBarTasks.Text = "0%";
            conn = new SQLiteConnection(connectionString); //connecting database            
            username_label.Text = Login.SetValueUsername;
            //weather pictures 
            if (Login.SetValueForWeather == "Sunny")
            {
                foreach (Control x in (panel4.Controls))
                {
                    if (x is PictureBox && x.Tag!="Line")
                    {
                        ((PictureBox)x).Image = Properties.Resources.sunny_weather;
                    }
                }
            }
            else
            {
                foreach (Control x in panel4.Controls )
                {
                    if (x is PictureBox && x.Tag != "Line")
                    {
                        ((PictureBox)x).Image = Properties.Resources.heavy_rain;
                    }
                }
            }                  
                        
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

            todaysEvents();
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
               
           
        private void smart_living_btn_Click_1(object sender, EventArgs e)
        {
            // When clicking on "Smart Living" button, smart_living form appears
            openChildForm(new smart_living());
        }

        private void account_btn_Click_1(object sender, EventArgs e)
        {
            // When clicking on "Account" button, account form appears
            openChildForm(new account(u.username, u.password, u.name, u.dob, u.picture, u.pet));
        }

        // Help Scribble
        private void help_btn_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "mave_help.chm");
        }

        private void about_btn_Click_1(object sender, EventArgs e)
        {
            about about = new about();
            about.ShowDialog(); // Shows about form
        }

        private void smart_living_btn_MouseHover(object sender, EventArgs e)
        {
            showSubMenu(panelSmartLiving);
        }

        private void smart_home_btn_MouseHover(object sender, EventArgs e)
        {
            showSubMenu(panelSmartHome);
        }

        //Method that increases progress bar value when a checkbox is checked 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked && progressBarTasks.Value<83)
            {
                progressBarTasks.Value += 17;
                progressBarTasks.Text = progressBarTasks.Value.ToString() + "%";
            }
            else if(cb.Checked && progressBarTasks.Value >= 83)
            {
                progressBarTasks.Value = 100;
                MessageBox.Show("Congrats! You completed all of your tasks for today.");
                progressBarTasks.Text = progressBarTasks.Value.ToString() + "%";
            }
            else
            {
                progressBarTasks.Value -= 17;
                progressBarTasks.Text = progressBarTasks.Value.ToString() + "%";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new SmartCloset());
        }   
        private void progressBarTasks_Click(object sender, EventArgs e)
        {

        }

        // Smart doorbell button click event
        private void button6_Click(object sender, EventArgs e)
        {
            /*smart_doorbell sd = new smart_doorbell();
            sd.ShowDialog();*/
            openChildForm(new smart_doorbell());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openChildForm(new Washer());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openChildForm(new Dishwasher());
        }

        // Alarm system button
        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new alarm_system());
        }

        // Watering system button
        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new watering_system());
        }

        private void current_events_container_Paint(object sender, PaintEventArgs e)
        {

        }
        
        // Coffee maker button
        private void coffee_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new coffee_making());
        }

        // Pet Feeder button
        private void pet_feeder_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new pet_feeder());
        }
        //Vacuum cleaner button
        private void vacuum_btn_Click(object sender, EventArgs e)
        {
            openChildForm(new vacuumCleaner());
            
         
        }

        //Fridge button
        private void button16_Click(object sender, EventArgs e)
        {
            openChildForm(new Fridge());
        }
    }
}

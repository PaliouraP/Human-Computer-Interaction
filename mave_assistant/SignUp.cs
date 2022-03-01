using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace mave_assistant
{
    public partial class SignUp : Form
    {
        String connectionString = "Data Source=mave.db;Version=3;";
        SQLiteConnection conn;

        public static string SetValueForUsername = "";
        public static string SetValueForPassword = "";
        public static string SetValueForName = "";
        public static string SetValueForDob = ""; // date of birth
        public static string SetValueForPicture = "Resources/user_2.png";
        public static string SetValueForPet = "";
        public SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void upload_pfp_btn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "JPEG Image (*.jpg)|*.jpg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    SetValueForPicture = filePath;
                    pictureBox2.ImageLocation = filePath;
                }
            }
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            SetValueForUsername = usernameTextBox.Text;
            SetValueForPassword = passwordTextBox.Text;
            SetValueForName = nameTextBox.Text;
            SetValueForDob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            SetValueForPet = petTextBox.Text;


            User u = new User();

            if (u.username.Trim() != "" && u.password.Trim() != "" && u.name.Trim() != "" && u.pet.Trim() != "")
            {
                String selectQuery = "Select username from users where username=@user";

                //SQL commands are called in a using(){} environment in order to avoid unintended locking of the database
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, conn))
                {
                    conn.Open(); //opening database
                    command.Parameters.AddWithValue("@user", u.username);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        //checking if user already exists in database, if they don't they get inserted, if they do their picture gets changed
                        if (!reader.Read())
                        {
                            //inserting new user in database
                            String insertQuery = "Insert into users(username, name, password, dob, picture, pet) values('" + u.username + "', '" + u.name + "', '" + u.password + "', '" + u.dob + "', '" + u.picture + "','" + u.pet +"')";
                            using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("You signed up succesfully!");
                                conn.Close(); //closing database
                                Login f = new Login();
                                f.Show(); //shows Login
                                this.Close(); //closes sign up
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username already exists.");
                        }
                    }

                }
            }
            else if (u.username.Trim() == "")
            {
                MessageBox.Show("Username can't be empty.");
            }
            else if (u.password.Trim() == "")
            {
                MessageBox.Show("Password can't be empty.");
            }
            else if (u.name.Trim() == "")
            {
                MessageBox.Show("Name can't be empty.");
            }
            else if (u.pet.Trim() == "")
            {
                MessageBox.Show("Pet's Name can't be empty.");
            }
            else 
            {
                MessageBox.Show("Something went horribly wrong.");
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            conn = new SQLiteConnection(connectionString); //connecting database
        }

        private void remove_pfp_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "Resources/user_2.png";
            SetValueForPicture = "Resources/user_2.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForUsername = usernameTextBox.Text;
            SetValueForPassword = passwordTextBox.Text;
            SetValueForName = nameTextBox.Text;
            SetValueForDob = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            User u = new User();

            if (u.username.Trim() != "" && u.password.Trim() != "" && u.name.Trim() != "")
            {
                String selectQuery = "Select username from users where username=@user";

                //SQL commands are called in a using(){} environment in order to avoid unintended locking of the database
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, conn))
                {
                    conn.Open(); //opening database
                    command.Parameters.AddWithValue("@user", u.username);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        //checking if user already exists in database, if they don't they get inserted, if they do their picture gets changed
                        if (!reader.Read())
                        {
                            //inserting new user in database
                            String insertQuery = "Insert into users(username, name, password, dob, picture) values('" + u.username + "', '" + u.name + "', '" + u.password + "', '" + u.dob + "', '" + u.picture + "')";
                            using (SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn))
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("You signed up succesfully!");
                                conn.Close(); //closing database
                                Login f = new Login();
                                f.Show(); //shows Login
                                this.Close(); //closes sign up
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username already exists.");
                        }
                    }

                }
            }
            else if (u.username.Trim() == "")
            {
                MessageBox.Show("Username can't be empty.");
            }
            else if (u.password.Trim() == "")
            {
                MessageBox.Show("Password can't be empty.");
            }
            else if (u.name.Trim() == "")
            {
                MessageBox.Show("Name can't be empty.");
            }
            else
            {
                MessageBox.Show("Something went horribly wrong.");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login f = new Login();
            f.Show(); //shows Login
            this.Close(); //closes sign up
        }
    }
}

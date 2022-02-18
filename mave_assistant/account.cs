using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class account : Form
    {
        string username = "";
        string u_name = "";
        string password = "";
        string birth_date = "";
        string pic_path = "";
        public account(string usr, string pass, string nm, string bd, string pfp)
        {
            username = usr;
            u_name = nm;
            password = pass;
            birth_date = bd;
            pic_path = pfp;
            InitializeComponent();
        }

        private void account_Load(object sender, EventArgs e)
        {
            user.Text = username;
            pass.Text = password;
            name.Text = u_name;
            dob.Text = birth_date;
            profile.ImageLocation = pic_path;
        }
    }
}

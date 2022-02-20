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
        string birth_date = "";
        string pic_path = "";
        string pet_name = "";
        public account(string usr, string pass, string nm, string bd, string pfp, string pn)
        {
            username = usr;
            u_name = nm;
            birth_date = bd;
            pic_path = pfp;
            pet_name = pn;
            InitializeComponent();
        }

        private void account_Load(object sender, EventArgs e)
        {
            name_tag.Text = u_name;
            user.Text = username;
            name.Text = u_name;
            dob.Text = birth_date;
            pet.Text = pet_name;
            profile.ImageLocation = pic_path;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pass_Click(object sender, EventArgs e)
        {

        }
    }
}

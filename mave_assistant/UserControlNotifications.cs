using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class UserControlNotifications : UserControl
    {
        public UserControlNotifications()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}

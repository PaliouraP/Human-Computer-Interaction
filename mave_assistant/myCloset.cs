using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class myCloset : Form
    {
        public myCloset()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void myCloset_Load(object sender, EventArgs e)
        {
            foreach (Outfit obj in SmartCloset.outfits)
            {
                if (obj.available)
                {
                    UserControlMyOutfit ucout = new UserControlMyOutfit();

                    ucout.pictureBox1.BackgroundImage = Image.FromFile(obj.pic);
                    outfit_container.Controls.Add(ucout);
                }
            }
        }
    }
}

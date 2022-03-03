using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class Washer : Form
    {
        public Washer()
        {
            InitializeComponent();
        }

        private void changePicture(int percentage)
        {
            if (percentage < 15)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#ff0033");
                // progressBar.InnerColor = ColorTranslator.FromHtml("#4bb543");
                BinMessage.Text = "You need to add laundry detergent!";
            }
            else if (percentage >= 15 && percentage < 40)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#eed202");
                // progressBar.InnerColor = ColorTranslator.FromHtml("#eed202");
                BinMessage.Text = "You should consider adding laundry detergent!";

            }
            else
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#4bb543");
                //progressBar.InnerColor = ColorTranslator.FromHtml("#ff0033");
                BinMessage.Text = "No need to add laundry detergent yet!";
            }
        }

        private void wash_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed -insert program- wash at " + dateTimePicker1.Text + " succesfully!");
        }

        private void Washer_Load(object sender, EventArgs e)
        {
            progressBar.Value = Login.SetValueForLaundryDetergent;
            progressBar.Text = Login.SetValueForLaundryDetergent.ToString() + "%";
            changePicture(Login.SetValueForLaundryDetergent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Login.SetValueForDishSoap < 15)
            {
                MessageBox.Show("You need to add laundry detergent to the dishwasher first!");
            }
            else
            {
                MessageBox.Show("Programmed -insert program- wash at " + dateTimePicker1.Text + " succesfully!");
            }
        }
    }
}

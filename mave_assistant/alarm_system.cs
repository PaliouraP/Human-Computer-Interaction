using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class alarm_system : Form
    {
        public alarm_system()
        {
            InitializeComponent();
        }

        private void changePicture(int percentage)
        {
            if (percentage < 70 && percentage > 50)
            {         
                progressBar.ProgressColor = ColorTranslator.FromHtml("#eed202");
                message.Text = "Medium battery amount.";
            }
            else if (percentage >= 70)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#4bb543");
                message.Text = "Full battery amount.";
            }
            else
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#ff0033");
                message.Text = "Low battery amount.";
            }
        }

        private void alarm_system_Load(object sender, EventArgs e)
        {
            progressBar.Value = Login.SetValueForPercentage;
            percentage.Text = Login.SetValueForPercentage.ToString() + "%";
            changePicture(Login.SetValueForPercentage);
        }
    }
}

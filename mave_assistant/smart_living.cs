using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class smart_living : Form
    {
        public smart_living()
        {
            InitializeComponent();
        }               
             
              
        private void smart_living_Load(object sender, EventArgs e)
        {
            progressBar.Value = Login.SetValueForPercentage;
            progressBar.Text = Login.SetValueForPercentage.ToString() + "%";
            changePicture(Login.SetValueForPercentage);
        }
        private void changePicture(int percentage)
        {
            if (percentage < 60)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#4bb543");
               // progressBar.InnerColor = ColorTranslator.FromHtml("#4bb543");
                BinMessage.Text = "No need to take the trash out yet!";
            }
            else if (percentage >= 60 && percentage < 75)
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#eed202");
               // progressBar.InnerColor = ColorTranslator.FromHtml("#eed202");
                BinMessage.Text = "You should consider taking the trash out!";
            }
            else
            {
                progressBar.ProgressColor = ColorTranslator.FromHtml("#ff0033");
               //progressBar.InnerColor = ColorTranslator.FromHtml("#ff0033");
                BinMessage.Text = "You need to take the trash out!";
            }
        }
    }
}

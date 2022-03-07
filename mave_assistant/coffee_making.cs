using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class coffee_making : Form
    {
        // Initializing a local reference to coffee images on quick acess panel
        Image cappucino = Properties.Resources.cappucino;
        Image espresso_milk = Properties.Resources.milk_espresso;
        Image espr = Properties.Resources.espresso_coffee;
        Image nes = Properties.Resources.nes_cafe;
        Image fltr = Properties.Resources.filter_coffee;
        Image fltr_milk = Properties.Resources.filter_milk;

        public coffee_making()
        {
            InitializeComponent();

            // Setting images when form loads
            pictureBox21.Image = cappucino;
            pictureBox23.Image = espresso_milk;
            pictureBox24.Image = espr;
            pictureBox25.Image = nes;
            pictureBox26.Image = fltr;
            pictureBox27.Image = fltr_milk;
        }

        
        private void panel3_MouseEnter(object sender, EventArgs e)
        {

        }
        

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.BackColor = Color.Gray;
        }

        // Make coffee button
        private void button1_Click(object sender, EventArgs e)
        {
            // Checking for unclicked picture boxes
            if ((type == null || blend == null || sug == null || mlk == null) || (bc_bl == "no" || bc_type == "no" || bc_s == "no" || bc_mlk == "no"))
            {
                MessageBox.Show("You haven't chosen all of the ingredients.");

            } 
            else
            {
                MessageBox.Show("Coffee making started.");

                // "Refreshing"
                espresso_type.BackColor = Color.Transparent;
                filter_type.BackColor = Color.Transparent;
                nescafe_type.BackColor = Color.Transparent;
                watemala_blend.BackColor = Color.Transparent;
                kenya_blend.BackColor = Color.Transparent;
                brazil_blend.BackColor = Color.Transparent;
                full_sugar_amount.BackColor = Color.Transparent;
                med_sugar_amount.BackColor = Color.Transparent;
                sugar_free_amount.BackColor = Color.Transparent;
                cow_milk.BackColor = Color.Transparent;
                alm_milk.BackColor = Color.Transparent;
                no_milk_am.BackColor = Color.Transparent;
            }
            
        }

        // Schedule button
        private void button2_Click(object sender, EventArgs e)
        {
            // Checking for unclicked picture boxes
            if ((type == null || blend == null || sug == null || mlk == null) || (bc_bl == "no" || bc_type == "no" || bc_s == "no" || bc_mlk == "no"))
            {
                MessageBox.Show("You haven't chosen all of the ingredients.");
            }
            else
            {
                // Show scheduling coffee form
                make_coffee cf = new make_coffee(type, blend, sug, mlk);
                cf.ShowDialog();

                // "Refreshing"
                espresso_type.BackColor = Color.Transparent;
                filter_type.BackColor = Color.Transparent;
                nescafe_type.BackColor = Color.Transparent;
                watemala_blend.BackColor = Color.Transparent;
                kenya_blend.BackColor = Color.Transparent;
                brazil_blend.BackColor = Color.Transparent;
                full_sugar_amount.BackColor = Color.Transparent;
                med_sugar_amount.BackColor = Color.Transparent;
                sugar_free_amount.BackColor = Color.Transparent;
                cow_milk.BackColor = Color.Transparent;
                alm_milk.BackColor = Color.Transparent;
                no_milk_am.BackColor = Color.Transparent;
            }
            
        }

        // Variables that will pass information to scheduling forms
        string type;
        string blend;
        string sug;
        string mlk;

        // Variables for picture box back color control
        string bc_type;
        string bc_bl;
        string bc_s;
        string bc_mlk;

        // Setting the values of variables
        // Coffee type
        private void espresso_type_Click(object sender, EventArgs e)
        {
            // There can't be two or more picture boxes with grey back color
            if (type != "Espresso")
            {
                filter_type.BackColor = Color.Transparent;
                nescafe_type.BackColor = Color.Transparent;
            }

            // Back color handling
            type = "Espresso";
            if (espresso_type.BackColor == Color.Transparent)
            {
                espresso_type.BackColor = Color.Gray;
                bc_type = "yes";
            } 
            else
            {
                espresso_type.BackColor = Color.Transparent;
                bc_type = "no";
            }
        }

        private void filter_type_Click(object sender, EventArgs e)
        {
            if (type != "Filter")
            {
                espresso_type.BackColor = Color.Transparent;
                nescafe_type.BackColor = Color.Transparent;
            }

            type = "Filter";
            if (filter_type.BackColor == Color.Transparent)
            {
                filter_type.BackColor = Color.Gray;
                bc_type = "yes";
            }
            else
            {
                filter_type.BackColor = Color.Transparent;
                bc_type = "no";
            }
        }

        private void nescafe_type_Click(object sender, EventArgs e)
        {
            if (type != "Nescafe")
            {
                filter_type.BackColor = Color.Transparent;
                espresso_type.BackColor = Color.Transparent;
            }
            type = "Nescafe";
            if (nescafe_type.BackColor == Color.Transparent)
            {
                nescafe_type.BackColor = Color.Gray;
                bc_type = "yes";
            }
            else
            {
                nescafe_type.BackColor = Color.Transparent;
                bc_type = "no";
            }
        }

        // Coffee blend
        private void watemala_blend_Click(object sender, EventArgs e)
        {
            if (blend != "Watemala")
            {
                kenya_blend.BackColor = Color.Transparent;
                brazil_blend.BackColor = Color.Transparent;
            }
            blend = "Watemala";
            if (watemala_blend.BackColor == Color.Transparent)
            {
                watemala_blend.BackColor = Color.Gray;
                bc_bl= "yes";
            }
            else
            {
                watemala_blend.BackColor = Color.Transparent;
                bc_bl = "no";
            }
        }

        private void kenya_blend_Click(object sender, EventArgs e)
        {
            if (blend != "Kenya")
            {
                watemala_blend.BackColor = Color.Transparent;
                brazil_blend.BackColor = Color.Transparent;
            }
            blend = "Kenya";
            if (kenya_blend.BackColor == Color.Transparent)
            {
                kenya_blend.BackColor = Color.Gray;
                bc_bl = "yes";
            }
            else
            {
                kenya_blend.BackColor = Color.Transparent;
                bc_bl = "no";
            }
        }

        private void brazil_blend_Click(object sender, EventArgs e)
        {
            if (blend != "Brazil")
            {
                kenya_blend.BackColor = Color.Transparent;
                watemala_blend.BackColor = Color.Transparent;
            }
            blend = "Brazil";
            if (brazil_blend.BackColor == Color.Transparent)
            {
                brazil_blend.BackColor = Color.Gray;
                bc_bl = "yes";
            }
            else
            {
                brazil_blend.BackColor = Color.Transparent;
                bc_bl = "no";
            }
        }

        // Sugar
        private void full_sugar_amount_Click(object sender, EventArgs e)
        {
            if (sug != "100g")
            {
                med_sugar_amount.BackColor = Color.Transparent;
                sugar_free_amount.BackColor = Color.Transparent;
            }

            sug = "100g";
            if (full_sugar_amount.BackColor == Color.Transparent)
            {
                full_sugar_amount.BackColor = Color.Gray;
                bc_s = "yes";
            }
            else
            {
                full_sugar_amount.BackColor = Color.Transparent;
                bc_s = "no";
            }
        }

        private void med_sugar_amount_Click(object sender, EventArgs e)
        {
            if (sug != "50g")
            {
                full_sugar_amount.BackColor = Color.Transparent;
                sugar_free_amount.BackColor = Color.Transparent;
            }

            sug = "50g";
            if (med_sugar_amount.BackColor == Color.Transparent)
            {
                med_sugar_amount.BackColor = Color.Gray;
                bc_s = "yes";
            }
            else
            {
                med_sugar_amount.BackColor = Color.Transparent;
                bc_s = "no";
            }
        }

        private void sugar_free_amount_Click(object sender, EventArgs e)
        {
            if (sug != "Sugar Free")
            {
                med_sugar_amount.BackColor = Color.Transparent;
                full_sugar_amount.BackColor = Color.Transparent;
            }

            sug = "Sugar Free";
            if (sugar_free_amount.BackColor == Color.Transparent)
            {
                sugar_free_amount.BackColor = Color.Gray;
                bc_s = "yes";
            }
            else
            {
                sugar_free_amount.BackColor = Color.Transparent;
                bc_s = "no";
            }

            
        }

        // Milk
        private void cow_milk_Click(object sender, EventArgs e)
        {
            if (mlk != "Milk")
            {
                alm_milk.BackColor = Color.Transparent;
                no_milk_am.BackColor = Color.Transparent;
            }

            mlk = "Milk";
            if (cow_milk.BackColor == Color.Transparent)
            {
                cow_milk.BackColor = Color.Gray;
                bc_mlk = "yes";
            }
            else
            {
                cow_milk.BackColor = Color.Transparent;
                bc_mlk = "no";
            }
        }

        private void alm_milk_Click(object sender, EventArgs e)
        {
            if (mlk != "Almond Milk")
            {
                cow_milk.BackColor = Color.Transparent;
                no_milk_am.BackColor = Color.Transparent;
            }

            mlk = "Almond Milk";
            if (alm_milk.BackColor == Color.Transparent)
            {
                alm_milk.BackColor = Color.Gray;
                bc_mlk = "yes";
            }
            else
            {
                alm_milk.BackColor = Color.Transparent;
                bc_mlk = "no";
            }
        }

        private void no_milk_am_Click(object sender, EventArgs e)
        {
            if (mlk != "No Milk")
            {
                alm_milk.BackColor = Color.Transparent;
                cow_milk.BackColor = Color.Transparent;
            }

            mlk = "No Milk";
            if (no_milk_am.BackColor == Color.Transparent)
            {
                no_milk_am.BackColor = Color.Gray;
                bc_mlk = "yes";
            }
            else
            {
                no_milk_am.BackColor = Color.Transparent;
                bc_mlk = "no";
            }
        }

        // Hovering mouse above the images
        private void espresso_type_MouseEnter(object sender, EventArgs e)
        {
            PictureBox box = new PictureBox();
            box.BorderStyle = BorderStyle.FixedSingle;
        }

        // When clicking on an image from quick access panel a new form appears
        private void no_milk_am_MouseLeave(object sender, EventArgs e)
        {
            PictureBox box = new PictureBox();
            box.BorderStyle = BorderStyle.None;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            quick_access_coffee f = new quick_access_coffee(pictureBox21.Image, "Cappucino");
            f.ShowDialog();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            quick_access_coffee f = new quick_access_coffee(pictureBox23.Image, "Machiato");
            f.ShowDialog();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            quick_access_coffee f = new quick_access_coffee(pictureBox24.Image, "Espresso");
            f.ShowDialog();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            quick_access_coffee f = new quick_access_coffee(pictureBox25.Image, "Nescafe");
            f.ShowDialog();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            quick_access_coffee f = new quick_access_coffee(pictureBox26.Image, "Filter");
            f.ShowDialog();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            quick_access_coffee f = new quick_access_coffee(pictureBox27.Image, "Filter Latte");
            f.ShowDialog();
        }
    }
}

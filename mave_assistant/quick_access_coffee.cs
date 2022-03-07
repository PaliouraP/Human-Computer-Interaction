using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace mave_assistant
{
    public partial class quick_access_coffee : Form
    {

        // Initializing a local reference to coffee images on quick access panel
        Image cappucino = Properties.Resources.cappucino;
        Image espresso_milk = Properties.Resources.milk_espresso;
        Image espr = Properties.Resources.espresso_coffee;
        Image nes = Properties.Resources.nes_cafe;
        Image fltr = Properties.Resources.filter_coffee;
        Image fltr_milk = Properties.Resources.filter_milk;
        Image espr_seeds = Properties.Resources.espresso1;
        Image filtr_seeds = Properties.Resources.filter1;
        Image nes_seeds = Properties.Resources.nes;
        Image bl_espr = Properties.Resources.watemala;
        Image milk = Properties.Resources.milk;
        Image almond = Properties.Resources.almond_milk;
        Image dairy_free = Properties.Resources.no_milk;
        Image s1 = Properties.Resources.no_sugar;
        Image s2 = Properties.Resources.sweet;
        Image s3 = Properties.Resources.medium_sugar;

        public quick_access_coffee(Image img, string name)
        {
            InitializeComponent();
            coffee_image.Image = img;
            name_label.Text = name;



        }

        private void quick_access_coffee_Load(object sender, EventArgs e)
        {

            // Setting coffee name label
            if (name_label.Text == "Cappucino")
            {
                name_label.Text = "Cappucino";
                ing1.Image = espr_seeds;
                ing2.Image = bl_espr;
                ing4.Image = milk;
                ing3.Image = s1;
                l1.Text = "Espresso";
                l2.Text = "Watemala";
                l3.Text = "No Sugar / Milk";
            }
            else if (name_label.Text == "Macchiato")
            {
                name_label.Text = "Macchiato";
                ing1.Image = espr_seeds;
                ing2.Image = bl_espr;
                ing4.Image = milk;
                ing3.Image = s3;
                l1.Text = "Espresso";
                l2.Text = "Watemala";
                l3.Text = "50gr / Milk";
            }
            else if (name_label.Text == "Espresso")
            {
                name_label.Text = "Espresso";
                ing1.Image = espr_seeds;
                ing2.Image = bl_espr;
                ing4.Image = dairy_free;
                ing3.Image = s1;
                l1.Text = "Espresso";
                l2.Text = "Watemala";
                l3.Text = "No Sugar / No Milk";
            }
            else if (name_label.Text == "Nescafe")
            {
                name_label.Text = "Nescafe";
                ing1.Image = nes_seeds;
                ing2.Image = bl_espr;
                ing4.Image = dairy_free;
                ing3.Image = s2;
                l1.Text = "Nescafe";
                l2.Text = "Watemala";
                l3.Text = "100g / Milk";
            }
            else if (name_label.Text == "Filter")
            {
                name_label.Text = "Filter";
                ing1.Image = filtr_seeds;
                ing2.Image = bl_espr;
                ing4.Image = dairy_free;
                ing3.Image = s1;
                l1.Text = "Filter";
                l2.Text = "Watemala";
                l3.Text = "No Sugar / No Milk";
            }
            else if (name_label.Text == "Filter Latte")
            {
                name_label.Text = "Filter Latte";
                ing1.Image = filtr_seeds;
                ing2.Image = bl_espr;
                ing4.Image = almond;
                ing3.Image = s3;
                l1.Text = "Filter";
                l2.Text = "Watemala";
                l3.Text = "50gr / Almond Milk";
            } 
        }

        // Make coffee button
        private void make_coffee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coffee making started.");
        }

        // Schedule coffee button
        private void schedule_Click(object sender, EventArgs e)
        {
            string[] ingr = l3.Text.Split("/");
            // Show scheduling coffee form
            make_coffee cf = new make_coffee(l1.Text, l2.Text, ingr[0], ingr[1]);
            cf.ShowDialog();
        }
    }
}

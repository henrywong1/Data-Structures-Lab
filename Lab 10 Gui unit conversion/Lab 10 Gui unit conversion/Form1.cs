using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_10_Gui_unit_conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double beard;
                double jiffies;
                double bottles;

                double inches;
                double minutes;
                double gallons;

                if (radioButton1.Checked)
                {
                    beard = double.Parse(beardBox.Text);
                    inches = beard / 5080000;
                    inchBox.Text = inches.ToString();

                    jiffies = double.Parse(jiffiesBox.Text);
                    bottles = double.Parse(bottleBox.Text);

                   
                    minutes = jiffies / 6000;
                    gallons = bottles / 5.047;

                    mintueBox.Text = minutes.ToString();
                    gallonBox.Text = gallons.ToString();
                  
                }
            }
            catch
            {
                //MessageBox.Show("ERROR");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            double beard;
            double jiffies;
            double bottles;

            double inches;
            double minutes;
            double gallons;

            if (radioButton2.Checked)
            {
                inches = double.Parse(inchBox.Text);
                minutes = double.Parse(mintueBox.Text);
                gallons = double.Parse(gallonBox.Text);

                beard = inches * 5080000;
                jiffies = minutes * 6000;
                bottles = gallons * 5.047;

                beardBox.Text = beard.ToString();
                jiffiesBox.Text = jiffies.ToString();
                bottleBox.Text = bottles.ToString();
            }
        }

        private void inchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab_10
{
    public partial class GallonLabel : Form
    {
        public GallonLabel()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                double beardNum;
             
                double jifNum;
                double bottleNum;
                double inches;

                if (radioButton1.Checked)
                {
                    beardNum = double.Parse(BeardSecon=-432ds.Text);
                    inches = double.Parse(InchLabel.Text);
                    inches = beardNum / 5101000;
                    InchLabel.Text = inches.ToString();
                }
            }

            catch
            {
                MessageBox.Show("Need to provide values.");
            }
        }
    }
}
